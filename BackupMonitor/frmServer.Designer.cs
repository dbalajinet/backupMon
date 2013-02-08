namespace BackupMonitor
{
    partial class frmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThreshhold = new System.Windows.Forms.TextBox();
            this.cbThreshholdUnits = new System.Windows.Forms.ComboBox();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnEditFolder = new System.Windows.Forms.Button();
            this.btnRemFolder = new System.Windows.Forms.Button();
            this.btnSaveServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHelpItemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHelpString = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server &Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(107, 24);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(166, 20);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            this.txtServerName.MouseEnter += new System.EventHandler(this.txtServerName_MouseEnter);
            this.txtServerName.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Space &Threshhold:";
            // 
            // txtThreshhold
            // 
            this.txtThreshhold.Location = new System.Drawing.Point(107, 48);
            this.txtThreshhold.Name = "txtThreshhold";
            this.txtThreshhold.Size = new System.Drawing.Size(100, 20);
            this.txtThreshhold.TabIndex = 3;
            this.txtThreshhold.TextChanged += new System.EventHandler(this.txtThreshhold_TextChanged);
            this.txtThreshhold.MouseEnter += new System.EventHandler(this.txtThreshhold_MouseEnter);
            this.txtThreshhold.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // cbThreshholdUnits
            // 
            this.cbThreshholdUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThreshholdUnits.FormattingEnabled = true;
            this.cbThreshholdUnits.Items.AddRange(new object[] {
            "GB",
            "%",
            "MB",
            "TB"});
            this.cbThreshholdUnits.Location = new System.Drawing.Point(213, 47);
            this.cbThreshholdUnits.Name = "cbThreshholdUnits";
            this.cbThreshholdUnits.Size = new System.Drawing.Size(60, 21);
            this.cbThreshholdUnits.TabIndex = 4;
            this.cbThreshholdUnits.MouseEnter += new System.EventHandler(this.cbThreshholdUnits_MouseEnter);
            this.cbThreshholdUnits.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(6, 17);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(200, 82);
            this.lbFolders.TabIndex = 1;
            this.lbFolders.MouseEnter += new System.EventHandler(this.lbFolders_MouseEnter);
            this.lbFolders.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(212, 17);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(61, 23);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "&Add";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            this.btnAddFolder.MouseEnter += new System.EventHandler(this.btnAddFolder_MouseEnter);
            this.btnAddFolder.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // btnEditFolder
            // 
            this.btnEditFolder.Enabled = false;
            this.btnEditFolder.Location = new System.Drawing.Point(212, 46);
            this.btnEditFolder.Name = "btnEditFolder";
            this.btnEditFolder.Size = new System.Drawing.Size(61, 23);
            this.btnEditFolder.TabIndex = 2;
            this.btnEditFolder.Text = "&Edit";
            this.btnEditFolder.UseVisualStyleBackColor = true;
            this.btnEditFolder.Click += new System.EventHandler(this.btnEditFolder_Click);
            this.btnEditFolder.MouseEnter += new System.EventHandler(this.btnEditFolder_MouseEnter);
            this.btnEditFolder.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // btnRemFolder
            // 
            this.btnRemFolder.Enabled = false;
            this.btnRemFolder.Location = new System.Drawing.Point(212, 75);
            this.btnRemFolder.Name = "btnRemFolder";
            this.btnRemFolder.Size = new System.Drawing.Size(61, 23);
            this.btnRemFolder.TabIndex = 3;
            this.btnRemFolder.Text = "&Remove";
            this.btnRemFolder.UseVisualStyleBackColor = true;
            this.btnRemFolder.Click += new System.EventHandler(this.btnRemFolder_Click);
            this.btnRemFolder.MouseEnter += new System.EventHandler(this.btnRemFolder_MouseEnter);
            this.btnRemFolder.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // btnSaveServer
            // 
            this.btnSaveServer.Enabled = false;
            this.btnSaveServer.Location = new System.Drawing.Point(119, 214);
            this.btnSaveServer.Name = "btnSaveServer";
            this.btnSaveServer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveServer.TabIndex = 2;
            this.btnSaveServer.Text = "&Save";
            this.btnSaveServer.UseVisualStyleBackColor = true;
            this.btnSaveServer.Click += new System.EventHandler(this.btnSaveServer_Click);
            this.btnSaveServer.MouseEnter += new System.EventHandler(this.btnSaveServer_MouseEnter);
            this.btnSaveServer.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddFolder);
            this.groupBox1.Controls.Add(this.lbFolders);
            this.groupBox1.Controls.Add(this.btnRemFolder);
            this.groupBox1.Controls.Add(this.btnEditFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders to Monitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtServerName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbThreshholdUnits);
            this.groupBox2.Controls.Add(this.txtThreshhold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Information";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(30, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // lblHelpString
            // 
            this.lblHelpString.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblHelpString.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(60, 15);
            this.lblHelpString.Text = "context help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 265);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmServer";
            this.Text = "Add/Edit Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThreshhold;
        private System.Windows.Forms.ComboBox cbThreshholdUnits;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnEditFolder;
        private System.Windows.Forms.Button btnRemFolder;
        private System.Windows.Forms.Button btnSaveServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}