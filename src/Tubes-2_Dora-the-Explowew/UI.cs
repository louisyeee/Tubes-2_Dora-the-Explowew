using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Tubes_Stima
{
    public partial class UI : Form
    {
        private DirCrawlerBFS dirCrawlerBFS = new DirCrawlerBFS();
        private DirCrawlerDFS dirCrawlerDFS = new DirCrawlerDFS();
        private string rootFolder;
        private string filename;
        private string method;
        private bool findAll = false;
        public UI()
        {
            InitializeComponent();
        }

        private void folderSelect_Click(object sender, EventArgs e)
        {
            //
            // OpenFileDialog
            //
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.label4.Text = dialog.FileName;
                this.rootFolder = dialog.FileName;
            }
        }

        private void explore(string method, bool findAll)
        {
            if (method == "BFS")
            {
                if (findAll)
                {
                    dirCrawlerBFS.searchAll(this.rootFolder, this.filename);
                } else
                {
                    dirCrawlerBFS.searchFirst(this.rootFolder, this.filename);
                }
            }
            else if (method == "DFS")
            {
                if (findAll)
                {
                    dirCrawlerDFS.searchAll(this.rootFolder, this.filename);

                } else
                {
                    dirCrawlerDFS.searchFirst(this.rootFolder, this.filename);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            this.filename = this.fileNameInput.Text;
            this.findAll = this.checkBox1.Checked;
            if (this.checkBox1.Checked)
            {
                explore("BFS", this.findAll);
            } else
            {
                explore("DFS", this.findAll);
            }
            Microsoft.Msagl.Drawing.Graph graph = dirCrawlerDFS.Graph;
            this.graph.Graph = graph;
            sw.Stop();
            this.label6.Visible = true;
            this.label6.Text = String.Format("Time spent: {0:0.0#} s", sw.Elapsed.TotalMilliseconds / 1000);
        }
    }
}
