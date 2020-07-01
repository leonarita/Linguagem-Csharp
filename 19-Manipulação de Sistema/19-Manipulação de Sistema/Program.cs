using System;
using System.IO;

namespace _19_Manipulação_de_Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Considere as opções abaixo \n\t1-Drive Info \n\t2-Search Option \n\t3-File \n\t4-File Info \n\t5-Directory Info \n\t6-Copy directory");
            Console.WriteLine("\nInforme a opção desejada: ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            if (op == 1)
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    Console.WriteLine("Drive {0}", d.Name);
                    Console.WriteLine("  Drive type: {0}", d.DriveType);

                    if (d.IsReady == true)
                    {
                        Console.WriteLine("\tVolume label: {0}", d.VolumeLabel);
                        Console.WriteLine("\tFile system: {0}", d.DriveFormat);
                        Console.WriteLine("\tAvailable space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                        Console.WriteLine("\tTotal available space:          {0, 15} bytes", d.TotalFreeSpace);
                        Console.WriteLine("\tTotal size of drive:            {0, 15} bytes ",d.TotalSize);
                    }

                    Console.WriteLine("\n\n");
                }
            }

            else if (op == 2)
            {
                // Specify the directory you want to manipulate.
                string path = @"C:\";
                string searchPattern = "c*";

                DirectoryInfo di = new DirectoryInfo(path);
                DirectoryInfo[] directories = di.GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);

                FileInfo[] files = di.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);

                Console.WriteLine("Directories that begin with the letter \"c\" in {0}", path);

                foreach (DirectoryInfo dir in directories)
                     Console.WriteLine("{0,-25} {1,25}", dir.FullName, dir.LastWriteTime);

                Console.WriteLine();
                Console.WriteLine("Files that begin with the letter \"c\" in {0}", path);

                foreach (FileInfo file in files)
                    Console.WriteLine("{0,-25} {1,25}", file.Name, file.LastWriteTime);
            }

            else if (op == 3)
            {
                Console.WriteLine("\n\nInforme o path do arquivo: ");
                string path = Console.ReadLine();           //@"c:\temp\MyTest.txt"

                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("And");
                        sw.WriteLine("Welcome");
                    }
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            else if (op == 4)
            {
                string path = Path.GetTempFileName();
                var fi1 = new FileInfo(path);

                // Create a file to write to.
                using (StreamWriter sw = fi1.CreateText())
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }

                // Open the file to read from.
                using (StreamReader sr = fi1.OpenText())
                {
                    var s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                try
                {
                    string path2 = Path.GetTempFileName();
                    var fi2 = new FileInfo(path2);

                    // Ensure that the target does not exist.
                    fi2.Delete();

                    // Copy the file.
                    fi1.CopyTo(path2);
                    Console.WriteLine($"{path} was copied to {path2}.");

                    // Delete the newly created file.
                    fi2.Delete();
                    Console.WriteLine($"{path2} was successfully deleted.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The process failed: {e.ToString()}");
                }
            }

            else if (op == 5)
            {
                // Specify the directories you want to manipulate.
                Console.WriteLine("\n\nInforme o path do diretório: ");
                string dir = Console.ReadLine();

                DirectoryInfo di = new DirectoryInfo(dir);              //@"c:\MyDir"
                try
                {
                    // Determine whether the directory exists.
                    if (di.Exists)
                    {
                        // Indicate that the directory already exists.
                        Console.WriteLine("That path exists already.");
                        return;
                    }

                    // Try to create the directory.
                    di.Create();
                    Console.WriteLine("The directory was created successfully.");

                    // Delete the directory.
                    di.Delete();
                    Console.WriteLine("The directory was deleted successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
                finally { }
            }

            else if (op == 6)
            {
                Console.WriteLine("\n\nInforme o path do diretório a ser copiado: ");
                string sourceDirectory = Console.ReadLine();  //@"c:\sourceDirectory"

                Console.WriteLine("\n\nInforme o path do diretório a ser criado: ");
                string targetDirectory = Console.ReadLine();  //@"c:\targetDirectory"

                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                CopyAll(diSource, diTarget);
            }
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

    }
}
