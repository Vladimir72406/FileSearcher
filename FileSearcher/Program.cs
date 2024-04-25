using FileSearcher.Logic;
using FileSearcher.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime startDateTime = DateTime.Now;
            try
            {                
                LogFileManager.addNewLog("Старт работы приложения");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                LogFileManager.AddLog("Ошибка. " + e.Message.ToString());
            }
            finally
            {
                LogFileManager.AddLog("Завершение работы приложения; Время работы с " 
                    + startDateTime.ToString("dd-MM-yyyy HH:mm:ss") 
                    + " по " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));                
            }
        }
    }
}
