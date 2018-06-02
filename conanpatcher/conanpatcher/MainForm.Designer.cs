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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.Location = new System.Drawing.Point(216, 235);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 23);
            this.patchButton.TabIndex = 0;
            this.patchButton.Text = "Patch!";
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
            this.currConfSrc.TextChanged += new System.EventHandler(this.currConfSrc_TextChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(11, 434);
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
            this.groupBox3.Size = new System.Drawing.Size(560, 267);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config Settings";
            // 
            // rsyncArgsTxt
            // 
            this.rsyncArgsTxt.Location = new System.Drawing.Point(102, 192);
            this.rsyncArgsTxt.Name = "rsyncArgsTxt";
            this.rsyncArgsTxt.Size = new System.Drawing.Size(189, 20);
            this.rsyncArgsTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rsync Args";
            // 
            // rsyncUrlTxt
            // 
            this.rsyncUrlTxt.Location = new System.Drawing.Point(102, 155);
            this.rsyncUrlTxt.Name = "rsyncUrlTxt";
            this.rsyncUrlTxt.Size = new System.Drawing.Size(189, 20);
            this.rsyncUrlTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rsync URL";
            // 
            // modlistUrlTxt
            // 
            this.modlistUrlTxt.Location = new System.Drawing.Point(102, 121);
            this.modlistUrlTxt.Name = "modlistUrlTxt";
            this.modlistUrlTxt.Size = new System.Drawing.Size(189, 20);
            this.modlistUrlTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modlist URL";
            // 
            // gameNameTxt
            // 
            this.gameNameTxt.Location = new System.Drawing.Point(102, 88);
            this.gameNameTxt.Name = "gameNameTxt";
            this.gameNameTxt.Size = new System.Drawing.Size(189, 20);
            this.gameNameTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Game Name";
            // 
            // gameIdTxt
            // 
            this.gameIdTxt.Location = new System.Drawing.Point(102, 51);
            this.gameIdTxt.Name = "gameIdTxt";
            this.gameIdTxt.Size = new System.Drawing.Size(189, 20);
            this.gameIdTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game ID";
            // 
            // gameFolderBrowse
            // 
            this.gameFolderBrowse.Location = new System.Drawing.Point(297, 15);
            this.gameFolderBrowse.Name = "gameFolderBrowse";
            this.gameFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.gameFolderBrowse.TabIndex = 3;
            this.gameFolderBrowse.Text = "Browse...";
            this.gameFolderBrowse.UseVisualStyleBackColor = true;
            this.gameFolderBrowse.Click += new System.EventHandler(this.gameFolderBrowse_Click);
            // 
            // gameFldTxt
            // 
            this.gameFldTxt.Location = new System.Drawing.Point(102, 17);
            this.gameFldTxt.Name = "gameFldTxt";
            this.gameFldTxt.Size = new System.Drawing.Size(189, 20);
            this.gameFldTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 780);
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
    }
}