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
            dirCrawlerBFS.searchFirst(rootPath, "tesAll.txt");



            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // Disini dipake si Graph dari objek Crawler DFS nya
            Microsoft.Msagl.Drawing.Graph graph = dirCrawlerBFS.Graph;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();

        }
    }
}
