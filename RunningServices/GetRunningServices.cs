using System;
using System.Diagnostics;

namespace RunningServices
{
    class GetRunningServices
    {
        public void GetAllServices() 
        {
            Process[] processes = Process.GetProcesses();
            foreach(Process p in processes) 
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    Console.WriteLine(p.MainWindowTitle);
                }
            }
        }
    }
}
