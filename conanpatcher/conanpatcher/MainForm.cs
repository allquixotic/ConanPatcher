using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Ookii.Dialogs;

namespace conanpatcher
{
    public partial class MainForm : Form, ISimpleLogger
    {
        private BindingList<String> logMsgs = new BindingList<string>();
        public const string defConfFileName = "conanpatcher_config.json";

        public MainForm()
        {
            InitializeComponent();

            //Word wrap on debug listbox
            debugLogBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            debugLogBox.MeasureItem += lst_MeasureItem;
            debugLogBox.DrawItem += lst_DrawItem;

            var bs = new BindingSource(logMsgs, null);
            debugLogBox.DataSource = bs;
            logMsgs.Add("Logging initialized!");

            if (File.Exists(defConfFileName))
            {
                try
                {
                    Program.c = JsonConfigLoader.Load(File.ReadAllText(defConfFileName));
                    currConfSrc.Text = "File: " + Path.GetFullPath(@".\" + defConfFileName);
                    loadFromConfigIntoTextboxes();
                }
                catch(Exception q)
                {
                    ((ISimpleLogger)this).Log("Error loading config file from default path " + defConfFileName);
                }
                
            }
        }

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(debugLogBox.Items[e.Index].ToString(), debugLogBox.Font, debugLogBox.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(debugLogBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        public void loadFromConfigIntoTextboxes()
        {
            var c = Program.c;
            if (c != null)
            {
                gameIdTxt.Text = c.GameID;
                gameNameTxt.Text = c.GameName;
                modlistUrlTxt.Text = c.ModlistUrl;
                rsyncArgsTxt.Text = c.RsyncArgs;
                rsyncUrlTxt.Text = c.RsyncUrl;
            }
            gameFldTxt.Text = SharedState.PathInfo.GameFolder;
        }

        public void loadFromTextboxesIntoConfig()
        {
            if (Program.c == null)
            {
                Program.c = new Config();
            }
            var c = Program.c;
            c.GameID = gameIdTxt.Text.Trim();
            c.GameName = gameNameTxt.Text.Trim();
            c.ModlistUrl = modlistUrlTxt.Text.Trim();
            c.RsyncArgs = rsyncArgsTxt.Text.Trim();
            c.RsyncUrl = rsyncUrlTxt.Text.Trim();
            SharedState.PathInfo.SetAllBasedOnGameFolder(gameFldTxt.Text.Trim(), c.GameID);
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            loadFromTextboxesIntoConfig();
            Doer.Do(Program.c);
        }

        private void loadNewConfigButton_Click(object sender, EventArgs e)
        {
            Config c = null;
            try
            {
                if(fileRadio.Checked)
                {
                    var fp = filePathTextBox.Text.Trim();
                    if (String.IsNullOrWhiteSpace(fp))
                    {
                        ((ISimpleLogger)this).Log("Can't load from empty file!");
                        return;
                    }
                    if(!File.Exists(fp))
                    {
                        ((ISimpleLogger)this).Log("File " + fp + " does not exist!");
                        return;
                    }
                    try
                    {
                        c = JsonConfigLoader.Load(File.ReadAllText(fp));
                        this.currConfSrc.Text = "File: " + fp;
                    }
                    catch(Exception errr)
                    {
                        ((ISimpleLogger)this).Log("Failed to get data from file " + fp);
                        ((ISimpleLogger)this).Log(errr.Message + "\r\n" + errr.StackTrace);
                    }
                }
                else
                {
                    var up = urlText.Text.Trim();
                    if(String.IsNullOrWhiteSpace(up))
                    {
                        ((ISimpleLogger)this).Log("Can't load from empty URL!");
                        return;
                    }
                    
                    try
                    {
                        c = WebConfigLoader.Load(up);
                        this.currConfSrc.Text = "URL: " + up;
                    }
                    catch(Exception err)
                    {
                        ((ISimpleLogger)this).Log("Failed to get data from URL " + up);
                    }
                }
                Program.c = c;
                loadFromConfigIntoTextboxes();
                ((ISimpleLogger)this).Log("Successfully loaded new configuration from " + currConfSrc.Text);
            }
            catch(Exception err)
            {
                ((ISimpleLogger)this).Log("Unknown error loading config!");
            }
        }

        private void urlRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fileRadio.Checked) useFile(); else useUrl();
        }

        private void fileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fileRadio.Checked) useFile(); else useUrl();
        }

        private void useFile()
        {
            configFileBrowseButton.Enabled = true;
            urlText.Enabled = false;
            filePathTextBox.Enabled = !urlText.Enabled;
        }

        private void useUrl()
        {
            configFileBrowseButton.Enabled = false;
            urlText.Enabled = true;
            filePathTextBox.Enabled = !urlText.Enabled;
        }

        void ISimpleLogger.Log(string msg)
        {
            logMsgs.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logMsgs.Clear();
        }

        private void copyLogButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join("\r\n", logMsgs));
        }

        private void gameFolderBrowse_Click(object sender, EventArgs e)
        {
            var fd = new VistaFolderBrowserDialog();
            fd.ShowNewFolderButton = false;
            fd.Description = "Select Conan Exiles folder under steamapps\\common";
            var rslt = fd.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                gameFldTxt.Text = fd.SelectedPath;
                if (!Directory.Exists(gameFldTxt.Text))
                {
                    Interaction.MsgBox(@"Error: Can't find Conan Exiles at this path: '" + gameFldTxt.Text + "'. Try again.", MsgBoxStyle.OkOnly | MsgBoxStyle.SystemModal, "Conan Exiles Workshop Patcher");
                }
            }
        }

        private void configFileBrowseButton_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Title = "Select Workshop Patcher config .JSON file";
            fd.Multiselect = false;
            var rslt = fd.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                filePathTextBox.Text = fd.FileName;
                if (!File.Exists(filePathTextBox.Text))
                {
                    Interaction.MsgBox(@"Error: Can't find Workshop Patcher config .JSON file at this path: '" + filePathTextBox.Text + "'. Try again.", MsgBoxStyle.OkOnly | MsgBoxStyle.SystemModal, "Conan Exiles Workshop Patcher");
                }
            }
        }

        private void currConfSrc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
