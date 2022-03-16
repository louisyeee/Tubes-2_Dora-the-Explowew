using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crawler_DFS
{
    internal class DirCrawlerDFS
    {
        private Microsoft.Msagl.Drawing.Graph graph;
        private List<string> paths;

        public DirCrawlerDFS()
        {
            this.Graph = new Microsoft.Msagl.Drawing.Graph();
            this.Paths = new List<string>();
        }
        public void searchFirst(string rootPath, string fileTarget)
        {
            List<string> results = new List<string>();
            Stack myStack = new Stack();
            bool found = false;

            string[] rootDirs = Directory.GetDirectories(rootPath);
            foreach (string dir in rootDirs)
            {
                myStack.Push(dir);
            }

            while (myStack.Count > 0 && !found)
            {
                string currPath = (string)myStack.Pop();
                string[] currDirs = Directory.GetDirectories(@currPath);
                string[] currFiles = Directory.GetFiles(@currPath);

                foreach (string file in currFiles)
                {
                    if (fileTarget == Path.GetFileName(file))
                    {
                        results.Add(file);
                        found = true;
                    }
                }

                foreach (string dir in currDirs)
                {
                    myStack.Push(dir);
                }
                Console.WriteLine(currPath);

            }

            this.paths = results;
        }
        public void searchAll(string rootPath, string fileTarget)
        {
            List<string> results = new List<string>();
            Stack myStack = new Stack();


            string[] rootDirs = Directory.GetDirectories(rootPath);
            foreach (string dir in rootDirs)
            {
                myStack.Push(dir);
            }
            while (myStack.Count > 0)
            {
                string currPath = (string)myStack.Pop();
                string[] currDirs = Directory.GetDirectories(@currPath);
                string[] currFiles = Directory.GetFiles(@currPath);

                foreach (string file in currFiles)
                {
                    if (fileTarget == Path.GetFileName(file))
                    {
                        results.Add(file);
                    }
                }
                foreach (string dir in currDirs)
                {
                    myStack.Push(dir);
                }
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
