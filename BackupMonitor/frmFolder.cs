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

        public frmFolder(frmServer parent)
        {
            InitializeComponent();
            ParentFrm = parent;
        }

        private void SelectFolder()
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            open.ShowDialog();

            if (open.SelectedPath != "")
            {
                txtFolderPath.Text = open.SelectedPath;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            btnSaveFolder.Enabled = (txtFolderPath.Text != "") ? true : false;

        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            ParentFrm.AddFolder(new Folder(txtFolderPath.Text, chkBoxSubdirectories.Checked));
            Close();
        }
    }
}
