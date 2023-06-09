using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PetShopProject
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
       

       SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void DisplayEmployees()
        {
            Con.Open();
            string Query= "Select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            PasswordTb.Text = "";

        }
        int Key = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                   
                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass,EmpSal,EmpJoin) values(@EN,@EA,@ED,@EP,@EPa,@ES,@EJ)",Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EPa",PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@ES", EmpSalary.Text);
                    cmd.Parameters.AddWithValue("@EJ", Empjoin.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    Con.Close();
                    DisplayEmployees();
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
            DisplayEmployees();
        }




        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (EmpNameTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTbl set EmpName=@EN,EmpAdd=@EA,EmpDOB=@ED,EmpPhone=@EP,EmpPass=@EPa,EmpSal=@ES,EmpJoin=@EJ where EmpNum=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@ES", EmpSalary.Text);
                    cmd.Parameters.AddWithValue("@EJ", Empjoin.Value.Date);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    Con.Close();
                    DisplayEmployees();
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
            if (Key==0)
            {
                MessageBox.Show("Select A Employee");
            }
            else
            {
                try
                {

                    // SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum=@EmpKey", Con);
                
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted !!");
                    Con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petShopDbDataSet.EmployeeTbl' table. You can move, or remove it, as needed.
            this.employeeTblTableAdapter.Fill(this.petShopDbDataSet.EmployeeTbl);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PasswordTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            EmpSalary.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Empjoin.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (EmpNameTb.Text == "")
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
    }
}


