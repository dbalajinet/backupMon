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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHelpItemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHelpString = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(33, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // lblHelpString
            // 
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(72, 17);
            this.lblHelpString.Text = "context help";
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
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(6, 17);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(200, 82);
            this.lbFolders.TabIndex = 1;
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
            // 
            // btnEditFolder
            // 
            this.btnEditFolder.Location = new System.Drawing.Point(212, 46);
            this.btnEditFolder.Name = "btnEditFolder";
            this.btnEditFolder.Size = new System.Drawing.Size(61, 23);
            this.btnEditFolder.TabIndex = 2;
            this.btnEditFolder.Text = "&Edit";
            this.btnEditFolder.UseVisualStyleBackColor = true;
            // 
            // btnRemFolder
            // 
            this.btnRemFolder.Location = new System.Drawing.Point(212, 75);
            this.btnRemFolder.Name = "btnRemFolder";
            this.btnRemFolder.Size = new System.Drawing.Size(61, 23);
            this.btnRemFolder.TabIndex = 3;
            this.btnRemFolder.Text = "&Remove";
            this.btnRemFolder.UseVisualStyleBackColor = true;
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
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveServer);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmServer";
            this.Text = "Add/Edit Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
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
    }
}