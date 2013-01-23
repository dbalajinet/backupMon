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
    public partial class frmFolder : Form
    {
        private frmServer ParentFrm { get; set; }
        private int editFolderIndex = -1;

        public frmFolder(frmServer parent)
        {
            InitializeComponent();
            ParentFrm = parent;
        }
        public frmFolder(frmServer parent, int index)
        {
            InitializeComponent();
            ParentFrm = parent;
            editFolderIndex = index;
        }

        #region UI Events
        private void frmFolder_Load(object sender, EventArgs e)
        {
            ClearHelp();
            if(editFolderIndex > -1)
                LoadFolder(ParentFrm.Folders[editFolderIndex]);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            if (editFolderIndex == -1)
                ParentFrm.AddFolder(new Folder(txtFolderPath.Text, chkBoxSubdirectories.Checked));
            else
                ParentFrm.ChangeFolder(editFolderIndex, new Folder(txtFolderPath.Text, chkBoxSubdirectories.Checked));

            Close();
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            btnSaveFolder.Enabled = (txtFolderPath.Text != "") ? true : false;

        }
        #endregion

        private void SelectFolder()
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            open.ShowDialog();

            if (open.SelectedPath != "")
            {
                txtFolderPath.Text = open.SelectedPath;
            }
        }

        private void LoadFolder(Folder f)
        {
            txtFolderPath.Text = f.Path;
            chkBoxSubdirectories.Checked = f.RecurseSubdirectories;
        }

        #region Help Tooltips
        private void SetHelp(string item, string tip)
        {
            lblHelpItemName.Text = item;
            lblHelpString.Text = tip;
        }

        private void ClearHelp()
        {
            SetHelp("", "");
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void txtFolderPath_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Path", "The path of the directory to monitor");
        }

        private void chkBoxSubdirectories_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Recurse Subdirectories", "Check all subdirectories in this folder");
        }

        private void btnSaveFolder_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Save", "Add this folder to the list of monitored directories. Make sure the path is correct!");
        }

        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Browse", "Select a folder to monitor");
        }
        #endregion
    }
}
