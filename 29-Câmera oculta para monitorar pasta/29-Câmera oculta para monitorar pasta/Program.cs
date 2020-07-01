using System;
using System.IO;

// Monitora a pasta C:\Temp e notifica a criação de novos arquivos texto
namespace _29_Câmera_oculta_para_monitorar_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            WatchTempFolder();
        }

        public static void WatchTempFolder()
        {
            // Criar o object FileSystemoFileSystemWatcher e configurar suas propriedades
            FileSystemWatcher oFileSystemWatcher = new FileSystemWatcher();
            oFileSystemWatcher.Path = "C:\\temp";
            oFileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            oFileSystemWatcher.Filter = "*.*";

            // Adicionar os manipuladores de evento.
            oFileSystemWatcher.Created += new FileSystemEventHandler(OnCreated);

            // Iniciar a monitoracao.
            oFileSystemWatcher.EnableRaisingEvents = true;

            // Aguardar que o usuario finalize o programa.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q');
        }

        // O manipulador de eventos
        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}
