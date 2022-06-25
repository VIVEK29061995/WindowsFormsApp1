using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(txtName.Text);// RECENT NAME remove
           // listBox1.Items.Remove(listBox1.SelectedItem);//select name n delete
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
