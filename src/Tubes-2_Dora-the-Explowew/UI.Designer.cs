using System.Windows.Forms;

namespace Tubes_Stima
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("TOLOL");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("TOLOL");
            this.title = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.graph = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Hyperlink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(442, 9);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(4);
            this.title.Size = new System.Drawing.Size(254, 52);
            this.title.TabIndex = 0;
            this.title.Text = "Folder Crawling";
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divider1.Location = new System.Drawing.Point(12, 65);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(1110, 1);
            this.divider1.TabIndex = 1;
            // 
            // divider2
            // 
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divider2.Location = new System.Drawing.Point(375, 65);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(1, 576);
            this.divider2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Starting Directory ";
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.folderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderSelectButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.folderSelectButton.Location = new System.Drawing.Point(39, 162);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(124, 31);
            this.folderSelectButton.TabIndex = 6;
            this.folderSelectButton.Text = "Choose Folder";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(179, 169);
            this.label4.MaximumSize = new System.Drawing.Size(150, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "No File Chosen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 215);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input File Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 310);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(149, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Metode Pencarian";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Find All Occurence";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 347);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(39, 373);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DFS";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Location = new System.Drawing.Point(39, 414);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 32);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fileNameInput
            // 
            this.fileNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNameInput.Font = new System.Drawing.Font("Segoe UI Emoji", 8.2F);
            this.fileNameInput.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fileNameInput.Location = new System.Drawing.Point(39, 240);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(107, 26);
            this.fileNameInput.TabIndex = 16;
            this.fileNameInput.Text = "e.g. \"word.pdf\"";
            this.fileNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // graph
            // 
            this.graph.ArrowheadLength = 10D;
            this.graph.AsyncLayout = false;
            this.graph.AutoScroll = true;
            this.graph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graph.BackwardEnabled = false;
            this.graph.BuildHitTree = true;
            this.graph.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.graph.EdgeInsertButtonVisible = false;
            this.graph.FileName = "";
            this.graph.ForwardEnabled = false;
            this.graph.Graph = null;
            this.graph.InsertingEdge = false;
            this.graph.LayoutAlgorithmSettingsButtonVisible = false;
            this.graph.LayoutEditingEnabled = true;
            this.graph.Location = new System.Drawing.Point(382, 110);
            this.graph.LooseOffsetForRouting = 0.25D;
            this.graph.MouseHitDistance = 0.05D;
            this.graph.Name = "graph";
            this.graph.NavigationVisible = true;
            this.graph.NeedToCalculateLayout = true;
            this.graph.OffsetForRelaxingInRouting = 0.6D;
            this.graph.PaddingForEdgeRouting = 8D;
            this.graph.PanButtonPressed = false;
            this.graph.SaveAsImageEnabled = true;
            this.graph.SaveAsMsaglEnabled = true;
            this.graph.SaveButtonVisible = true;
            this.graph.SaveGraphButtonVisible = true;
            this.graph.SaveInVectorFormatEnabled = true;
            this.graph.Size = new System.Drawing.Size(748, 351);
            this.graph.TabIndex = 17;
            this.graph.TightOffsetForRouting = 0.125D;
            this.graph.ToolBarIsVisible = true;
            this.graph.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("graph.Transform")));
            this.graph.UndoRedoButtonsVisible = true;
            this.graph.WindowZoomButtonPressed = false;
            this.graph.ZoomF = 1D;
            this.graph.ZoomWindowThreshold = 0.05D;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Time spent";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Path file:";
            this.label8.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hyperlink});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(410, 524);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 117);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Hyperlink
            // 
            this.Hyperlink.Width = 600;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 661);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.folderSelectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divider2);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.title);
            this.Name = "UI";
            this.Text = "Folder Crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button searchButton;
        private TextBox fileNameInput;
        private Microsoft.Msagl.GraphViewerGdi.GViewer graph;
        private Label label6;
        private Label label8;
        private ListView listView1;
        private ColumnHeader Hyperlink;
    }
}

