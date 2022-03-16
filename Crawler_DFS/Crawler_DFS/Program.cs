using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crawler_DFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirCrawlerDFS dirCrawlerDFS = new DirCrawlerDFS();
            dirCrawlerDFS.searchAll(@"D:\Tubes 2 Stima", "test.txt");

            List<string> list = dirCrawlerDFS.Paths;

            if (list.Count == 0)
            {
                Console.WriteLine("kasian deh");
            }
            else
            {
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
            }


            Console.ReadLine();
        }
    }
}
