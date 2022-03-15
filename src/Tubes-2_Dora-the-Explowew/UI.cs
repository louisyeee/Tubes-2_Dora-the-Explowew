using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Tubes_Stima
{
    public partial class UI : Form
    {
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
            }
        }
    }
}
