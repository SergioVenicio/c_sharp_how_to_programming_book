using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using _17_7_BankUI;

namespace _17_11_ReadSequentialAccessFile
{
    public partial class ReadSequentialAccessFileForm : BankUIForm
    {
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;

        public ReadSequentialAccessFileForm()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            string fileName = fileChooser.FileName;
            ClearTextBoxes();

            if (fileName == "" || fileName == null)
            {
                MessageBox.Show(
                    "Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            } catch (IOException)
            {
                MessageBox.Show(
                    "Error to read file data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Record record;

            try
            {
                record = (Record)reader.Deserialize(input);
            }
            catch (SerializationException)
            {
                MessageBox.Show(
                    "No more record in file", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                input.Close();
                btnOpen.Enabled = true;
                btnNext.Enabled = false;
                ClearTextBoxes();
                return;
            }

            string[] values = new string[]
            {
                record.account.ToString(),
                record.firstName.ToString(),
                record.lastName.ToString(),
                record.balance.ToString()
            };
            SetTextBoxValues(values);
        }
    }
}
