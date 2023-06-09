
namespace PetShopProject
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.petShopDbDataSet3 = new PetShopProject.PetShopDbDataSet3();
            this.bTblTableAdapter = new PetShopProject.PetShopDbDataSet3TableAdapters.BTblTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label17 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CustIdCb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Totallbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PrPriceTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pet = new System.Windows.Forms.TextBox();
            this.TotallTbl = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PrNameTb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.EmpNameLb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.panel8.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // petShopDbDataSet3
            // 
            this.petShopDbDataSet3.DataSetName = "PetShopDbDataSet3";
            this.petShopDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTblTableAdapter
            // 
            this.bTblTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(730, 312);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 23);
            this.label17.TabIndex = 31;
            this.label17.Text = "TOTAL BILL";
            // 
            // CustNameTb
            // 
            this.CustNameTb.Location = new System.Drawing.Point(290, 167);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(206, 32);
            this.CustNameTb.TabIndex = 19;
            // 
            // BillDGV
            // 
            this.BillDGV.AllowUserToAddRows = false;
            this.BillDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BillDGV.Location = new System.Drawing.Point(572, 347);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.ReadOnly = true;
            this.BillDGV.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.BillDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(425, 218);
            this.BillDGV.TabIndex = 30;
            this.BillDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDGV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bTblBindingSource
            // 
            this.bTblBindingSource.DataMember = "BTbl";
            this.bTblBindingSource.DataSource = this.petShopDbDataSet3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(17, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "CUSTOMER ID";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeight = 34;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(572, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(414, 187);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // CustIdCb
            // 
            this.CustIdCb.DisplayMember = "CustId";
            this.CustIdCb.FormattingEnabled = true;
            this.CustIdCb.Location = new System.Drawing.Point(21, 167);
            this.CustIdCb.Name = "CustIdCb";
            this.CustIdCb.Size = new System.Drawing.Size(147, 31);
            this.CustIdCb.TabIndex = 39;
            this.CustIdCb.ValueMember = "CustId";
            this.CustIdCb.SelectionChangeCommitted += new System.EventHandler(this.CustIdCb_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(723, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "PETS LIST";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(286, 132);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 23);
            this.label16.TabIndex = 18;
            this.label16.Text = "CUSTOMER NAME";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(678, 686);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 36);
            this.button4.TabIndex = 30;
            this.button4.Text = "SAVE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(814, 686);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Totallbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Totallbl.Location = new System.Drawing.Point(956, 693);
            this.Totallbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(30, 23);
            this.Totallbl.TabIndex = 28;
            this.Totallbl.Text = "Rs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "ADD TO BILL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(165, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "CUSTOMER";
            // 
            // PrPriceTb
            // 
            this.PrPriceTb.Location = new System.Drawing.Point(10, 382);
            this.PrPriceTb.Name = "PrPriceTb";
            this.PrPriceTb.Size = new System.Drawing.Size(206, 32);
            this.PrPriceTb.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 658);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Salmon;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1257, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(19, 571);
            this.panel6.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Salmon;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 640);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1276, 18);
            this.panel5.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 69);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILLING";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Pet);
            this.panel3.Controls.Add(this.TotallTbl);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.CustNameTb);
            this.panel3.Controls.Add(this.BillDGV);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.CustIdCb);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.Totallbl);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.PrPriceTb);
            this.panel3.Controls.Add(this.QtyTb);
            this.panel3.Controls.Add(this.ProductsDGV);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.PrNameTb);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(245, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 637);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(286, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "PET QUANTITY";
            // 
            // Pet
            // 
            this.Pet.Location = new System.Drawing.Point(290, 382);
            this.Pet.Name = "Pet";
            this.Pet.Size = new System.Drawing.Size(206, 32);
            this.Pet.TabIndex = 43;
            // 
            // TotallTbl
            // 
            this.TotallTbl.AutoSize = true;
            this.TotallTbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotallTbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotallTbl.Location = new System.Drawing.Point(873, 591);
            this.TotallTbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotallTbl.Name = "TotallTbl";
            this.TotallTbl.Size = new System.Drawing.Size(35, 26);
            this.TotallTbl.TabIndex = 42;
            this.TotallTbl.Text = "Rs";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Salmon;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(613, 584);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 36);
            this.button14.TabIndex = 41;
            this.button14.Text = "SAVE";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Salmon;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(741, 584);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 36);
            this.button13.TabIndex = 40;
            this.button13.Text = "PRINT";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(290, 303);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(206, 32);
            this.QtyTb.TabIndex = 10;
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductsDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.ProductsDGV.Location = new System.Drawing.Point(10, 515);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.ReadOnly = true;
            this.ProductsDGV.RowHeadersWidth = 62;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ProductsDGV.RowTemplate.Height = 28;
            this.ProductsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDGV.Size = new System.Drawing.Size(510, 105);
            this.ProductsDGV.TabIndex = 26;
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(198, 478);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "PRODUCTS LIST";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(286, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "PRODUCT QUANTITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "PRODUCT PRICE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(819, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 23);
            this.label15.TabIndex = 7;
            // 
            // PrNameTb
            // 
            this.PrNameTb.Location = new System.Drawing.Point(10, 303);
            this.PrNameTb.Name = "PrNameTb";
            this.PrNameTb.Size = new System.Drawing.Size(206, 32);
            this.PrNameTb.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(6, 262);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 23);
            this.label18.TabIndex = 5;
            this.label18.Text = "PRODUCT NAME";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(165, 220);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "PRODUCT";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.button8);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.button7);
            this.panel8.Controls.Add(this.button6);
            this.panel8.Controls.Add(this.button10);
            this.panel8.Controls.Add(this.panellogo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 658);
            this.panel8.TabIndex = 31;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Image = global::PetShopProject.Properties.Resources.exit_logout_2857__1_;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 555);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(220, 60);
            this.button11.TabIndex = 42;
            this.button11.Text = "  LOGOUT";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = global::PetShopProject.Properties.Resources.invoice_8856__2_;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 495);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(220, 60);
            this.button9.TabIndex = 41;
            this.button9.Text = "  BILLING";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Image = global::PetShopProject.Properties.Resources.user_3294__1_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 435);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(220, 60);
            this.button8.TabIndex = 40;
            this.button8.Text = "  CUSTOMERS";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::PetShopProject.Properties.Resources.invoice_8856__2_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 375);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(220, 60);
            this.button5.TabIndex = 36;
            this.button5.Text = "CATEGORY";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = global::PetShopProject.Properties.Resources.black_shopping_cart_10933__1_;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 315);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(220, 60);
            this.button7.TabIndex = 29;
            this.button7.Text = "  PRODUCTS";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::PetShopProject.Properties.Resources.dog_64701;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 255);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(220, 60);
            this.button6.TabIndex = 28;
            this.button6.Text = "  PETS";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Image = global::PetShopProject.Properties.Resources.home_2490;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 195);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(220, 60);
            this.button10.TabIndex = 27;
            this.button10.Text = "  HOME";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.button12);
            this.panellogo.Controls.Add(this.EmpNameLb1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 195);
            this.panellogo.TabIndex = 26;
            // 
            // button12
            // 
            this.button12.Image = global::PetShopProject.Properties.Resources._1;
            this.button12.Location = new System.Drawing.Point(27, 30);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(144, 114);
            this.button12.TabIndex = 25;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // EmpNameLb1
            // 
            this.EmpNameLb1.AutoSize = true;
            this.EmpNameLb1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.EmpNameLb1.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpNameLb1.Location = new System.Drawing.Point(38, 154);
            this.EmpNameLb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLb1.Name = "EmpNameLb1";
            this.EmpNameLb1.Size = new System.Drawing.Size(125, 26);
            this.EmpNameLb1.TabIndex = 24;
            this.EmpNameLb1.Text = "EmpName";
            this.EmpNameLb1.Click += new System.EventHandler(this.EmpNameLb1_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1276, 658);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PetShopDbDataSet3 petShopDbDataSet3;
        private PetShopDbDataSet3TableAdapters.BTblTableAdapter bTblTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource bTblBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox CustIdCb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrPriceTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PrNameTb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label TotallTbl;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label EmpNameLb1;
        private System.Windows.Forms.TextBox Pet;
        private System.Windows.Forms.Label label2;
    }
}