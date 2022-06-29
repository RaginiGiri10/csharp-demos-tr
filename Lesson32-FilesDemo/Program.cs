using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32_FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            Console.WriteLine("Disk Partitions");
            Console.WriteLine("************************");
            foreach(DriveInfo info in driveInfos)
            {
                if (info.IsReady)
                {
                    Console.WriteLine(info.Name);
                    Console.WriteLine($"Total size = {info.TotalSize} ");
                    Console.WriteLine($"Available  space = {info.AvailableFreeSpace} ");
                }
                
            }

            Console.WriteLine("***************************************************************");
            Console.WriteLine("DirectoryInfo class Demo");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\");
            directoryInfo.CreateSubdirectory("Zensar-Training");
            directoryInfo.CreateSubdirectory(@"Zensar-Training\Training");

            Directory.Delete(@"C:\Zensar-Training\Training");
            Directory.Delete(@"C:\Zensar-Training");

            Console.WriteLine("Deleted successfully");

            Console.ReadLine();
        }
    }
}
