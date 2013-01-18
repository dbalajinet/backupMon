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
        public frmMain Parent { get; set; }
        private Server server;

        public frmServer(frmMain parent)
        {
            InitializeComponent();
            Parent = parent;
        }

    #endregion

        private void frmServer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            new frmFolder().Show();
        }

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
