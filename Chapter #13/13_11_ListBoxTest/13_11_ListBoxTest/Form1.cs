using System;
using System.Windows.Forms;

namespace _13_11_ListBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtNewItem.Text;
            if (!lbxItens.Items.Contains(newItem))
            {
                lbxItens.Items.Add(newItem);
            }

            txtNewItem.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedItem = lbxItens.SelectedIndex;
            if (selectedItem != -1)
            {
                lbxItens.Items.RemoveAt(selectedItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxItens.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
