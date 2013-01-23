using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BackupMonitor
{
    public partial class frmMain : Form
    {
        private List<Server> servers;

        public List<Server> Servers
        {
            get { return servers; }
        }

        public string MailString { get; set; }
        private string defaultMail;

        public frmMain()
        {
            InitializeComponent();
            servers = new List<Server>();
            ClearHelp();
        }

        #region UI Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
            SaveConfiguration(@"Test.xml");
        }

        private void btnMailList_Click(object sender, EventArgs e)
        {
            new frmMail(this).ShowDialog();
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
            {
                RemoveServer(lbServers.SelectedIndex);
                SaveConfiguration();
            }
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

        public void LoadConfiguration(string path = @"config.xml")
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;

            XmlReader r = XmlReader.Create(path, settings);

            r.ReadToDescendant("Mail");
            defaultMail = r["default"];
            MailString = r.ReadString().Replace(" ", string.Empty);

            r.ReadToFollowing("Servers");
            r.ReadToDescendant("Server");
            do
            {
                Server server = new Server();
                server.Name = r["name"];
                server.Space = Convert.ToDouble(r["spaceValue"]);
                server.spaceType = (SpaceType) Convert.ToInt16(r["spaceType"]);

                //folders loop
                
                r.ReadToDescendant("Folder");
                do
                {
                    Folder folder = new Folder(r["path"], Convert.ToBoolean(Convert.ToInt16(r["recurse"])));
                    server.AddFolder(folder);
                } while (r.ReadToNextSibling("Folder"));
                 

               AddServer(server);
            } while (r.ReadToNextSibling("Server"));

            r.Close();


        }

        public void SaveConfiguration(string path = @"config.xml")
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("   ");

            XmlWriter w = XmlWriter.Create(path, settings);
            w.WriteStartDocument();
            w.WriteStartElement("Config");

            //write mail information
            w.WriteStartElement("Mail");
            {
                w.WriteAttributeString("default", defaultMail);
                w.WriteString(MailString);
            }
            w.WriteEndElement();

            //server information
            w.WriteStartElement("Servers");
            foreach (Server s in servers)
            {
                w.WriteStartElement("Server");
                {
                    w.WriteAttributeString("name", s.Name);
                    w.WriteAttributeString("spaceValue", s.Space.ToString());
                    int spaceTypeNumber = (int) s.spaceType;
                    w.WriteAttributeString("spaceType", spaceTypeNumber.ToString());
                    
                    //folder information
                    foreach (Folder f in s.Folders)
                    {
                        w.WriteStartElement("Folder");
                        {
                            w.WriteAttributeString("path", f.Path);
                            w.WriteAttributeString("recurse", Convert.ToInt16(f.RecurseSubdirectories).ToString());
                        }
                        w.WriteEndElement();
                    }
                }
                w.WriteEndElement();

            }
            w.WriteEndElement();

            w.WriteEndElement();
            w.Close();

        }
    }
}
