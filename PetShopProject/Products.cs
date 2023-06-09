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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            EmpNameLb1.Text = loginpage.emp;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayProducts()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PrNameTb.Text = "";
            PrQtyTb.Text = "";
            PrCat.Text = "";
            PrPriceTb.Text = "";
            PrDate.Text = "";

        }
        int Key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrCat.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl(PrName,PrCat,PrQty,PrPrice,PrDate) values(@PN,@PC,@PQ,@PP,@PD)", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PrCat.Text);
                    cmd.Parameters.AddWithValue("@PQ", PrQtyTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PrDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added !!");
                    Con.Close();
                    DisplayProducts();
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
            PrNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PrCat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            PrQtyTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PrPriceTb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PrDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
          
            if (PrNameTb.Text == "")
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
            if (PrNameTb.Text == "" || PrCat.Text == "" || PrQtyTb.Text == "" || PrPriceTb.Text == "" || PrDate.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set PrName=@PN,PrCat=@PC,PrQty=@PQ,PrPrice=@PP,PrDate=@PD where PrId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PrCat.Text);
                    cmd.Parameters.AddWithValue("@PQ", PrQtyTb.Text);
                    cmd.Parameters.AddWithValue("@PP", PrPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PrDate.Value.Date);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated");
                    Con.Close();
                    DisplayProducts();
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
                MessageBox.Show("Select A Product !!");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PrId=@PKey", Con);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted !!");
                    Con.Close();
                    DisplayProducts();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void RetreiveBtn_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petShopDbDataSet1.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.petShopDbDataSet1.CategoryTbl);

        }

        
        private void button5_Click_1(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Pets Obj = new Pets();
            Obj.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
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

        private void button8_Click_1(object sender, EventArgs e)
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
