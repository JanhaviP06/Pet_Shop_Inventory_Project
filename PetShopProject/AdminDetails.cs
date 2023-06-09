using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject
{
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void AdminDetails_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayAdmin()
        {
            Con.Open();
            string Query = "Select * from Admin";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            NameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Admin(Name,Password,Phone) values(@N,@P,@PP)", Con);
                    cmd.Parameters.AddWithValue("@N", NameTb.Text);
                    cmd.Parameters.AddWithValue("@P", PassTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Added");
                    Con.Close();
                    DisplayAdmin();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Admin set Name=@N,Password=@P,Phone=@PP where Id=@CKey", Con);
                    cmd.Parameters.AddWithValue("@N", NameTb.Text);
                    cmd.Parameters.AddWithValue("@P", PassTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Updated !!");
                    Con.Close();
                    DisplayAdmin();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Admin!!");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Admin where Id=@CKey", Con);

                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted !!");
                    Con.Close();
                    DisplayAdmin();
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
            NameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PassTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AdminHome Obj = new AdminHome();
            Obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminDetails Obj = new AdminDetails();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction Obj = new Transaction();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayAdmin();
        }
    }
}
