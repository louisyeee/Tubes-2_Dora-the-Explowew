using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Tubes_Stima
{
    public partial class UI : Form
    {
        private DirCrawlerBFS dirCrawlerBFS;
        private DirCrawlerDFS dirCrawlerDFS;
        private string rootFolder;
        private string filename;
        private bool findAll = false;
        public List<LinkLabel> labels = new List<LinkLabel>();
        public UI()
        {
            InitializeComponent();
        }

        private void load_result(string method)
        {
            if (method == "BFS")
            {
                for (int i = 0; i < dirCrawlerBFS.Result.Count; i++)
                {
                    labels.Add(new LinkLabel()
                    {
                        Name = "lbl" + i + 1,
                        Text = dirCrawlerBFS.Result[i],
                        Font = new System.Drawing.Font("Arial", 8),
                        ForeColor = System.Drawing.Color.Blue
                    });

                }
            }
            else if (method == "DFS")
            {
                for (int i = 0; i < dirCrawlerDFS.Result.Count; i++)
                {
                    labels.Add(new LinkLabel()
                    {
                        Name = "lbl" + i + 1,
                        Text = dirCrawlerDFS.Result[i],
                        Font = new System.Drawing.Font("Arial", 8),
                        ForeColor = System.Drawing.Color.Blue
                    });

                }
            }
            
            placelabels();
        }

        private void placelabels()
        {
            int topvalue = 430;
            foreach (LinkLabel item in labels)
            {
                item.AutoSize = true;
                item.Location = new System.Drawing.Point(315, topvalue);
                item.Size = new System.Drawing.Size(79, 16);
                item.TabIndex = 21;
                item.TabStop = true;
                item.TabIndex = 21;
                item.LinkClicked += new LinkLabelLinkClickedEventHandler(this.hyperlinkClicked);
                this.Controls.Add(item);
                topvalue += 20;

            }
        }
        private void hyperlinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            var url = System.IO.Directory.GetParent(link.Text);
            Process.Start("explorer.exe", "\"" + url + "\"");
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
            load_result(method);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            this.filename = this.fileNameInput.Text;
            this.findAll = this.checkBox1.Checked;
            if (this.checkBox1.Checked)
            {
                dirCrawlerBFS = new DirCrawlerBFS();
                explore("BFS", this.findAll);
            } else
            {
                dirCrawlerDFS = new DirCrawlerDFS();
                explore("DFS", this.findAll);
            }
            Microsoft.Msagl.Drawing.Graph graph = dirCrawlerDFS.Graph;
            this.graph.Graph = graph;
            sw.Stop();
            this.label6.Visible = true;
            this.label8.Visible = true;
            this.label6.Text = String.Format("Time spent: {0:0.0#} s", sw.Elapsed.TotalMilliseconds / 1000);
        }
    }
}
