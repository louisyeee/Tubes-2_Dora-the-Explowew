using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Msagl.Drawing;

namespace Crawler_BFS
{
    internal class DirCrawlerBFS
    {
        private Microsoft.Msagl.Drawing.Graph graph;
        private List<string> paths;

        public DirCrawlerBFS()
        {
            this.Graph = new Microsoft.Msagl.Drawing.Graph();
            this.Paths = new List<string>();
        }

        public void searchFirst(string rootPath, string fileTarget)
        {
            List<string> results = new List<string>();
            
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            bool found = false;
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                //graph.AddEdge(rootPath, file);
                if (Path.GetFileName(file) == fileTarget)
                {
                    results.Add(file);
                    Console.WriteLine("Ketemu di: ");
                    Console.WriteLine(file);
                    found = true;
                }
            }
            if (!found)
            {
                foreach (string dir in dirs)
                {
                    //graph.AddEdge(rootPath, dir);
                    files = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        //graph.AddEdge(dir, file);
                        if (Path.GetFileName(file) == fileTarget)
                        {
                            results.Add(file);
                            Console.WriteLine("Ketemu di: ");
                            Console.WriteLine(file);
                            found = true;
                        }
                        if (found)
                        {
                            break;
                        }
                    }

                }
                if (!found)
                {
                    foreach (string dirNew in dirs)
                    {
                        searchFirst(dirNew, fileTarget);
                    }
                }
            }
            this.paths = results;
        }

        public void searchAll(string rootPath, string fileTarget)
        {
            List<string> results = new List<string>();
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                //graph.AddEdge(rootPath, file);
                if (Path.GetFileName(file) == fileTarget)
                {
                    results.Add(file);
                    Console.WriteLine("Ketemu di: ");
                    Console.WriteLine(file);
                }
            }
            foreach (string dir in dirs)
            {
                //graph.AddEdge(rootPath, dir);
                searchAll(dir, fileTarget);
            }
            this.paths = results;
        }

        public List<string> Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }

        public Microsoft.Msagl.Drawing.Graph Graph
        {
            get { return this.graph; }
            set { this.graph = value; }
        }
    }


}
