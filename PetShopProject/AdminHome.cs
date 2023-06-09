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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            CountDogs();
            CountCats();
            CountBirds();
            CountFish();
            Finance();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void CountDogs()
        {
            //string Cat = "Dog"; 
            Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PetTbl where PCat='" + Cat +"'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT SUM(PQty) FROM PetTbl GROUP BY PCat HAVING PCat = 'Dog'", Con);
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
    }
}
