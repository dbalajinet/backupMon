using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackupMonitor
{
    public partial class frmServer : Form
    {
        #region Properties, internal fields, and constructors
        public frmMain ParentFrm { get; set; }
        private List<Folder> folders;

        public frmServer(frmMain parent)
        {
            InitializeComponent();
            ParentFrm = parent;
        }

        #endregion

        private void frmServer_Load(object sender, EventArgs e)
        {
            cbThreshholdUnits.SelectedIndex = 0;
            folders = new List<Folder>();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            new frmFolder(this).Show();
        }

        public void AddFolder(Folder folder)
        {
            folders.Add(folder);
            RefreshFolderList();
        }

        public void RemoveFolder(int index)
        {
            folders.RemoveAt(index);
            RefreshFolderList();
        }
        
        private void RefreshFolderList()
        {
            lbFolders.Items.Clear();
            foreach (Folder f in folders)
            {
                //TODO: make folder shorthand for space reasons
                lbFolders.Items.Add(f.Path);
            }
            FormComplete();
        }

        private void btnRemFolder_Click(object sender, EventArgs e)
        {
            RemoveFolder(lbFolders.SelectedIndex);
        }

        private void FormComplete()
        {
            btnSaveServer.Enabled = (txtServerName.Text != "" && Validator.IsDouble(txtThreshhold) && folders.Count > 0);
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            FormComplete();
        }

        private void txtThreshhold_TextChanged(object sender, EventArgs e)
        {
            FormComplete();
        }

        private Server CreateServer()
        {
            Server s = new Server();
            s.Name = txtServerName.Text;
            s.Space = Convert.ToDouble(txtThreshhold.Text);
            s.spaceType = (SpaceType)cbThreshholdUnits.SelectedIndex;
            foreach (Folder f in folders)
            {
                s.AddFolder(f);
            }

            
            return s;
        }

        public void LoadServer(Server s)
        {
            txtServerName.Text = s.Name;
            txtThreshhold.Text = s.Space.ToString();
            cbThreshholdUnits.SelectedIndex = (int) s.spaceType;
            foreach (Folder f in s.Folders)
            {
                folders.Add(f);
            }
            RefreshFolderList();
        }

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            ParentFrm.AddServer(CreateServer());
            Close();
        }


    }
}
