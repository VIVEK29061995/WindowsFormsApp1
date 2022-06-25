using System;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // Directory Info class
        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = "D:\\SnQBatch1\\";  // or      @"D\SnQBatch"
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                MessageBox.Show("Folder is Already Exist");
            }
            else
            {
               di.Create();
                MessageBox.Show("Folder is Created");
            }
            MessageBox.Show(di.FullName);
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\SnQBatch1\Test1.txt";  // or  "D:\\SnQBatch\\Test.txt"   txt-> text file
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                MessageBox.Show("File Already Exist");
            }
            else
            {
                fi.Create();
                MessageBox.Show("File Created");
            }
            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int id=(Convert.ToInt32(txtID.Text));
                string name = txtName.Text;
                string location = txtLocation.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                string location = br.ReadString();
                txtID.Text = id.ToString();
                txtName.Text = name;
                txtLocation.Text = location;
                br.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
