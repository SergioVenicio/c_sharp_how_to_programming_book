using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace _18_9_PathNavigator
{
    public partial class PathNavigator : Form
    {
        private XPathNavigator xpath;
        private XPathDocument document;
        private TreeNode tree;

        public PathNavigator()
        {
            InitializeComponent();

            document = new XPathDocument("..\\..\\sports.xml");
            xpath = document.CreateNavigator();
            tree = new TreeNode();
            tree.Text = xpath.NodeType.ToString();
            pathTreeViewer.Nodes.Add(tree);
            pathTreeViewer.ExpandAll();
            pathTreeViewer.Refresh();
            pathTreeViewer.SelectedNode = tree;
        }

        private void DetermineType(TreeNode node, XPathNavigator xPath)
        {
            if (xPath.NodeType == XPathNodeType.Element)
            {
                node.Text = xPath.Name.Trim();
                return;
            }
            node.Text = xPath.Value.Trim();
        }

        private void DisplayIterator(XPathNodeIterator iterator)
        {
            selectTreeResult.Text = "";

            while (iterator.MoveNext())
            {
                selectTreeResult.Text += $"{iterator.Current.Value.Trim()}\r\n";
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (!xpath.MoveToFirstChild())
            {
                MessageBox.Show(
                    "Current Node has no children.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TreeNode newTreeNode = new TreeNode();
            DetermineType(newTreeNode, xpath);

            tree.Nodes.Add(newTreeNode);
            tree = newTreeNode;

            pathTreeViewer.ExpandAll();
            pathTreeViewer.Refresh();
            pathTreeViewer.SelectedNode = tree;
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            if (!xpath.MoveToParent())
            {
                MessageBox.Show(
                    "Current Node has no parent.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tree = tree.Parent;
            int count = tree.GetNodeCount(false);
            tree.Nodes.Clear();

            pathTreeViewer.ExpandAll();
            pathTreeViewer.Refresh();
            pathTreeViewer.SelectedNode = tree;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!xpath.MoveToNext())
            {
                MessageBox.Show(
                    "Current node is last sibling.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TreeNode newTreeNode = tree.Parent;
            TreeNode newNode = new TreeNode();
            DetermineType(newNode, xpath);
            newTreeNode.Nodes.Add(newNode);
            tree = newNode;

            pathTreeViewer.ExpandAll();
            pathTreeViewer.Refresh();
            pathTreeViewer.SelectedNode = tree;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!xpath.MoveToPrevious())
            {
                MessageBox.Show(
                    "Current node is first sibling.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TreeNode parentTreeNode = tree.Parent;
            parentTreeNode.Nodes.Remove(tree);
            tree = parentTreeNode.LastNode;

            pathTreeViewer.ExpandAll();
            pathTreeViewer.Refresh();
            pathTreeViewer.SelectedNode = tree;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            XPathNodeIterator iterator;

            try
            {
                iterator = xpath.Select(selectTreeViewer.Text);
                DisplayIterator(iterator);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(
                    argumentException.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
