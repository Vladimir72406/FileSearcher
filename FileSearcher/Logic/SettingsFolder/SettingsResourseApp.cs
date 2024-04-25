using FileSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.SettingsFolder.Logic
{
    public class SettingsResourseApp : ISettings
    {
        public StartingSettings Get()
        {
            StartingSettings startingSettings = new StartingSettings();
            startingSettings.startDirectory = Properties.Settings.Default.StartDirectory;
            startingSettings.templateFileName = Properties.Settings.Default.Template;
            return startingSettings;
        }

        public void Save(StartingSettings _startingSettings)
        {
            Properties.Settings.Default.StartDirectory = _startingSettings.startDirectory;
            Properties.Settings.Default.Template = _startingSettings.templateFileName;
            Properties.Settings.Default.Save();
        }
    }
}
