using FileSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.SettingsFolder.Logic
{
    public interface ISettings
    {
        void Save(StartingSettings _startingSettings);
        StartingSettings Get();
    }
    
}
