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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CountDogs();
            CountCats();
            CountBirds();
            CountFish();
            Finance();
            EmpNameLb1.Text = loginpage.emp;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            EmpNameLb1.Text = loginpage.emp;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Pets Obj = new Pets();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CountDogs()
        {
            //string Cat = "Dog"; 
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(PQty) FROM PetTbl GROUP BY PCat HAVING PCat = 'Dog'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Dogslb1.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountCats()
        {
            //string Cat = "Dog";
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(PQty) FROM PetTbl GROUP BY PCat HAVING PCat = 'Cat'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Catlb.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountBirds()
        {
            //string Cat = "Dog";
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(PQty) FROM PetTbl GROUP BY PCat HAVING PCat = 'Bird'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Birdlb.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountFish()
        {
            
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(PQty) FROM PetTbl GROUP BY PCat HAVING PCat = 'Fish'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Fishlb.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Finance()
        {

            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(Amt) FROM BillTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Financelb.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

  

        private void button5_Click_1(object sender, EventArgs e)
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

        private void Birdlb_Click(object sender, EventArgs e)
        {

        }

        private void Dogslb1_Click(object sender, EventArgs e)
        {

        }
    }
}
