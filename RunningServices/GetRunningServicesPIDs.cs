using System;
using System.Diagnostics;

namespace RunningServices
{
    class GetRunningServicesPIDs
    {
        public void GetAllBackgroundServices() 
        {
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        Console.WriteLine(p.Id.ToString());
                    }
                }
                catch { }
            }
        }
    }
}
