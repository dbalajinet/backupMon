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
        private List<Server> servers;

        public frmMain()
        {
            InitializeComponent();
            servers = new List<Server>();
            ClearHelp();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            new frmServer(this).Show();
        }

        private void btnMailList_Click(object sender, EventArgs e)
        {
            new frmMail().Show();
        }

        public void RefreshServerList()
        {
            lbServers.Items.Clear();

            if (servers.Count < 1)
                return;

            foreach (Server s in servers)
            {
                lbServers.Items.Add(s.Name);
            }
        }

        public void AddServer(Server s)
        {
            servers.Add(s);
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

        private void btnAddServer_MouseEnter(object sender, EventArgs e)
        {
           SetHelp("New Server", "Configure a new server to monitor");
        }

     
        private void btnAddServer_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void btnEditServer_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Edit Server", "Edit the configuration for a server");
        }

        private void btnEditServer_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void btnRemServer_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Remove Server", "Stop monitoring a server");
        }

        private void btnRemServer_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void btnMailList_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Mail","Configure which email addresses receive reports");
        }

        private void btnMailList_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }
        #endregion

    }
}
