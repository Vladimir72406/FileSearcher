using FileSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.SettingsFolder.Logic
{
    public class SettingsINI : ISettings
    {        
        public void Save(StartingSettings _startingSettings)
        {
            throw new NotImplementedException();
        }

        StartingSettings ISettings.Get()
        {
            throw new NotImplementedException();
        }
    }
}
