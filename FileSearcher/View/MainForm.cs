using FileSearcher.Logic;
using FileSearcher.Models;
using FileSearcher.SettingsFolder.Logic;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FileSearcher.View
{
    public partial class MainForm : Form
    {
        Thread threadSearchFile;
        ManualResetEvent _event = new ManualResetEvent(true);
        public MainForm()
        {
            InitializeComponent();
            loadSettings();            
        }

        private void loadSettings()
        {
            ISettings settings = new SettingsResourseApp();
            var startingSettings = settings.Get();

            txtStartDir.Text = startingSettings.startDirectory;
            txtTemplateFileName.Text = startingSettings.templateFileName;
        }

        private void btnSelectStartDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string selectedDir = folderBrowserDialog.SelectedPath;
                txtStartDir.Text = selectedDir;
            }
        }

        
        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            if (threadSearchFile != null) threadSearchFile.Abort();
            _event.Set();

            btnPauseSearch.Enabled = true;
            btnContinueSearch.Enabled = false;

            timerSerchFile.Enabled = true;
            timerSerchFile.Start();

            threadSearchFile = new Thread(new ThreadStart(() => prepareForTheSearch(this, this.lblCurrentDir)));
            threadSearchFile.IsBackground = false;
            threadSearchFile.Start();

            dateTimeStartSearch = DateTime.Now;            
        }

        public void prepareForTheSearch(MainForm _mainForm, Label _lblCurrentDir)
        {
            Action actionClearOldNodes = (() => tvMain.Nodes.Clear());
            if (_mainForm.InvokeRequired)
                _mainForm.Invoke(actionClearOldNodes);
            else
                actionClearOldNodes();

            StartingSettings startingSettings = new StartingSettings();
            startingSettings.startDirectory = txtStartDir.Text;
            startingSettings.templateFileName = txtTemplateFileName.Text;

            ISettings settings = new SettingsResourseApp();
            settings.Save(startingSettings);

            TreeManager treeManager = new TreeManager(startingSettings.templateFileName, 
                                                        _mainForm, _lblCurrentDir, 
                                                        this.lblFileCount, this._event);

            TreeNode tn = new TreeNode(startingSettings.startDirectory);

            Action actionAddFirstNode = () => tvMain.Nodes.Add(tn);
            if (_mainForm.InvokeRequired)
                _mainForm.Invoke(actionAddFirstNode);
            else
                actionAddFirstNode();


            treeManager.Start(startingSettings.startDirectory, tn, startingSettings.templateFileName);

            Action actionStopTimer = () =>
            {
                timerSerchFile.Stop();
                btnContinueSearch.Enabled = false;
                btnPauseSearch.Enabled = false;
            };
            if (_mainForm.InvokeRequired)
                _mainForm.Invoke(actionStopTimer);
            else
                actionStopTimer();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadSearchFile != null) threadSearchFile.Abort();
        }

        DateTime dateTimeStartSearch;
        private void timerSerchFile_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeCurent = DateTime.Now;
            DateTime dateTimeResult = new System.DateTime(1970, 1, 1, 0, 0, 0, 0).Add(dateTimeCurent - dateTimeStartSearch);
            lblTimeOfSearch.Text = dateTimeResult.ToString("HH:mm:ss");
        }

        private void btnPauseSearch_Click(object sender, EventArgs e)
        {
            if (threadSearchFile != null)
            {
                _event.Reset();
                btnContinueSearch.Enabled = true;
                timerSerchFile.Stop();

            }
        }

        private void btnContinueSearch_Click(object sender, EventArgs e)
        {
            _event.Set();
            timerSerchFile.Start();
            btnContinueSearch.Enabled = false;
        }
    }
}
