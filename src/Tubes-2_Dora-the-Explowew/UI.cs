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
        private Microsoft.Msagl.Drawing.Graph graphTree;
        private string rootFolder;
        private string filename;
        private bool findAll = false;
        public List<LinkLabel> labels = new List<LinkLabel>();
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
                this.noRootLabel.Text = dialog.FileName;
                this.rootFolder = dialog.FileName;
            }
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

        private void load_result(string method)
        {
            labels.Clear();
            if (method == "BFS")
            {
                if (dirCrawlerBFS.Result.Count > 0)
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
                } else
                {
                    MessageBox.Show("Files " + this.filename + " not found", "Message");
                }
                
            }
            else if (method == "DFS")
            {
                if (dirCrawlerDFS.Result.Count > 0)
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
                else
                {
                    MessageBox.Show("Files " + this.filename + " not found", "Message");
                }
            }
            
            placelabels();
        }

        private void hyperlinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            var url = System.IO.Directory.GetParent(link.Text);
            Process.Start("explorer.exe", "\"" + url + "\"");
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
            if (this.rootFolder == null)
            {
                MessageBox.Show("Root folder cannot be null!", "Message");
            }
            else if (!this.bfsRadioButton.Checked && !this.dfsRadioButton.Checked)
            {

                MessageBox.Show("Select one method!", "Message");
            }
            else
            {
                Stopwatch sw = Stopwatch.StartNew();
                this.filename = this.fileNameInput.Text;
                this.findAll = this.findAllCheckbox.Checked;
                if (this.bfsRadioButton.Checked)
                {
                    dirCrawlerBFS = new DirCrawlerBFS();
                    explore("BFS", this.findAll);
                    graphTree = dirCrawlerBFS.Graph;
                }
                else
                {
                    dirCrawlerDFS = new DirCrawlerDFS();
                    explore("DFS", this.findAll);
                    graphTree = dirCrawlerDFS.Graph;
                }

                this.graphViewer.Graph = graphTree;
                sw.Stop();
                this.timeSpentLabel.Visible = true;
                this.resultLabel.Visible = true;
                this.timeSpentLabel.Text = String.Format("Time spent: {0:0.0#} s", sw.Elapsed.TotalMilliseconds / 1000);
            }
        }
    }
}
