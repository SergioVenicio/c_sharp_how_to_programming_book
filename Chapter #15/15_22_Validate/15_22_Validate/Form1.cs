using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_22_Validate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblValidate_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;
            string phone = txtPhone.Text;

            if (lastName == "" || firstName == "" ||
                address == "" || city == "" ||
                state == "" || zip == "" || phone == "")
            {
                MessageBox.Show(
                    "Please fill in all fields",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
               );
                return;
            }

            if (!Regex.Match(lastName, @"^[A-ZÀ-Ý][a-zA-ZÀ-ÿ]*$").Success)
            {
                MessageBox.Show(
                    "Invalid Last Name",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtLastName.Focus();
                return;
            }

            if (!Regex.Match(firstName, @"^[A-ZÀ-Ý][a-zA-ZÀ-ÿ]*$").Success)
            {
                MessageBox.Show(
                    "Invalid First Name",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtFirstName.Focus();
                return;
            }

            if (!Regex.Match(address, @"^[0-9]+\s+([a-zA-Z][a-zA-ZÀ-ÿ]+|[a-zA-Z][a-zA-ZÀ-ÿ]+\s[a-zA-Z][a-zA-ZÀ-ÿ]+)$").Success)
            {
                MessageBox.Show(
                    "Invalid address",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtAddress.Focus();
                return;
            }

            if (!Regex.Match(city, @"^([a-zA-Z][a-zA-ZÀ-ÿ]+|[a-zA-Z][a-zA-ZÀ-ÿ]+\s[a-zA-Z][a-zA-ZÀ-ÿ]+)*$").Success)
            {
                MessageBox.Show(
                    "Invalid City",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtCity.Focus();
                return;
            }

            if (!Regex.Match(state, @"[a-zA-Z]{2}").Success)
            {
                MessageBox.Show(
                    "Invalid State",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtState.Focus();
                return;
            }

            if (!Regex.Match(zip, @"^\d{5}").Success)
            {
                MessageBox.Show(
                    "Invalid Zip Code",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtZip.Focus();
                return;
            }

            if (!Regex.Match(phone, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}").Success)
            {
                MessageBox.Show(
                    "Invalid Phone",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtPhone.Focus();
                return;
            }
        }
    }
}
