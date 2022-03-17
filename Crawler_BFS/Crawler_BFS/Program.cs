using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crawler_BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\demo\FileSystem";
            DirCrawlerBFS dirCrawlerBFS = new DirCrawlerBFS();
            dirCrawlerBFS.searchAll(rootPath, "tesAll.txt");

            List<string> list = dirCrawlerBFS.Paths;

            if (list.Count == 0)
            {
                Console.WriteLine("Ga ketemu om");
            }
            else
            {
                foreach(string item in list)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
