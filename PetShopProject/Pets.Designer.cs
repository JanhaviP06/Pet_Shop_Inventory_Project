
namespace PetShopProject
{
    partial class Pets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PCat = new System.Windows.Forms.ComboBox();
            this.categoryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petShopDbDataSet1 = new PetShopProject.PetShopDbDataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.PQtyTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PPriceTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.petTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petShopDbDataSet2 = new PetShopProject.PetShopDbDataSet2();
            this.categoryTblTableAdapter = new PetShopProject.PetShopDbDataSet1TableAdapters.CategoryTblTableAdapter();
            this.petTblTableAdapter = new PetShopProject.PetShopDbDataSet2TableAdapters.PetTblTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.EmpNameLb1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-47, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "PETS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(227, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 573);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 234);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.PCat);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.PQtyTb);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.PPriceTb);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.PNameTb);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 317);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(790, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "RETRIVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PCat
            // 
            this.PCat.DataSource = this.categoryTblBindingSource;
            this.PCat.DisplayMember = "CatName";
            this.PCat.FormattingEnabled = true;
            this.PCat.Location = new System.Drawing.Point(295, 121);
            this.PCat.Name = "PCat";
            this.PCat.Size = new System.Drawing.Size(196, 31);
            this.PCat.TabIndex = 38;
            this.PCat.ValueMember = "CatName";
            // 
            // categoryTblBindingSource
            // 
            this.categoryTblBindingSource.DataMember = "CategoryTbl";
            this.categoryTblBindingSource.DataSource = this.petShopDbDataSet1;
            // 
            // petShopDbDataSet1
            // 
            this.petShopDbDataSet1.DataSetName = "PetShopDbDataSet1";
            this.petShopDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(291, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "CATEGORY";
            // 
            // PQtyTb
            // 
            this.PQtyTb.Location = new System.Drawing.Point(547, 121);
            this.PQtyTb.Name = "PQtyTb";
            this.PQtyTb.Size = new System.Drawing.Size(163, 32);
            this.PQtyTb.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(746, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 35;
            this.label13.Text = "PRICE";
            // 
            // PPriceTb
            // 
            this.PPriceTb.Location = new System.Drawing.Point(750, 121);
            this.PPriceTb.Name = "PPriceTb";
            this.PPriceTb.Size = new System.Drawing.Size(169, 32);
            this.PPriceTb.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(543, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 23);
            this.label12.TabIndex = 33;
            this.label12.Text = "QUANTITY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(831, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 23);
            this.label11.TabIndex = 32;
            // 
            // PNameTb
            // 
            this.PNameTb.Location = new System.Drawing.Point(29, 120);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(228, 32);
            this.PNameTb.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(25, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "NAME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(24, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 26);
            this.label14.TabIndex = 29;
            this.label14.Text = "PETS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(431, 283);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 28);
            this.label17.TabIndex = 24;
            this.label17.Text = "PETS LIST";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Salmon;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(384, 206);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(129, 41);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Salmon;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(612, 206);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(129, 41);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Salmon;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(151, 206);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 41);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // petTblBindingSource
            // 
            this.petTblBindingSource.DataMember = "PetTbl";
            this.petTblBindingSource.DataSource = this.petShopDbDataSet2;
            // 
            // petShopDbDataSet2
            // 
            this.petShopDbDataSet2.DataSetName = "PetShopDbDataSet2";
            this.petShopDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTblTableAdapter
            // 
            this.categoryTblTableAdapter.ClearBeforeFill = true;
            // 
            // petTblTableAdapter
            // 
            this.petTblTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.panellogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 658);
            this.panel4.TabIndex = 31;
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
            this.button11.Click += new System.EventHandler(this.button11_Click);
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
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::PetShopProject.Properties.Resources.invoice_8856__2_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 375);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 36;
            this.button3.Text = "CATEGORY";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::PetShopProject.Properties.Resources.home_2490;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 195);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(220, 60);
            this.button5.TabIndex = 27;
            this.button5.Text = "  HOME";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.EmpNameLb1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLb1.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpNameLb1.Location = new System.Drawing.Point(38, 154);
            this.EmpNameLb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLb1.Name = "EmpNameLb1";
            this.EmpNameLb1.Size = new System.Drawing.Size(125, 26);
            this.EmpNameLb1.TabIndex = 24;
            this.EmpNameLb1.Text = "EmpName";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 69);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(456, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETS DETAILS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Salmon;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(220, 640);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1056, 18);
            this.panel5.TabIndex = 43;
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1276, 658);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Pets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.Pets_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDbDataSet2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox PCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PQtyTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PPriceTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private PetShopDbDataSet1 petShopDbDataSet1;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
        private PetShopDbDataSet1TableAdapters.CategoryTblTableAdapter categoryTblTableAdapter;
        private PetShopDbDataSet2 petShopDbDataSet2;
        private System.Windows.Forms.BindingSource petTblBindingSource;
        private PetShopDbDataSet2TableAdapters.PetTblTableAdapter petTblTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label EmpNameLb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
    }
}