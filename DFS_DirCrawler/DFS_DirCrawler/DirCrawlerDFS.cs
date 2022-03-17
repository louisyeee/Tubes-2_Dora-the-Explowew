using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DFS_DirCrawler
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

            myStack.Push(rootPath);

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
                    this.drawPohon(currPath, file);
                }

                foreach (string dir in currDirs)
                {
                    myStack.Push(dir);
                    this.drawPohon(currPath, dir);
                }
                

            }

            this.paths = results;
        }
        public void searchAll(string rootPath, string fileTarget)
        {
            List<string> results = new List<string>();
            Stack myStack = new Stack();

            myStack.Push(rootPath);

            while (myStack.Count > 0)
            {
                string currPath = (string)myStack.Pop();
                string[] currDirs = Directory.GetDirectories(@currPath);
                string[] currFiles = Directory.GetFiles(@currPath);

                foreach (string file in currFiles)
                {
                    Console.WriteLine("currPath =" + currPath);
                    Console.WriteLine("DirName =" + Path.GetFileName(currPath));
                    Console.WriteLine("file =" + file);
                    
                    if (fileTarget == Path.GetFileName(file))
                    {
                        results.Add(file);
                    }

                    this.drawPohon(currPath, file);
                    
                }
                foreach (string dir in currDirs)
                {
                    Console.WriteLine("currPath =" + currPath);
                    Console.WriteLine("DirName =" + Path.GetFileName(currPath));
                    Console.WriteLine("dir =" + dir);
                    myStack.Push(dir);

                    this.drawPohon(currPath, dir);
                    
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

        public void drawPohon(string currPath, string path)
        {
            if (this.Graph.FindNode(Path.GetFileName(path)) is null)
            {
                this.Graph.AddEdge(Path.GetFileName(currPath), Path.GetFileName(path));
            }
            else
            {
                this.Graph.AddEdge(Path.GetFileName(currPath), Path.GetFileName(path) + Path.GetFileName(currPath));
                this.Graph.FindNode(Path.GetFileName(path) + Path.GetFileName(currPath)).LabelText = Path.GetFileName(path);
            }
        }
    }


}
