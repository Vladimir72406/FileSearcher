using FileSearcher.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher.Logic
{
    public class TreeManager
    {
        private string templateFileName = "";
        private long fileCount = 0;
        private MainForm mainForm;
        private Label lblCurrentDir;
        private Label lblFileCount;

        public TreeManager(string _templateFileName, MainForm _mainForm, Label _lblCurrentDir, Label _lblFileCount)
        {
            this.templateFileName = _templateFileName;
            this.mainForm = _mainForm;
            this.lblCurrentDir = _lblCurrentDir;
            this.lblFileCount = _lblFileCount;
            fileCount = 0;
        }

        public void Start(string _folder, TreeNode tn, string _patternOfFileNmae)
        {
            executeAction(() => lblCurrentDir.Text = _folder);
            checkEveryFolder(_folder, tn, _patternOfFileNmae);
            searchFilesAndAddToNode(_folder, tn, _patternOfFileNmae);
        }
        private void executeAction(Action _action)
        {
            if (mainForm.InvokeRequired)
                mainForm.Invoke(_action);
            else
                _action();
        }
        private void checkEveryFolder(string _folder, TreeNode tn, string _patternOfFileNmae)
        {
            try
            {
                string[] allfolders = Directory.GetDirectories(_folder, "*", SearchOption.TopDirectoryOnly);

                foreach (string folder in allfolders)
                {
                    TreeNode newTreeNode = new TreeNode(new DirectoryInfo(folder).Name);
                    Start(folder, newTreeNode, _patternOfFileNmae);

                    if (newTreeNode.Nodes.Count > 0)
                    {
                        executeAction(() => tn.Nodes.Add(newTreeNode));
                    }
                }
            }
            catch (Exception e)
            {
                LogFileManager.AddLog("Ошибка GetDirectories; " + e.Message.ToString());
            }
        }
        private void searchFilesAndAddToNode(string _folder, TreeNode tn, string _patternOfFileNmae)
        {
            try
            {
                string[] allfiles = Directory.GetFiles(_folder, _patternOfFileNmae);
                foreach (string filename in allfiles)
                {
                    executeAction
                    (() =>
                    { 
                        tn.Nodes.Add(Path.GetFileName(filename));                        
                        lblFileCount.Text = fileCount++.ToString();
                    });
                }
            }
            catch (Exception e)
            {
                LogFileManager.AddLog("Ошибка GetFiles; " + e.Message.ToString());
            }
        }

    }
}
