using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using _17_7_BankUI;


namespace _17_9_CreateSequentialAccessFile
{
    public partial class CreateFileForm : BankUIForm
    {
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private string fileName;
        private bool firstRow = true;

        public CreateFileForm()
        {
            InitializeComponent();
            btnEnter.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show(
                    "Cannot close file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileChooser = new SaveFileDialog();
            fileChooser.CheckFileExists = false;

            DialogResult result = fileChooser.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                return;
            }

            fileName = fileChooser.FileName;
            if (fileName == "" || fileName == null)
            {
                MessageBox.Show(
                    "Invalid file name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSaveAs.Enabled = false;
            btnEnter.Enabled = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();
            if (values[(int)TextBoxIndices.ACCOUNT] == "")
            {
                MessageBox.Show(
                    "Invalid Account Number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int accountNumber;
            string firstName;
            string lastName;
            double balance;
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

            try
            {
                balance = Convert.ToDouble(values[(int)TextBoxIndices.BALANCE]);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid Account Balance", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            if (accountNumber <= 0)
            {
                MessageBox.Show(
                    "Invalid Account Number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            firstName = values[(int)TextBoxIndices.FIRSTNAME];
            lastName = values[(int)TextBoxIndices.LASTNAME];
            Record record = new Record(accountNumber, firstName, lastName, balance);
            try
            {
                output = GetFileStream();
                formatter.Serialize(output, record);
                firstRow = false;
                output.Close();
                ClearTextBoxes();
            }
            catch (SerializationException)
            {
                MessageBox.Show(
                        "Invalid Account Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private FileStream GetFileStream()
        {
            FileMode fileMode = firstRow ? FileMode.OpenOrCreate : FileMode.Append;
            try
            {
                return new FileStream(fileName, fileMode, FileAccess.Write);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(
                    "File Does Not Exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
