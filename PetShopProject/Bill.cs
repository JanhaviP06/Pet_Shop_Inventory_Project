using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopProject
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            GetCustomers();
            GetCustName();
            EmpNameLb1.Text = loginpage.emp;
            DisplayProduct();
            DisplayPet();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\janha\OneDrive\Documents\PetShopDb.mdf;Integrated Security = True; Connect Timeout = 30");

        int Key = 0, Stock = 0;
        int Stock2 = 0;
        int n = 0, GrdTotal = 0;
        int prodid, prodqty, prodprice, tottal, pos = 60;
        private void GetCustomers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(dr);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            Con.Close();
        }
        private void DisplayProduct()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DisplayPet()
        {
            Con.Open();
            string Query = "Select * from PetTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void GetCustName()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl where CustId='" + CustIdCb.SelectedValue.ToString() + " ' ";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustName"].ToString();
            }
            Con.Close();
        }
        private void Updatestock()
        {
            try
            {
                int NewQty = Stock - Convert.ToInt32(QtyTb.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PrQty=@PQ where PrId=@PKey", Con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", Key);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Product Edited!!!");
                Con.Close();
                DisplayProduct();
                //Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void UpdatePets()
        {
            try
            {
                int NewQt = Stock2 - Convert.ToInt32(Pet.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update PetTbl set PQty=@PQ where PId=@PKey", Con);
                cmd.Parameters.AddWithValue("@PQ", NewQt);
                cmd.Parameters.AddWithValue("@PKey", Key);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Product Edited!!!");
                Con.Close();
                DisplayPet();
                //Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void InsertBill()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BillTbl (BDate, CustId, CustName,EmpName, Amt) values(@BD,@CI,@CN,@EN,@Am)", Con);

                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@CI", CustIdCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@EN", EmpNameLb1.Text);
                cmd.Parameters.AddWithValue("@Am", GrdTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Saved!!!");
                Con.Close();
                //  DisplayTransactions();
                //Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == ""  || Pet.Text == ""|| Key == 0)
            {
                MessageBox.Show("Missing Information !!");
            }
            else if (Convert.ToInt32(QtyTb.Text) > Stock || Convert.ToInt32(Pet.Text) > Stock2)
            {
                MessageBox.Show("Not Enough In House !!");
            }
            else if (Convert.ToInt32(QtyTb.Text) < Stock)
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PrPriceTb.Text);
                /* DataGridViewRow newRow = new DataGridViewRow();
                 newRow.CreateCells(BillDGV);
                 newRow.CellCount = 5;
                 newRow.Cells[0].Value = n + 1;
                 newRow.Cells[1].Value = PrNameTb.Text;
                 newRow.Cells[2].Value = QtyTb.Text;
                 newRow.Cells[3].Value = PrPriceTb.Text;
                 newRow.Cells[4].Value = total;
                 GrdTotal = GrdTotal + total;
                 BillDGV.Rows.Add(newRow);
                 n++;total; */

                int rowId = BillDGV.Rows.Add();
                DataGridViewRow row = BillDGV.Rows[rowId];
                row.Cells["Id"].Value = n + 1;
                row.Cells["Product"].Value = PrNameTb.Text;
                row.Cells["Price"].Value = PrPriceTb.Text;
                row.Cells["Quantity"].Value = QtyTb.Text;
                row.Cells["Total"].Value = total;
                n++;
                GrdTotal = GrdTotal + total;
                TotallTbl.Text = "RS" + GrdTotal;
                Updatestock();
               // UpdatePets();
                Reset();
            }
            else
            {
                int total = Convert.ToInt32(Pet.Text) * Convert.ToInt32(PrPriceTb.Text);
                int rowId = BillDGV.Rows.Add();
                DataGridViewRow row = BillDGV.Rows[rowId];
                row.Cells["Id"].Value = n + 1;
                row.Cells["Product"].Value = PrNameTb.Text;
                row.Cells["Price"].Value = PrPriceTb.Text;
                row.Cells["Quantity"].Value = Pet.Text;
                row.Cells["Total"].Value = total;
                n++;
                GrdTotal = GrdTotal + total;
                TotallTbl.Text = "RS" + GrdTotal;
                //Updatestock();
                UpdatePets();
                Reset();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            //Catcb.Text = ProductsDGV. SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            //Catcb.Text = ProductsDGV. SelectedRows[0].Cells[2].Value.ToString();
            Stock2 = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            InsertBill();
        }

     
        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button9_Click_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpNameLb1_Click(object sender, EventArgs e)
        {

        }

        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustName();
        }

        

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
          //  e.Graphics.DrawString("");
            e.Graphics.DrawString("Pets Paradise ", new Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, System.Drawing.FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Id"].Value);
                prodname = "" + row.Cells["Product"].Value;
                prodprice = Convert.ToInt32(row.Cells["Price"].Value);
                prodqty = Convert.ToInt32(row.Cells["Quantity"].Value);
                tottal = Convert.ToInt32(row.Cells["Total"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total : Rs" + GrdTotal, new Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("****************PetShop******************", new Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 600);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
       

        String prodname;
        private void Reset()
        {
            PrNameTb.Text = "";
            QtyTb.Text = "";
            Stock = 0;
            PrPriceTb.Text = "";
            Key = 0;
            Stock2 = 0;
            Pet.Text = "";
        }
        private void Billings_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }


    }
}
