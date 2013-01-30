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
    public partial class frmMail : Form
    {
        private frmMain parentFrm;
        public frmMail(frmMain parent)
        {
            InitializeComponent();
            ClearHelp();
            parentFrm = parent;

            txtMailList.Text = parentFrm.MailString;
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

        private void txtMailList_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Mailing List", "Seperate addresses with a comma");
        }

        private void btnSaveMail_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Save", "Save the list");
        }

        #endregion

        private void btnSaveMail_Click(object sender, EventArgs e)
        {
            parentFrm.MailString = txtMailList.Text.Replace(" ", string.Empty);
            parentFrm.SaveConfiguration();
            Close();
        }

    }
}
