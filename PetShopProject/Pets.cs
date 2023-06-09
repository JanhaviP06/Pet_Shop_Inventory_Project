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
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
            EmpNameLb1.Text = loginpage.emp;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Pets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petShopDbDataSet2.PetTbl' table. You can move, or remove it, as needed.
            this.petTblTableAdapter.Fill(this.petShopDbDataSet2.PetTbl);
            // TODO: This line of code loads data into the 'petShopDbDataSet1.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.petShopDbDataSet1.CategoryTbl);

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayPets()
        {
            Con.Open();
            string Query = "Select * from PetTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PNameTb.Text = "";
            PQtyTb.Text = "";
            PCat.Text = "";
            PPriceTb.Text = "";
        }
        int Key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PCat.Text == "" || PQtyTb.Text == "" || PPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PetTbl(PName,PCat,PQty,PPrice) values(@PN,@PC,@PQ,@PP)", Con);
                    cmd.Parameters.AddWithValue("@PN", PNameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PCat.Text);
                    cmd.Parameters.AddWithValue("@PQ", PQtyTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PPriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Added !!");
                    Con.Close();
                    DisplayPets();
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

            PNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PCat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PQtyTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PPriceTb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (PNameTb.Text == "")
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
            if (PNameTb.Text == "" || PCat.Text == "" || PQtyTb.Text == "" || PPriceTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PetTbl set PName=@PN,PCat=@PC,PQty=@PQ,PPrice=@PP where PId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PNameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PCat.Text);
                    cmd.Parameters.AddWithValue("@PQ", PQtyTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Updated !!");
                    Con.Close();
                    DisplayPets();
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
                MessageBox.Show("Select A Pet !!");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PetTbl where PId=@PKey", Con);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Deleted !!");
                    Con.Close();
                    DisplayPets();
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
            DisplayPets();
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
