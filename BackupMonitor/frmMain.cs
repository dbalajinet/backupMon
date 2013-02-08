using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32.TaskScheduler;

namespace BackupMonitor
{
    public partial class frmMain : Form
    {
        #region Fields
        private List<Server> servers;

        public List<Server> Servers
        {
            get { return servers; }
        }

        public string MailString { get; set; }
        private string defaultMail = "jwarnes@samaritan.org";
        #endregion

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

        private void btnScheduleTasks_Click(object sender, EventArgs e)
        {

            using (var taskService = new TaskService())
            {
                if (taskService.GetTask("SP_Field_Monitor") == null)
                {
                    CreateTask(taskService);
                }
                else
                {
                    taskService.RootFolder.DeleteTask("SP_Field_Monitor");
                    CreateTask(taskService);
                }
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
            btnScheduleTasks.Enabled = (servers.Count > 0);
        }

        public void AddServer(Server s)
        {
            if(s.IsValid())
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

        private void btnScheduleTasks_MouseEnter(object sender, EventArgs e)
        {
            SetHelp("Schedule Task", "Set this monitor to run daily");
        }

        #endregion

        #region Persistant Data

        public void LoadConfiguration(string path = @"config.xml")
        {
            if(!File.Exists(path)) return;

            var settings = new XmlReaderSettings {IgnoreComments = true, IgnoreWhitespace = true};

            XmlReader r = XmlReader.Create(path, settings);

            r.ReadToDescendant("Mail");
            defaultMail = (r["default"] != "") ? r["default"] : "jwarnes@samaritan.org";
            MailString = r["recipients"].Replace(",", ", ");

            r.ReadToFollowing("Servers");
            r.ReadToDescendant("Server");
            do
            {
                var server = new Server
                    {
                        Name = r["name"],
                        Space = Convert.ToDouble(r["spaceValue"]),
                        spaceType = (SpaceType) Convert.ToInt16(r["spaceType"])
                    };

                //folders loop
                
                r.ReadToDescendant("Folder");
                do
                {
                    var folder = new Folder(r["path"], Convert.ToBoolean(Convert.ToInt16(r["recurse"])));
                    server.AddFolder(folder);
                } while (r.ReadToNextSibling("Folder"));
                 

               AddServer(server);
            } while (r.ReadToNextSibling("Server"));

            r.Close();


        }

        public void SaveConfiguration(string path = @"config.xml")
        {
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("   ");

            XmlWriter w = XmlWriter.Create(path, settings);
            w.WriteStartDocument();
            w.WriteStartElement("Config");

            //write mail information
            w.WriteStartElement("Mail");
            {
                w.WriteAttributeString("default", defaultMail);
                w.WriteAttributeString("recipients", MailString);
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
        #endregion

        public void CreateTask(TaskService service)
        {
            var path = Application.StartupPath;

            try
            {
                var task = service.AddTask("SP_Field_Monitor", new DailyTrigger(),
                                           new ExecAction(path + "\\SPFieldMonitor.exe",
                                                          "-user jwarnes -password \"correct horse battery staple\"",
                                                          path), "SYSTEM");
                MessageBox.Show(
                    "The daily task has been scheduled.\nIf you move any of the Field Monitor executables, you will need to click this button again to reschedule the task.",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "You need administrator privileges to schedule this task. Try running the program as an administrator.",
                    "Insufficient Access Rights", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
