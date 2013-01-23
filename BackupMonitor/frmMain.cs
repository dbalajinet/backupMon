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
        public List<Server> Servers
        {
            get { return servers; }
        }

        public frmMain()
        {
            InitializeComponent();
            servers = new List<Server>();
            ClearHelp();
        }

        #region UI Events
        private void btnMailList_Click(object sender, EventArgs e)
        {
            new frmMail().ShowDialog();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            new frmServer(this).ShowDialog();
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {
            new frmServer(this, lbServers.SelectedIndex).ShowDialog();
        }

        private void btnRemServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Permanently delete this server configuration?", "Remove Server", MessageBoxButtons.OKCancel) == DialogResult.OK)
                RemoveServer(lbServers.SelectedIndex);
        }
        #endregion

        #region Server List Methods
        public void RefreshServerList()
        {
            lbServers.Items.Clear();

            if (servers.Count < 1)
                return;

            foreach (Server s in servers)
            {
                lbServers.Items.Add(s.Name);
            }

            btnEditServer.Enabled = (servers.Count > 0);
            btnRemServer.Enabled = (servers.Count > 0);
        }

        public void AddServer(Server s)
        {
            servers.Add(s);
            RefreshServerList();
        }

        public void EditServer(int index, Server s)
        {
            servers[index] = s;
            RefreshServerList();
        }

        public void RemoveServer(int index)
        {
            servers.RemoveAt(index);
            RefreshServerList();
        }

        #endregion

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

        private void control_MouseLeave(object sender, EventArgs e)
        {
            ClearHelp();
        }

        private void btnEditServer_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Edit Server", "Edit the configuration for a server");
        }

        private void btnRemServer_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Remove Server", "Stop monitoring a server");
        }

        private void btnMailList_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Mail","Configure which email addresses receive reports");
        }

        #endregion



    }
}
