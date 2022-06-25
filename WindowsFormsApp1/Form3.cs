using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd =new FontDialog();
            DialogResult result = fd.ShowDialog();
            if(DialogResult.OK == result)
            {
                richTextBox1.SelectionFont= fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            if (DialogResult.OK == result)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Do you want to Exit ?", "Warning",
               MessageBoxButtons.YesNo,MessageBoxIcon.Question/*Warning*/);
          if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = ".txt";
            sd.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf File(.pdf)|*.pdf";
            DialogResult result=sd.ShowDialog();
            if(result == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od=new OpenFileDialog();
            od.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf File(.pdf)|*.pdf|All Files|*.*";
            DialogResult result=od.ShowDialog();
            if( result == DialogResult.OK )
            {
                StreamReader sr = new StreamReader(od.FileName);
                richTextBox1.Text= sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
