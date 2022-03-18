using System;
using System.Collections.Generic;
using System.IO;

namespace Tubes_Stima
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
            List<string> nonResults = new List<string>();
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            bool found = false;
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                this.drawPohon(rootPath, file);
                if (Path.GetFileName(file) == fileTarget)
                {
                    results.Add(file);
                    Console.WriteLine("Ketemu di: ");
                    Console.WriteLine(file);
                    found = true;
                }
                else
                {
                    nonResults.Add(file);
                }
            }

            if (!found)
            {
                foreach (string dir in dirs)
                {
                    this.drawPohon(rootPath, dir);
                    files = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        this.drawPohon(dir, file);
                        if (Path.GetFileName(file) == fileTarget)
                        {

                            results.Add(file);
                            Console.WriteLine("Ketemu di: ");
                            Console.WriteLine(file);
                            found = true;
                        }
                        else
                        {
                            nonResults.Add(file);
                        }
                        if (found)
                        {
                            break;
                        }

                    }

                    foreach (string nonRes in nonResults)
                    {
                        giveColor(nonRes, rootPath, "red");
                    }
                    foreach (string result in results)
                    {
                        giveColor(result, rootPath, "blue");
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
            List<string> nonResults = new List<string>();
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                this.drawPohon(rootPath, file);
                if (Path.GetFileName(file) == fileTarget)
                {
                    results.Add(file);
                    Console.WriteLine("Ketemu di: ");
                    Console.WriteLine(file);
                }
                else
                {
                    nonResults.Add(file);
                }


            }
            foreach (string dir in dirs)
            {
                this.drawPohon(rootPath, dir);
                searchAll(dir, fileTarget);
            }
            foreach (string nonRes in nonResults)
            {
                giveColor(nonRes, rootPath, "red");
            }
            foreach (string result in results)
            {
                giveColor(result, rootPath, "blue");
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
