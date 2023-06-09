using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            EmpNameLb1.Text = loginpage.emp;
        }



        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayCustomer()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            CustNameTb.Text = "";
            CustAddTb.Text = "";
            CustPhone.Text = "";
        }

        int Key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustName,CustAdd,CustPhone) values(@CN,@CA,@CP)", Con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added !!");
                    Con.Close();
                    DisplayCustomer();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            CustPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           
            if (CustNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhone.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName=@CN,CustAdd=@CA,CustPhone=@CP where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhone.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated !!");
                    Con.Close();
                    DisplayCustomer();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select A Customer !!");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustId=@CKey", Con);

                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted !!");
                    Con.Close();
                    DisplayCustomer();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pets Obj = new Pets();
            Obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                loginpage Obj = new loginpage();
                Obj.Show();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Bill Obj = new Bill();
            Obj.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category Obj = new Category();
            Obj.Show();
            this.Hide();
        }

        private void CustAddTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void DisplayCustomers()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

       

        
    }
}
