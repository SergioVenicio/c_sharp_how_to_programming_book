using System;

using System.Windows.Forms;

namespace _17_7_BankUI
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount = 4;
        public enum TextBoxIndices
        {
            ACCOUNT,
            FIRSTNAME,  
            LASTNAME,
            BALANCE
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new BankUIForm());
        }

        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            Control[] controls = new Control[]{
                txtAccount,
                txtFirstName,
                txtLastName,
                txtBalance
            };
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw new ArgumentException($"There must be {TextBoxCount + 1} strings in the array");
            }

            txtAccount.Text = values[(int)TextBoxIndices.ACCOUNT];
            txtFirstName.Text = values[(int)TextBoxIndices.FIRSTNAME];
            txtLastName.Text = values[(int)TextBoxIndices.LASTNAME];
            txtBalance.Text = values[(int)TextBoxIndices.BALANCE];
        }

        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIndices.ACCOUNT] = txtAccount.Text;
            values[(int)TextBoxIndices.FIRSTNAME] = txtFirstName.Text;
            values[(int)TextBoxIndices.LASTNAME] = txtLastName.Text;
            values[(int)TextBoxIndices.BALANCE] = txtBalance.Text;

            return values;
        }
    }
}
