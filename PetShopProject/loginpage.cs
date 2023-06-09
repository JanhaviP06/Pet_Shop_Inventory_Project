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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }
        

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");
        public static string emp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UNameTb.Text.Trim()))
            {
                errorProvider1.SetError(UNameTb, "Username is required");
                return;
            }
            else
            {
                errorProvider1.SetError(UNameTb, string.Empty);
            }
            if (string.IsNullOrEmpty(PasswordTb.Text.Trim()))
            {
                errorProvider2.SetError(PasswordTb, "Password is required");
                return;
            }
            else
            {
                errorProvider2.SetError(PasswordTb, string.Empty);
            }
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter Details !!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl where EmpName='" + UNameTb.Text + "' and EmpPass='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home Obj = new Home();
                    Obj.Show();
                    this.Hide();
                    emp = UNameTb.Text;
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password !!");
                }
               
                Con.Close();
            }
        
    }

        private void Admin_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            Obj.Show();
            this.Hide();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}
