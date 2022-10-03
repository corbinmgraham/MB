using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MB
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ValidateNames = true;
            of.Multiselect = false;
            of.Filter = "EMBEDDXL FILE | *.rtf";
            of.ShowDialog();
            String fileText = of.FileName;
            if (fileText != "")
            {
                richTextBox1.LoadFile(of.FileName);
                /* StreamReader sr = new StreamReader(fileText);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close(); */
            }
            else if (fileText == "")
            {
                MessageBox.Show("Loading", "File Not Found");
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 15;
            vScrollBar1.Value = 0;
        }
    }
}
