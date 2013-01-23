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
        #region Fields, constructors, form load
        public frmMain ParentFrm { get; set; }
        private List<Folder> folders;
        public List<Folder> Folders
        {
            get { return folders; }
        }

        private int editServerIndex = -1;

        public frmServer(frmMain parent)
        {
            InitializeComponent();
            ParentFrm = parent;
        }

        public frmServer(frmMain parent, int serverIndex)
        {
            InitializeComponent();
            ParentFrm = parent;
            editServerIndex = serverIndex;
        }

      
        #endregion

        #region UI Events

        private void frmServer_Load(object sender, EventArgs e)
        {
            cbThreshholdUnits.SelectedIndex = 0;
            folders = new List<Folder>();
            ClearHelp();
            if(editServerIndex > -1)
                LoadServer(ParentFrm.Servers[editServerIndex]);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            new frmFolder(this).ShowDialog();
        }

        private void btnRemFolder_Click(object sender, EventArgs e)
        {
            RemoveFolder(lbFolders.SelectedIndex);
        }

        private void btnEditFolder_Click(object sender, EventArgs e)
        {
            new frmFolder(this, lbFolders.SelectedIndex).ShowDialog();
        }

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            if (editServerIndex == -1)
                ParentFrm.AddServer(CreateServer());
            else
                ParentFrm.EditServer(editServerIndex, CreateServer());

            Close();
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            EnableSave();
        }

        private void txtThreshhold_TextChanged(object sender, EventArgs e)
        {
            EnableSave();
        }

        private void EnableSave()
        {
            btnSaveServer.Enabled = (txtServerName.Text != "" && Validator.IsDouble(txtThreshhold) && folders.Count > 0);
        }
        #endregion

        #region Folder List Methods
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

        public void ChangeFolder(int index, Folder folder)
        {
            folders[index] = folder;
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
            btnEditFolder.Enabled = (folders.Count > 0);
            btnRemFolder.Enabled = (folders.Count > 0);
            EnableSave();
        }
        #endregion

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

        #region Help Tooltips

        private void SetHelp(string item, string tip)
        {
            lblHelpItemName.Text = item;
            lblHelpString.Text = tip;
        }

        private void ClearHelp()
        {
            SetHelp("","");
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void txtServerName_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Name", "An identifier for this server");
        }

        private void txtThreshhold_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Space", "Set the low storage space warning threshhold");
        }

        private void cbThreshholdUnits_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Space Units", "GB/MB/TB or as a percent of total storage space");
        }

        private void btnAddFolder_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Add Folder", "Adds a directory for monitoring");
        }

        private void btnEditFolder_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Edit Folder", "Edit the settings for a directory");
        }

        private void btnRemFolder_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Remove Folder", "Remove a folder from the list");
        }

        private void btnSaveServer_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Save Server", "Save the current settings for this server");
        }

        private void lbFolders_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Folders", "All directories you are currently monitoring");
        }



        #endregion



    }
}
