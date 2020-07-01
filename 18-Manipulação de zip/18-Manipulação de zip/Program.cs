using System;
using System.IO;
using System.IO.Compression;

namespace _18_Manipulação_de_zip
{
    class Program
    {
        private static string directoryPath = @".\temp";

        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("\nConsidere as seguintes opções: \n\t1-Compactar \n\t2-Descompactar" +
                    "\n\t3-Extrair extensões de arquivo específicas \n\t4-Adicionar um arquivo a um zip existente" +
                    "\n\t5-Compactar e descompactar arquivos. gz \n\t0-Sair \n\n\t\tInforme a opção desejada: ");

                op = int.Parse(Console.ReadLine());

                if (op == 0)
                    continue;

                Console.WriteLine("\n\n\tInforme o path do arquivo zip (compactar/descompactar): ");
                string zipPath = Console.ReadLine();

                Console.WriteLine("\n\tInforme o path do arquivo não zip (compactar/descompactar): ");
                string startPath = Console.ReadLine();

                //Compactar
                if (op == 1)
                {
                    ZipFile.CreateFromDirectory(startPath, zipPath);
                }

                //Descompactar
                else if (op == 2)
                {
                    ZipFile.ExtractToDirectory(zipPath, startPath);
                }

                //Extrair extensões de arquivo específicas
                else if (op == 3)
                {

                    Console.WriteLine("Provide path where to extract the zip file: ");
                    string extractPath2 = Console.ReadLine();

                    // Normalizes the path.
                    extractPath2 = Path.GetFullPath(extractPath2);

                    // Ensures that the last character on the extraction path is the directory separator char. 
                    // Without this, a malicious zip file could try to traverse outside of the expected extraction path.
                    if (!extractPath2.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                        extractPath2 += Path.DirectorySeparatorChar;

                    using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                            {    // Gets the full path to ensure that relative segments are removed.
                                string destinationPath = Path.GetFullPath(Path.Combine(startPath, entry.FullName));
                                // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                                // are case-insensitive.
                                if (destinationPath.StartsWith(startPath, StringComparison.Ordinal))
                                    entry.ExtractToFile(destinationPath);
                            }
                        }
                    }
                }

                //Adicionar um arquivo a um zip existente
                else if (op == 4)
                {
                    using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.CreateEntry("startPath");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                writer.WriteLine("Information about this package.");
                                writer.WriteLine("========================");
                            }
                        }
                    }
                }

                //Compactar e descompactar arquivos. gz
                else if (op == 5)
                {
                    DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
                    Compress(directorySelected);
                    foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.gz"))
                        Decompress(fileToDecompress);
                }

                else if (op == 0)
                    Console.WriteLine("\n\nAté mais!!!");

                else
                {
                    Console.WriteLine("\n\n\n\t\t\tCOMANDO INVÁLIDO!");
                }
            }
            while (op != 0);
        }

        public static void Compress(DirectoryInfo directorySelected)
        {
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) &
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                               CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);
                            }
                        }
                        FileInfo info = new FileInfo(directoryPath + Path.DirectorySeparatorChar + fileToCompress.Name + ".gz");
                        Console.WriteLine($"Compressed {fileToCompress.Name} from {fileToCompress.Length.ToString()} to {info.Length.ToString()} bytes.");
                    }
                }
            }
        }

        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine($"Decompressed: {fileToDecompress.Name}");
                    }
                }
            }
        }
    }
}
