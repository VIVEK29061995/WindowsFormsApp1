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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show("EmpID:"+txtEMPID.Text+"\n"+ "Emp Name:" +txtEMPNAME.Text+ "\n"+"SALARY:"+txtSALARY.Text+"\n"+ "DEPT NAME:" + txtDEPTNAME.Text );
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEMPID.Clear();
            txtEMPNAME.Clear();
            txtSALARY.Clear();
            txtDEPTNAME.Clear();
        }
    }
}
