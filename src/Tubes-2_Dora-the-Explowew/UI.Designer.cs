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
            this.title = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.chooseRootLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.noRootLabel = new System.Windows.Forms.Label();
            this.inputFIlenameLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.findAllCheckbox = new System.Windows.Forms.CheckBox();
            this.bfsRadioButton = new System.Windows.Forms.RadioButton();
            this.dfsRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.timeSpentLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.hyperlinkPlaceholder = new System.Windows.Forms.LinkLabel();
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
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(731, 76);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(86, 31);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(33, 85);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(68, 31);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input";
            // 
            // chooseRootLabel
            // 
            this.chooseRootLabel.AutoSize = true;
            this.chooseRootLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRootLabel.Location = new System.Drawing.Point(35, 127);
            this.chooseRootLabel.Name = "chooseRootLabel";
            this.chooseRootLabel.Size = new System.Drawing.Size(211, 22);
            this.chooseRootLabel.TabIndex = 5;
            this.chooseRootLabel.Text = "Choose Starting Directory ";
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
            // noRootLabel
            // 
            this.noRootLabel.AutoEllipsis = true;
            this.noRootLabel.Location = new System.Drawing.Point(179, 169);
            this.noRootLabel.MaximumSize = new System.Drawing.Size(150, 16);
            this.noRootLabel.Name = "noRootLabel";
            this.noRootLabel.Size = new System.Drawing.Size(99, 16);
            this.noRootLabel.TabIndex = 7;
            this.noRootLabel.Text = "No File Chosen";
            // 
            // inputFIlenameLabel
            // 
            this.inputFIlenameLabel.AutoSize = true;
            this.inputFIlenameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFIlenameLabel.Location = new System.Drawing.Point(39, 215);
            this.inputFIlenameLabel.Name = "inputFIlenameLabel";
            this.inputFIlenameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputFIlenameLabel.Size = new System.Drawing.Size(132, 22);
            this.inputFIlenameLabel.TabIndex = 8;
            this.inputFIlenameLabel.Text = "Input File Name";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(39, 310);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.methodLabel.Size = new System.Drawing.Size(149, 22);
            this.methodLabel.TabIndex = 10;
            this.methodLabel.Text = "Metode Pencarian";
            // 
            // findAllCheckbox
            // 
            this.findAllCheckbox.AutoSize = true;
            this.findAllCheckbox.Location = new System.Drawing.Point(39, 275);
            this.findAllCheckbox.Name = "findAllCheckbox";
            this.findAllCheckbox.Size = new System.Drawing.Size(141, 20);
            this.findAllCheckbox.TabIndex = 11;
            this.findAllCheckbox.Text = "Find All Occurence";
            this.findAllCheckbox.UseVisualStyleBackColor = true;
            // 
            // bfsRadioButton
            // 
            this.bfsRadioButton.AutoSize = true;
            this.bfsRadioButton.Location = new System.Drawing.Point(39, 347);
            this.bfsRadioButton.Name = "bfsRadioButton";
            this.bfsRadioButton.Size = new System.Drawing.Size(54, 20);
            this.bfsRadioButton.TabIndex = 12;
            this.bfsRadioButton.TabStop = true;
            this.bfsRadioButton.Text = "BFS";
            this.bfsRadioButton.UseVisualStyleBackColor = true;
            // 
            // dfsRadioButton
            // 
            this.dfsRadioButton.AutoSize = true;
            this.dfsRadioButton.Location = new System.Drawing.Point(39, 373);
            this.dfsRadioButton.Name = "dfsRadioButton";
            this.dfsRadioButton.Size = new System.Drawing.Size(55, 20);
            this.dfsRadioButton.TabIndex = 13;
            this.dfsRadioButton.TabStop = true;
            this.dfsRadioButton.Text = "DFS";
            this.dfsRadioButton.UseVisualStyleBackColor = true;
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
            // graphViewer
            // 
            this.graphViewer.ArrowheadLength = 10D;
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.BuildHitTree = true;
            this.graphViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.graphViewer.EdgeInsertButtonVisible = false;
            this.graphViewer.FileName = "";
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.InsertingEdge = false;
            this.graphViewer.LayoutAlgorithmSettingsButtonVisible = false;
            this.graphViewer.LayoutEditingEnabled = true;
            this.graphViewer.Location = new System.Drawing.Point(382, 110);
            this.graphViewer.LooseOffsetForRouting = 0.25D;
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.NeedToCalculateLayout = true;
            this.graphViewer.OffsetForRelaxingInRouting = 0.6D;
            this.graphViewer.PaddingForEdgeRouting = 8D;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveAsImageEnabled = true;
            this.graphViewer.SaveAsMsaglEnabled = true;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.SaveGraphButtonVisible = true;
            this.graphViewer.SaveInVectorFormatEnabled = true;
            this.graphViewer.Size = new System.Drawing.Size(748, 351);
            this.graphViewer.TabIndex = 17;
            this.graphViewer.TightOffsetForRouting = 0.125D;
            this.graphViewer.ToolBarIsVisible = true;
            this.graphViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("graphViewer.Transform")));
            this.graphViewer.UndoRedoButtonsVisible = true;
            this.graphViewer.WindowZoomButtonPressed = false;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // timeSpentLabel
            // 
            this.timeSpentLabel.AutoSize = true;
            this.timeSpentLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpentLabel.Location = new System.Drawing.Point(406, 464);
            this.timeSpentLabel.Name = "timeSpentLabel";
            this.timeSpentLabel.Size = new System.Drawing.Size(94, 22);
            this.timeSpentLabel.TabIndex = 18;
            this.timeSpentLabel.Text = "Time spent";
            this.timeSpentLabel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(406, 499);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(76, 22);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "Path file:";
            this.resultLabel.Visible = false;
            // 
            // hyperlinkPlaceholder
            // 
            this.hyperlinkPlaceholder.AutoSize = true;
            this.hyperlinkPlaceholder.Location = new System.Drawing.Point(407, 530);
            this.hyperlinkPlaceholder.Name = "hyperlinkPlaceholder";
            this.hyperlinkPlaceholder.Size = new System.Drawing.Size(79, 16);
            this.hyperlinkPlaceholder.TabIndex = 21;
            this.hyperlinkPlaceholder.TabStop = true;
            this.hyperlinkPlaceholder.Text = "placeholder";
            this.hyperlinkPlaceholder.Visible = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 661);
            this.Controls.Add(this.hyperlinkPlaceholder);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timeSpentLabel);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dfsRadioButton);
            this.Controls.Add(this.bfsRadioButton);
            this.Controls.Add(this.findAllCheckbox);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.inputFIlenameLabel);
            this.Controls.Add(this.noRootLabel);
            this.Controls.Add(this.folderSelectButton);
            this.Controls.Add(this.chooseRootLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputLabel);
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
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label chooseRootLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.Label noRootLabel;
        private System.Windows.Forms.Label inputFIlenameLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.CheckBox findAllCheckbox;
        private System.Windows.Forms.RadioButton bfsRadioButton;
        private System.Windows.Forms.RadioButton dfsRadioButton;
        private System.Windows.Forms.Button searchButton;
        private TextBox fileNameInput;
        private Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer;
        private Label timeSpentLabel;
        private Label resultLabel;
        private LinkLabel hyperlinkPlaceholder;
    }
}

