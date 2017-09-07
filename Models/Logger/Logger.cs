using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AureliaProjects.Models.Logger
{
    public class Logger
    {
        public static void CreateLogFile(string data)
        {
            CheckDirectory();
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\AureliaApps\CreateIISWeb\AureliaProjects\Log\LogFile.txt", true);
            file.WriteLine(data);
            file.Dispose();
            file.Close();
        }

        private static void CheckDirectory()
        {
            if (!System.IO.Directory.Exists(@"C:\AureliaApps\CreateIISWeb\AureliaProjects\Log\"))
            {
                System.IO.Directory.CreateDirectory(@"C:\AureliaApps\CreateIISWeb\AureliaProjects\Log\");
            }
        }

    }
}
