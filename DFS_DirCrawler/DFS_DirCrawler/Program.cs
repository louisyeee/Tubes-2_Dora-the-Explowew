using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFS_DirCrawler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Pencarian DFS bentuknya instans dari class yang pertama dikonstruk dulu;
            DirCrawlerDFS dirCrawlerDFS = new DirCrawlerDFS();
            // Pencarian ada 2 method yaitu searchFirst dan searchAll,
            // Argumennya ada 2 :
            //    -  string root path belakangnya kasih @
            //    -  string nama file yang mau dicari pake extensinya
            dirCrawlerDFS.searchFirst(@"D:\Tubes 2 Stima", "test.txt");
            // Hasilnya nanti objeknya punya dua atribut:
            //    -  List<string> Paths yang isinya path-path ke file yang ditemuin,
            //          kalo ga ketemu nanti si Paths nya kosong
            //    -  Microsoft.Msagl.Drawing.Graph Graph ini isinya graph msagl yang digenerate.



            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // Disini dipake si Graph dari objek Crawler DFS nya
            Microsoft.Msagl.Drawing.Graph graph = dirCrawlerDFS.Graph;
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
