using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace ServiceAssignment
{
    public partial class Service1 : ServiceBase
    {
        private string folder_path = @"D:\Main\";
        private string backup_path = @"D:\Buffer\Backup\";


        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("AssignServiceSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("AssignServiceSource", "AssignServiceLog");
            }

            DirectoryLog1.Source = "AssignServiceSource";
            DirectoryLog1.Log = "AssignServiceLog";

        }

        protected override void OnStart(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            
            watcher.Path = folder_path;
            watcher.IncludeSubdirectories = true;


            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            if (System.IO.Directory.Exists(folder_path))
            {
                File.Move(folder_path, backup_path);

            }
            watcher.Changed += new FileSystemEventHandler(onChanged);
            watcher.Deleted += new FileSystemEventHandler(onDelete);
            watcher.Created += new FileSystemEventHandler(onCreate);
            watcher.Renamed += new RenamedEventHandler(onRenamed);

            watcher.EnableRaisingEvents = true;


            DirectoryInfo d1 = new DirectoryInfo(@"D:\Main");
            d1.CreateSubdirectory("Mydir");
        }

        private void onChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            File.Copy(folder_path + e.Name, backup_path + e.Name, true);   
        }


        private void onDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            
        }


        private void onCreate(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            File.Copy(folder_path+ e.Name, backup_path + e.Name, true);
        }

        private void onRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            File.Copy(folder_path + e.Name, backup_path + e.Name, true);
        }

        protected override void OnStop()
        {
            DirectoryLog1.WriteEntry("Service has stopped");
        }


    }
}
