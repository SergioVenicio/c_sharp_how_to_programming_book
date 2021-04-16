using _17_7_BankUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_12_CreditInquiry
{
    public partial class CredityInquiryForm : Form
    {
        private FileStream input;
        private BinaryFormatter reader = new BinaryFormatter();
        private string fileName;

        public CredityInquiryForm()
        {
            InitializeComponent();
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

            input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            btnOpen.Enabled = false;
            btnCredit.Enabled = true;
            btnDebit.Enabled = true;
            btnDone.Enabled = true;
        }

        private void get_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            string accountType = senderButton.Text;

            try
            {
                if (input != null)
                {
                    input.Close();
                }

                input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                txtOutPut.Text = "The accounts are:\r\n";
                while (true)
                {
                    Record record = (Record)reader.Deserialize(input);

                    if (ShouldDisplay(record.balance, accountType))
                    {
                        string balance = String.Format("{0:F}", record.balance);
                        txtOutPut.Text += $"{record.account}\t{record.firstName}\t{record.lastName}\t{balance}\n";
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Close File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SerializationException)
            {
                input.Close();
            }
        }

        private bool ShouldDisplay(double balance, string accountType)
        {
            switch (accountType)
            {
                case "Credit Balances":
                    return balance > 0;
                case "Debit Balances":
                    return balance < 0;
                case "Zero Balances":
                    return balance == 0;
                default:
                    return false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (input != null)
            {
                try
                {
                    input.Close();
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
    }
}
