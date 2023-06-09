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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            DisplayTransaction();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayTransaction()
        {
            Con.Open();
            string Query = "Select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
