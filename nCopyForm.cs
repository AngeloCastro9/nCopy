﻿using System;
using System.Windows.Forms;

namespace CopiaEmissor
{
    public partial class nCopyForm : Form
    {
        public nCopyForm()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtSourcePath.Text = dialog.SelectedPath;
        }

        private void btnOpenFolder2_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            txtConfigFile.Text = dialog.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (txtConfigFile.Text != "")
            {
                if (txtSourcePath.Text != "")
                {
                    Copy copy = new Copy();
                    copy.ReadTxt(txtSourcePath.Text, txtConfigFile.Text, progressBar1);
                }
                else
                {
                    MessageBox.Show("Invalid path source");
                }
            }
            else
            {
                MessageBox.Show("Invalid txt config file");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var helpBrForm = new Ajuda();
            helpBrForm.Show();
        }
    }
}
