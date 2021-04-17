using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _18_7_XmlReaderTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlDocument document = new XmlDocument();
            document.Load("..\\..\\article.xml");
            XmlNodeReader reader = new XmlNodeReader(document);
            this.Show();
            int depth = -1;

            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        depth++;
                        TabOutput(depth);
                        txtOutput.Text += $"<{reader.Name}>\r\n";

                        if (reader.IsEmptyElement)
                        {
                            depth--;
                        }
                        break;
                    case XmlNodeType.Comment:
                        TabOutput(depth);
                        txtOutput.Text += $"<!--{reader.Value}-->\r\n";
                        break;
                    case XmlNodeType.Text:
                        TabOutput(depth);
                        txtOutput.Text += $"\t{reader.Value}\r\n";
                        break;
                    case XmlNodeType.XmlDeclaration:
                        TabOutput(depth);
                        txtOutput.Text += $"<?{reader.Name} {reader.Value} ?>\r\n";
                        break;
                    case XmlNodeType.EndElement:
                        TabOutput(depth);
                        txtOutput.Text += $"</{reader.Name}>\r\n";
                        depth--;
                        break;
                }
            }
        }
        private void TabOutput(int number)
        {
            for (int i = 0; i < number; i++)
            {
                txtOutput.Text += "\t";
            }
        }
    }
}
