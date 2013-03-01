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
    public partial class frmTypes : Form
    {
        private frmMain parentFrm;

        public frmTypes(frmMain parent)
        {
            InitializeComponent();
            this.parentFrm = parent;
            txtTypes.Text = parentFrm.FileTypes;
            ClearHelp();
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

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Save", "Save the file types");
        }

        private void txtTypes_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("File Types", "Enter the file patterns to search for, in the format *.xxx, *.yyy");
        }
        #endregion

        private void txtTypes_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtTypes.Text != "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parentFrm.FileTypes = txtTypes.Text;
            parentFrm.SaveConfiguration();
            this.Close();
        }
    }
}
