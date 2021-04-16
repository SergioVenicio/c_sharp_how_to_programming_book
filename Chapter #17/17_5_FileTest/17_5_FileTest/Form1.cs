using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_5_FileTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = txtFileName.Text;
                string[] directoryList;

                if (File.Exists(fileName))
                {
                    txtOutput.Text = GetInformation(fileName);

                    try
                    {
                        StreamReader stream = new StreamReader(fileName);
                        txtOutput.Text += stream.ReadToEnd();
                    } catch (IOException)
                    {
                        MessageBox.Show(
                        "File Error",
                        "File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else if (Directory.Exists(fileName))
                {
                    directoryList = Directory.GetDirectories(fileName);
                    txtOutput.Text += "\r\n\rDirectory contents:\r\n";
                    foreach (string directory in directoryList)
                    {
                        txtOutput.Text += $"{directory}\r\n";
                    }
                }
                else
                {
                    MessageBox.Show(
                        $"{fileName} does not exist",
                        "File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string GetInformation(string filename)
        {
            string information = $"{filename}\r\n";

            information += $"Created: {File.GetCreationTime(filename)}\r\n";
            information += $"Last modified: {File.GetLastWriteTime(filename)}\r\n";
            information += $"Last accessed: {File.GetLastAccessTime(filename)}\r\n";

            return information;
        }
    }
}
