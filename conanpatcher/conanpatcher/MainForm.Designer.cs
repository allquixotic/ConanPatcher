namespace conanpatcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.patchButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadNewConfigButton = new System.Windows.Forms.Button();
            this.configFileBrowseButton = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlRadio = new System.Windows.Forms.RadioButton();
            this.fileRadio = new System.Windows.Forms.RadioButton();
            this.currConfSrc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debugLogBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyLogButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rsyncArgsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rsyncUrlTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modlistUrlTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gameNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gameIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gameFolderBrowse = new System.Windows.Forms.Button();
            this.gameFldTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modDirTxt = new System.Windows.Forms.TextBox();
            this.modDirBrowse = new System.Windows.Forms.Button();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveJsonBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.FlatAppearance.BorderSize = 3;
            this.patchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.Location = new System.Drawing.Point(216, 269);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 37);
            this.patchButton.TabIndex = 0;
            this.patchButton.Text = "Patch!";
            this.toolTip1.SetToolTip(this.patchButton, "If you\'re just a player and not sure what to do, click here!\r\nPlease be patient a" +
        "nd don\'t close the pop-up console window. \r\nThis could take some time. ");
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(102, 49);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(189, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadNewConfigButton);
            this.groupBox1.Controls.Add(this.configFileBrowseButton);
            this.groupBox1.Controls.Add(this.urlText);
            this.groupBox1.Controls.Add(this.urlRadio);
            this.groupBox1.Controls.Add(this.fileRadio);
            this.groupBox1.Controls.Add(this.currConfSrc);
            this.groupBox1.Controls.Add(this.filePathTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config File Source";
            // 
            // loadNewConfigButton
            // 
            this.loadNewConfigButton.Location = new System.Drawing.Point(10, 108);
            this.loadNewConfigButton.Name = "loadNewConfigButton";
            this.loadNewConfigButton.Size = new System.Drawing.Size(116, 23);
            this.loadNewConfigButton.TabIndex = 6;
            this.loadNewConfigButton.Text = "Load New Config";
            this.loadNewConfigButton.UseVisualStyleBackColor = true;
            this.loadNewConfigButton.Click += new System.EventHandler(this.loadNewConfigButton_Click);
            // 
            // configFileBrowseButton
            // 
            this.configFileBrowseButton.Location = new System.Drawing.Point(297, 47);
            this.configFileBrowseButton.Name = "configFileBrowseButton";
            this.configFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.configFileBrowseButton.TabIndex = 5;
            this.configFileBrowseButton.Text = "Browse...";
            this.configFileBrowseButton.UseVisualStyleBackColor = true;
            this.configFileBrowseButton.Click += new System.EventHandler(this.configFileBrowseButton_Click);
            // 
            // urlText
            // 
            this.urlText.Enabled = false;
            this.urlText.Location = new System.Drawing.Point(102, 82);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(189, 20);
            this.urlText.TabIndex = 4;
            // 
            // urlRadio
            // 
            this.urlRadio.AutoSize = true;
            this.urlRadio.Location = new System.Drawing.Point(10, 82);
            this.urlRadio.Name = "urlRadio";
            this.urlRadio.Size = new System.Drawing.Size(82, 17);
            this.urlRadio.TabIndex = 3;
            this.urlRadio.Text = "From a URL";
            this.urlRadio.UseVisualStyleBackColor = true;
            this.urlRadio.CheckedChanged += new System.EventHandler(this.urlRadio_CheckedChanged);
            // 
            // fileRadio
            // 
            this.fileRadio.AutoSize = true;
            this.fileRadio.Checked = true;
            this.fileRadio.Location = new System.Drawing.Point(10, 49);
            this.fileRadio.Name = "fileRadio";
            this.fileRadio.Size = new System.Drawing.Size(76, 17);
            this.fileRadio.TabIndex = 2;
            this.fileRadio.TabStop = true;
            this.fileRadio.Text = "From a File";
            this.fileRadio.UseVisualStyleBackColor = true;
            this.fileRadio.CheckedChanged += new System.EventHandler(this.fileRadio_CheckedChanged);
            // 
            // currConfSrc
            // 
            this.currConfSrc.Location = new System.Drawing.Point(146, 17);
            this.currConfSrc.Name = "currConfSrc";
            this.currConfSrc.ReadOnly = true;
            this.currConfSrc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.currConfSrc.Size = new System.Drawing.Size(408, 20);
            this.currConfSrc.TabIndex = 1;
            this.currConfSrc.Text = "(none)";
            this.currConfSrc.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Config File Source:";
            // 
            // debugLogBox
            // 
            this.debugLogBox.FormattingEnabled = true;
            this.debugLogBox.Items.AddRange(new object[] {
            "Debug log goes here"});
            this.debugLogBox.Location = new System.Drawing.Point(8, 19);
            this.debugLogBox.Name = "debugLogBox";
            this.debugLogBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.debugLogBox.Size = new System.Drawing.Size(547, 277);
            this.debugLogBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyLogButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.debugLogBox);
            this.groupBox2.Location = new System.Drawing.Point(11, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 334);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Log";
            // 
            // copyLogButton
            // 
            this.copyLogButton.Location = new System.Drawing.Point(87, 305);
            this.copyLogButton.Name = "copyLogButton";
            this.copyLogButton.Size = new System.Drawing.Size(121, 23);
            this.copyLogButton.TabIndex = 5;
            this.copyLogButton.Text = "Copy Log to Clipboard";
            this.copyLogButton.UseVisualStyleBackColor = true;
            this.copyLogButton.Click += new System.EventHandler(this.copyLogButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.serverNameTxt);
            this.groupBox3.Controls.Add(this.modDirBrowse);
            this.groupBox3.Controls.Add(this.modDirTxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rsyncArgsTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rsyncUrlTxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.modlistUrlTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.gameNameTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.gameIdTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.gameFolderBrowse);
            this.groupBox3.Controls.Add(this.gameFldTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.patchButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 312);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mod Dir";
            this.toolTip1.SetToolTip(this.label9, "The folder where the mods are to be installed.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Server Name";
            this.toolTip1.SetToolTip(this.label8, "The user-friendly string describing the server this mod set is intended for.");
            // 
            // rsyncArgsTxt
            // 
            this.rsyncArgsTxt.Location = new System.Drawing.Point(102, 243);
            this.rsyncArgsTxt.Name = "rsyncArgsTxt";
            this.rsyncArgsTxt.Size = new System.Drawing.Size(189, 20);
            this.rsyncArgsTxt.TabIndex = 13;
            this.toolTip1.SetToolTip(this.rsyncArgsTxt, "Arguments to supply to the rsync client.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rsync Args";
            this.toolTip1.SetToolTip(this.label7, "Arguments to supply to the rsync client.");
            // 
            // rsyncUrlTxt
            // 
            this.rsyncUrlTxt.Location = new System.Drawing.Point(102, 210);
            this.rsyncUrlTxt.Name = "rsyncUrlTxt";
            this.rsyncUrlTxt.Size = new System.Drawing.Size(189, 20);
            this.rsyncUrlTxt.TabIndex = 11;
            this.toolTip1.SetToolTip(this.rsyncUrlTxt, "The rsync:// URL for downloading the mod .pak files.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rsync URL";
            this.toolTip1.SetToolTip(this.label6, "The rsync:// URL for downloading the mod .pak files.");
            // 
            // modlistUrlTxt
            // 
            this.modlistUrlTxt.Location = new System.Drawing.Point(102, 175);
            this.modlistUrlTxt.Name = "modlistUrlTxt";
            this.modlistUrlTxt.Size = new System.Drawing.Size(189, 20);
            this.modlistUrlTxt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.modlistUrlTxt, "The URL of the modlist.txt to download and install.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modlist URL";
            this.toolTip1.SetToolTip(this.label5, "The URL of the modlist.txt to download and install.");
            // 
            // gameNameTxt
            // 
            this.gameNameTxt.Location = new System.Drawing.Point(102, 142);
            this.gameNameTxt.Name = "gameNameTxt";
            this.gameNameTxt.Size = new System.Drawing.Size(189, 20);
            this.gameNameTxt.TabIndex = 7;
            this.toolTip1.SetToolTip(this.gameNameTxt, "The directory name for where Conan is installed.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Game Name";
            this.toolTip1.SetToolTip(this.label4, "The directory name for where Conan is installed.");
            // 
            // gameIdTxt
            // 
            this.gameIdTxt.Location = new System.Drawing.Point(102, 109);
            this.gameIdTxt.Name = "gameIdTxt";
            this.gameIdTxt.Size = new System.Drawing.Size(189, 20);
            this.gameIdTxt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.gameIdTxt, "The Steam game ID (number) for Conan Exiles.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game ID";
            this.toolTip1.SetToolTip(this.label3, "The Steam game ID (number) for Conan Exiles.");
            // 
            // gameFolderBrowse
            // 
            this.gameFolderBrowse.Location = new System.Drawing.Point(297, 77);
            this.gameFolderBrowse.Name = "gameFolderBrowse";
            this.gameFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.gameFolderBrowse.TabIndex = 3;
            this.gameFolderBrowse.Text = "Browse...";
            this.gameFolderBrowse.UseVisualStyleBackColor = true;
            this.gameFolderBrowse.Click += new System.EventHandler(this.gameFolderBrowse_Click);
            // 
            // gameFldTxt
            // 
            this.gameFldTxt.Location = new System.Drawing.Point(102, 79);
            this.gameFldTxt.Name = "gameFldTxt";
            this.gameFldTxt.Size = new System.Drawing.Size(189, 20);
            this.gameFldTxt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.gameFldTxt, "The folder where Conan Exiles is installed on this computer.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Folder";
            this.toolTip1.SetToolTip(this.label2, "The folder where Conan Exiles is installed on this computer.");
            // 
            // modDirTxt
            // 
            this.modDirTxt.Location = new System.Drawing.Point(102, 48);
            this.modDirTxt.Name = "modDirTxt";
            this.modDirTxt.Size = new System.Drawing.Size(189, 20);
            this.modDirTxt.TabIndex = 16;
            this.toolTip1.SetToolTip(this.modDirTxt, "The folder where the mods are to be installed.");
            // 
            // modDirBrowse
            // 
            this.modDirBrowse.Location = new System.Drawing.Point(297, 46);
            this.modDirBrowse.Name = "modDirBrowse";
            this.modDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.modDirBrowse.TabIndex = 17;
            this.modDirBrowse.Text = "Browse...";
            this.modDirBrowse.UseVisualStyleBackColor = true;
            this.modDirBrowse.Click += new System.EventHandler(this.modDirBrowse_Click);
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(102, 19);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(189, 20);
            this.serverNameTxt.TabIndex = 18;
            this.toolTip1.SetToolTip(this.serverNameTxt, "The user-friendly string describing the server this mod set is intended for.");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveJsonBrowse);
            this.groupBox4.Location = new System.Drawing.Point(331, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 54);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced";
            // 
            // saveJsonBrowse
            // 
            this.saveJsonBrowse.Location = new System.Drawing.Point(6, 19);
            this.saveJsonBrowse.Name = "saveJsonBrowse";
            this.saveJsonBrowse.Size = new System.Drawing.Size(108, 23);
            this.saveJsonBrowse.TabIndex = 0;
            this.saveJsonBrowse.Text = "Save JSON to file";
            this.saveJsonBrowse.UseVisualStyleBackColor = true;
            this.saveJsonBrowse.Click += new System.EventHandler(this.saveJsonBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 811);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Conan Exiles Workshop Mod Patcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox currConfSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton urlRadio;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.Button configFileBrowseButton;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button loadNewConfigButton;
        private System.Windows.Forms.ListBox debugLogBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyLogButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button gameFolderBrowse;
        private System.Windows.Forms.TextBox gameFldTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gameIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rsyncArgsTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rsyncUrlTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modlistUrlTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gameNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button modDirBrowse;
        private System.Windows.Forms.TextBox modDirTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveJsonBrowse;
    }
}