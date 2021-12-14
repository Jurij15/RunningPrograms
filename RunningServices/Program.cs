using System;

namespace RunningServices
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor foreground = Console.ForegroundColor;
            ConsoleColor background = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List of running applications, made by Jurij15, Version 0.2");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Running Programs");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            GetRunningServices services = new GetRunningServices();
            services.GetAllServices();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Running Services PIDs");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            GetRunningServicesPIDs backgroundServicesPIDs = new GetRunningServicesPIDs();
            backgroundServicesPIDs.GetAllBackgroundServices();
            Console.ReadLine();
        }
    }
}
