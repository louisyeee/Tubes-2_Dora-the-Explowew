using System.Collections.Generic;
using System.IO;

namespace Tubes_Stima
{
    internal class DirCrawlerBFS
    {
        private Microsoft.Msagl.Drawing.Graph graph;
        private List<string> paths;
        private List<string> results;

        public DirCrawlerBFS()
        {
            this.Graph = new Microsoft.Msagl.Drawing.Graph();
            this.Paths = new List<string>();
        }

        public void searchFirst(string rootPath, string fileTarget)
        {
            results = new List<string>();
            Queue<string> myQueue = new Queue<string>();
            bool found = false;
            myQueue.Enqueue(rootPath);

            while (myQueue.Count > 0 && !found)
            {
                string currPath = (string)myQueue.Dequeue();
                string[] currDirs;
                string[] currFiles;
                try
                {
                    currDirs = Directory.GetDirectories(@currPath);
                }
                catch
                {
                    currDirs = new string[] { };
                }

                try
                {
                    currFiles = Directory.GetFiles(@currPath);
                }
                catch
                {
                    currFiles = new string[] { };
                }

                foreach (string file in currFiles)
                {
                    myQueue.Enqueue(file);
                    this.drawPohon(currPath, file);
                }
                foreach (string dir in currDirs)
                {
                    myQueue.Enqueue(dir);
                    this.drawPohon(currPath, dir);
                }
                if (fileTarget == Path.GetFileName(currPath))
                {
                    results.Add(currPath);
                    found = true;


                }
                else
                {
                    giveColor(currPath, rootPath, "red");
                }


            }
            foreach (string result in results)
            {
                giveColor(result, rootPath, "blue");
            }
            this.paths = results;
        }

        public void searchAll(string rootPath, string fileTarget)
        {
            results = new List<string>();
            List<string> nonResults = new List<string>();
            Queue<string> myQueue = new Queue<string>();
            bool found = false;
            myQueue.Enqueue(rootPath);

            while (myQueue.Count > 0)
            {
                string currPath = (string)myQueue.Dequeue();
                string[] currDirs;
                string[] currFiles;
                try
                {
                    currDirs = Directory.GetDirectories(@currPath);
                }
                catch
                {
                    currDirs = new string[] { };
                }

                try
                {
                    currFiles = Directory.GetFiles(@currPath);
                }
                catch
                {
                    currFiles = new string[] { };
                }

                foreach (string file in currFiles)
                {
                    myQueue.Enqueue(file);
                    this.drawPohon(currPath, file);
                }
                foreach (string dir in currDirs)
                {
                    myQueue.Enqueue(dir);
                    this.drawPohon(currPath, dir);
                }
                if (fileTarget == Path.GetFileName(currPath))
                {
                    results.Add(currPath);
                    found = true;

                }
                else if (currFiles.Length == 0 && currDirs.Length == 0)
                {
                    giveColor(currPath, rootPath, "red");
                }


            }
            foreach (string result in results)
            {
                giveColor(result, rootPath, "blue");
            }
            //this.Graph.FindNode(Path.GetFileName(rootPath) + Path.GetFileName(Path.GetDirectoryName(rootPath))).LabelText = Path.GetFileName(rootPath);
            //if (results.Count == 0)
            //{
            //    this.Graph.FindNode(Path.GetFileName(rootPath) + Path.GetFileName(Path.GetDirectoryName(rootPath))).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            //}
            //else
            //{
            //    this.Graph.FindNode(Path.GetFileName(rootPath) + Path.GetFileName(Path.GetDirectoryName(rootPath))).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
            //}
            this.paths = results;
        }

        public List<string> Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }
        
        public List<string> Result
        {
            get { return this.results; }
            set { this.results = value; }
        }

        public Microsoft.Msagl.Drawing.Graph Graph
        {
            get { return this.graph; }
            set { this.graph = value; }
        }

        public void drawPohon(string currPath, string path)
        {
            string grand = Path.GetDirectoryName(currPath);
            this.Graph.AddEdge(Path.GetFileName(currPath) + Path.GetFileName(grand), Path.GetFileName(path) + Path.GetFileName(currPath));
            this.Graph.FindNode(Path.GetFileName(path) + Path.GetFileName(currPath)).LabelText = Path.GetFileName(path);
        }

        public void giveColor(string path, string rootPath, string color)
        {
            List<string> targetNodes = new List<string>();
            while (!path.Equals(rootPath))
            {
                string parent = Path.GetDirectoryName(path);
                targetNodes.Add(Path.GetFileName(path) + Path.GetFileName(parent));
                path = parent;
            }

            foreach (var edge in this.Graph.Edges)
            {
                if (targetNodes.Contains(edge.TargetNode.Id))
                {
                    if (color.Equals("red"))
                    {
                        edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        edge.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                    else if (color.Equals("blue"))
                    {
                        edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        edge.TargetNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    }
                }
            }
        }
    }


}