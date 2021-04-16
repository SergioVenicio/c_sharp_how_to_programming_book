using System;
using System.IO;
using System.Windows.Forms;
using _17_7_BankUI;

namespace _17_17_ReadRandomAccessFile
{
    public partial class ReandRandomAccessForm : BankUIForm
    {
        private int currentRecordIndex;
        private string fileName;

        public ReandRandomAccessForm()
        {
            InitializeComponent();
        }


        private FileStream GetFileStream()
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            stream.Seek(
                currentRecordIndex * RandomAccessRecord.SIZE, 0);
            return stream;
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
            btnNext.Enabled = true;
            currentRecordIndex = 0;
            ClearTextBoxes();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FileStream stream = GetFileStream();
            BinaryReader binaryInput = new BinaryReader(stream);
            RandomAccessRecord record = new RandomAccessRecord();

            try
            {
                string[] values;
                while(record.Account == 0)
                {
                    currentRecordIndex++;
                    record.Account = binaryInput.ReadInt32();
                    record.FirstName = binaryInput.ReadString();
                    record.LastName = binaryInput.ReadString();
                    record.Balance = binaryInput.ReadDouble();
                }

                values = new string[]
                {
                    record.Account.ToString(),
                    record.FirstName.ToString(),
                    record.LastName.ToString(),
                    record.Balance.ToString()
                };

                SetTextBoxValues(values);
                stream.Close();
                binaryInput.Close();
            }
            catch (IOException)
            {
                ClearTextBoxes();
                MessageBox.Show(
                    "No more records in file", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
