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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            new frmServer().Show();
        }

        private void btnMailList_Click(object sender, EventArgs e)
        {
            new frmMail().Show();
        }

    }
}
