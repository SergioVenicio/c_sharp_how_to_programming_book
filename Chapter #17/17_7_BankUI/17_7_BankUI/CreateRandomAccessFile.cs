using System;
using System.IO;
using System.Windows.Forms;

namespace _17_7_BankUI
{
    class CreateRandomAccessFile
    {
        private const int NUMBER_OF_RECORDS = 100;

        [STAThread]
        static void Main(string[] args)
        {
            CreateRandomAccessFile file = new CreateRandomAccessFile();
            file.SaveFile();
        }

        private void SaveFile()
        {
            RandomAccessRecord blankRecord = new RandomAccessRecord();
            FileStream fileOutput = null;
            BinaryWriter binaryOutput = null;

            SaveFileDialog fileChooser = new SaveFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName = fileChooser.FileName;

            if (result == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                fileOutput = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                fileOutput.SetLength(RandomAccessRecord.SIZE * NUMBER_OF_RECORDS);
                binaryOutput = new BinaryWriter(fileOutput);

                for (int i = 0; i < NUMBER_OF_RECORDS; i++)
                {
                    fileOutput.Position = i * RandomAccessRecord.SIZE;
                    binaryOutput.Write(blankRecord.Account);
                    binaryOutput.Write(blankRecord.FirstName);
                    binaryOutput.Write(blankRecord.LastName);
                    binaryOutput.Write(blankRecord.Balance);

                    MessageBox.Show(
                        "File Created", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show(
                        "Cannot write to file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (fileOutput == null)
            {
                fileOutput.Close();
            }

            if (binaryOutput == null)
            {
                binaryOutput.Close();
            }
        }
    }
}
