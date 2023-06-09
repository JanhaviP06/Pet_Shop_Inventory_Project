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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            EmpNameLb1.Text = loginpage.emp;
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayCategory()
        {
            Con.Open();
            string Query = "Select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
           // CatId.Text = "";
            CatName.Text = "";
        }
        int Key = 0;

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if ( CatName.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl(CatName) values( @CN)", Con);
                    //cmd.Parameters.AddWithValue("@CID", CatId.Text);
                    cmd.Parameters.AddWithValue("@CN", CatName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added !!");
                    Con.Close();
                    DisplayCategory();
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
           // CatId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CatName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            if (CatName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCategory();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if ( CatName.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName=@CN where CatId=@CKey", Con);
                   // cmd.Parameters.AddWithValue("@CID", CatId.Text);
                    cmd.Parameters.AddWithValue("@CN", CatName.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated !!");
                    Con.Close();
                    DisplayCategory();
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
                MessageBox.Show("Select A Category !!");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CategoryTbl where CatId=@CKey", Con);

                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted !!");
                    Con.Close();
                    DisplayCategory();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Category Obj = new Category();
            Obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bill Obj = new Bill();
            Obj.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
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
    }
}
