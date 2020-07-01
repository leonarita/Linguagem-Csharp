using System;

namespace _30_Ambiente_Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fully qualified path of the current directory
            Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

            // Gets the NetBIOS name of this local computer
            Console.WriteLine("MachineName: {0}", Environment.MachineName);

            // Version number of the OS
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

            // Fully qualified path of the system directory
            Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);

            // Network domain name associated with the current user
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);

            // Whether the current process is running in user interactive mode
            Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);

            // User name of the person who started the current thread
            Console.WriteLine("UserName: {0}", Environment.UserName);

            // Major, minor, build, and revision numbers of the CLR
            Console.WriteLine("CLRVersion: {0}", Environment.Version.ToString());

            // Amount of physical memory mapped to the process context
            Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);

            // Returns values of Environment variables enclosed in %%
            Console.WriteLine("ExpandEnvironmentVariables: {0}",
                Environment.ExpandEnvironmentVariables("System drive: " + "%SystemDrive% System root: %SystemRoot%"));

            // Array of string containing the names of the logical drives
            Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", Environment.GetLogicalDrives()));
        }
    }
}
