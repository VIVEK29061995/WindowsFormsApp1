using System;
using System.Windows.Forms;
//add below namespace
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ado.NetDEMO
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form2()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetEmpData()
        {
            da = new SqlDataAdapter("select * from Emp",con);
            // add PK constraint to the col (id) which is in dataset
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //build the command for DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            //Fill() method fire the select query in DB & load data in dataset
            da.Fill(ds, "emp");// emp is the name given to the table which get loaded in the dataset
            return ds;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["emp"].NewRow();
                row["Name"] = txtEmpName.Text;
                row["Salary"] = txtEmpSalary.Text;
                ds.Tables["emp"].Rows.Add(row);
                // reflect the changes from dataset to DB
                int result = da.Update(ds.Tables["emp"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    row["Name"] = txtEmpName.Text;
                    row["Salary"] = txtEmpSalary.Text;
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                    else
                    {
                        MessageBox.Show("Id does not exist to update");

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    row.Delete();//delete the row from dataset
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    else
                    {
                        MessageBox.Show("unable to delete");

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["emp"];

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    txtEmpName.Text = row["Name"].ToString();
                    txtEmpSalary.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record does not exists");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
