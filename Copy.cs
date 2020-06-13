using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopiaEmissor
{
    class Copy
    {
        public void copyFiles(string sourcePath, string backupPath, ProgressBar pBar)
        {
            pBar.Visible = true;
            pBar.Minimum = 0;
            try
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, backupPath));
                }

                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    pBar.Maximum = newPath.Length;
                    pBar.Step = 1;

                    File.Copy(newPath, newPath.Replace(sourcePath, backupPath), true);

                    if (pBar.Value != newPath.Length)
                        pBar.PerformStep();
                }
            }

            catch (IOException copyError)
            {
                MessageBox.Show(copyError.Message);
            }
        }

        public void ReadTxt(string sourcePath, string configFile, ProgressBar pBar)
        {
            try
            {
                using (StreamReader file = new StreamReader(configFile))
                {
                    string[] lines = File.ReadAllLines(configFile);

                    foreach (string line in lines)
                        copyFiles(sourcePath, line, pBar);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("The file could not be read:" + e.Message);
            }
        }
    }
}