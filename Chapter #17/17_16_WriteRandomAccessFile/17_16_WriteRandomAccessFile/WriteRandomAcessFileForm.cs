using System;
using System.IO;
using System.Windows.Forms;

using _17_7_BankUI;

namespace _17_16_WriteRandomAccessFile
{
    public partial class WriteRandomAcessFileForm : BankUIForm
    {
        private const int NUMBER_OF_RECORDS = 100;
        private string fileName;
        private BinaryWriter binaryOutput;
        private bool firstRow = true;
        private int accountNumber;

        public WriteRandomAcessFileForm()
        {
            InitializeComponent();
            btnEnter.Enabled = false;
        }

        private FileStream GetFileStream()
        {
            FileMode fileMode = firstRow ? FileMode.Create : FileMode.Append;
            try {
                FileStream stream = new FileStream(fileName, fileMode, FileAccess.Write);
                firstRow = false;
                stream.Seek((accountNumber - 1) * RandomAccessRecord.SIZE, SeekOrigin.Begin);
                return stream;
            }
            catch (IOException)
            {
                return null;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }

            fileName = fileChooser.FileName;
            if (fileName == "" || fileName == null)
            {
                MessageBox.Show(
                    "Invalid File Name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnOpen.Enabled = false;
            btnEnter.Enabled = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();
            double accountBalance;

            if (values[(int)TextBoxIndices.ACCOUNT] == "")
            {
                MessageBox.Show(
                    "Invalid Account Number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                accountNumber = Convert.ToInt32(values[(int)TextBoxIndices.ACCOUNT]);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid Account Number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                accountBalance = Convert.ToDouble(values[(int)TextBoxIndices.BALANCE]);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid Account Balance", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accountNumber < 0 || accountNumber > 100)
            {
                MessageBox.Show(
                "Invalid Account Number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileStream fileStream = GetFileStream();
            binaryOutput = new BinaryWriter(fileStream);
            binaryOutput.Write(accountNumber);
            binaryOutput.Write(values[(int)TextBoxIndices.FIRSTNAME]);
            binaryOutput.Write(values[(int)TextBoxIndices.LASTNAME]);
            binaryOutput.Write(accountBalance);
            ClearTextBoxes();
            fileStream.Close();
            binaryOutput.Close();
        }
    }
}
