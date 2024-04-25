using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.Logic
{
    public static class LogFileManager
    {        
        public static string currentDirectory = Environment.CurrentDirectory;
        public static void addNewLog(string _log)
        {
            string fileName = currentDirectory + "\\log.txt";
            if (!File.Exists(fileName))
            {
                FileStream fileStreamOfNewFile = File.Create(fileName);
                fileStreamOfNewFile.Close();
            }

            File.AppendAllText(fileName, "\n\n\n");
            AddLog(_log);

        }

        public static void AddLog(string _log)
        {
            string fileName = currentDirectory + "\\log.txt";
            File.AppendAllText(fileName, "\n\t" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + _log);
        }
    }
}
