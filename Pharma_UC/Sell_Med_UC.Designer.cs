namespace DB_Project__PMS_.Pharma_UC
{
    partial class Sell_Med_UC
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

        #region Component Designer generated code

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxMedicines = new System.Windows.Forms.ListBox();
            this.searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medidlbl = new System.Windows.Forms.Label();
            this.expdatelbl = new System.Windows.Forms.Label();
            this.mednamelbl = new System.Windows.Forms.Label();
            this.addtocartbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customertxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.noofunittxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.companytxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formulatxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.purchasemeddatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_of_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalRSlbl = new System.Windows.Forms.Label();
            this.purchaseprintbtn = new Guna.UI2.WinForms.Guna2Button();
            this.removebtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.priceperunitlbl = new System.Windows.Forms.Label();
            this.totalpricetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasemeddatagrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxMedicines);
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 842);
            this.panel1.TabIndex = 0;
            // 
            // listBoxMedicines
            // 
            this.listBoxMedicines.BackColor = System.Drawing.Color.White;
            this.listBoxMedicines.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicines.ForeColor = System.Drawing.Color.Black;
            this.listBoxMedicines.FormattingEnabled = true;
            this.listBoxMedicines.ItemHeight = 30;
            this.listBoxMedicines.Location = new System.Drawing.Point(39, 330);
            this.listBoxMedicines.Name = "listBoxMedicines";
            this.listBoxMedicines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxMedicines.ScrollAlwaysVisible = true;
            this.listBoxMedicines.Size = new System.Drawing.Size(286, 424);
            this.listBoxMedicines.Sorted = true;
            this.listBoxMedicines.TabIndex = 3;
            this.listBoxMedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicines_SelectedIndexChanged);
            // 
            // searchtxt
            // 
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.DefaultText = "";
            this.searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.DisabledState.Parent = this.searchtxt;
            this.searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.FocusedState.Parent = this.searchtxt;
            this.searchtxt.ForeColor = System.Drawing.Color.Black;
            this.searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.HoverState.Parent = this.searchtxt;
            this.searchtxt.Location = new System.Drawing.Point(39, 260);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PlaceholderText = "";
            this.searchtxt.SelectedText = "";
            this.searchtxt.ShadowDecoration.Parent = this.searchtxt;
            this.searchtxt.Size = new System.Drawing.Size(286, 36);
            this.searchtxt.TabIndex = 21;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            this.searchtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search";
            // 
            // refreshbtn
            // 
            this.refreshbtn.CheckedState.Parent = this.refreshbtn;
            this.refreshbtn.CustomImages.Parent = this.refreshbtn;
            this.refreshbtn.FillColor = System.Drawing.Color.Transparent;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.HoverState.Parent = this.refreshbtn;
            this.refreshbtn.Image = global::DB_Project__PMS_.Properties.Resources.sync_64px;
            this.refreshbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.refreshbtn.Location = new System.Drawing.Point(323, 42);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(46, 42);
            this.refreshbtn.TabIndex = 0;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(302, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sell Medicine";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.priceperunitlbl);
            this.panel2.Controls.Add(this.medidlbl);
            this.panel2.Controls.Add(this.expdatelbl);
            this.panel2.Controls.Add(this.mednamelbl);
            this.panel2.Controls.Add(this.addtocartbtn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.customertxt);
            this.panel2.Controls.Add(this.totalpricetxt);
            this.panel2.Controls.Add(this.noofunittxt);
            this.panel2.Controls.Add(this.companytxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.formulatxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(399, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 483);
            this.panel2.TabIndex = 0;
            // 
            // medidlbl
            // 
            this.medidlbl.BackColor = System.Drawing.SystemColors.Control;
            this.medidlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medidlbl.Location = new System.Drawing.Point(78, 226);
            this.medidlbl.Name = "medidlbl";
            this.medidlbl.Size = new System.Drawing.Size(350, 36);
            this.medidlbl.TabIndex = 15;
            this.medidlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expdatelbl
            // 
            this.expdatelbl.BackColor = System.Drawing.SystemColors.Control;
            this.expdatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expdatelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expdatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdatelbl.Location = new System.Drawing.Point(78, 389);
            this.expdatelbl.Name = "expdatelbl";
            this.expdatelbl.Size = new System.Drawing.Size(350, 36);
            this.expdatelbl.TabIndex = 44;
            this.expdatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mednamelbl
            // 
            this.mednamelbl.BackColor = System.Drawing.SystemColors.Control;
            this.mednamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mednamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednamelbl.Location = new System.Drawing.Point(78, 307);
            this.mednamelbl.Name = "mednamelbl";
            this.mednamelbl.Size = new System.Drawing.Size(350, 36);
            this.mednamelbl.TabIndex = 44;
            this.mednamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addtocartbtn
            // 
            this.addtocartbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addtocartbtn.BorderRadius = 12;
            this.addtocartbtn.BorderThickness = 1;
            this.addtocartbtn.CheckedState.Parent = this.addtocartbtn;
            this.addtocartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtocartbtn.CustomImages.Parent = this.addtocartbtn;
            this.addtocartbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.addtocartbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartbtn.ForeColor = System.Drawing.Color.White;
            this.addtocartbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.addtocartbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addtocartbtn.HoverState.Parent = this.addtocartbtn;
            this.addtocartbtn.Image = global::DB_Project__PMS_.Properties.Resources.add_to_cart_40px;
            this.addtocartbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.addtocartbtn.Location = new System.Drawing.Point(690, 420);
            this.addtocartbtn.Name = "addtocartbtn";
            this.addtocartbtn.ShadowDecoration.Parent = this.addtocartbtn;
            this.addtocartbtn.Size = new System.Drawing.Size(188, 42);
            this.addtocartbtn.TabIndex = 2;
            this.addtocartbtn.Text = "Add To Cart";
            this.addtocartbtn.Click += new System.EventHandler(this.addtocartbtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel5.Location = new System.Drawing.Point(503, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 325);
            this.panel5.TabIndex = 40;
            // 
            // customertxt
            // 
            this.customertxt.BorderColor = System.Drawing.Color.Black;
            this.customertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customertxt.DefaultText = "";
            this.customertxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customertxt.DisabledState.Parent = this.customertxt;
            this.customertxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customertxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customertxt.FocusedState.Parent = this.customertxt;
            this.customertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertxt.ForeColor = System.Drawing.Color.Black;
            this.customertxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customertxt.HoverState.Parent = this.customertxt;
            this.customertxt.Location = new System.Drawing.Point(78, 142);
            this.customertxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customertxt.Name = "customertxt";
            this.customertxt.PasswordChar = '\0';
            this.customertxt.PlaceholderText = "";
            this.customertxt.SelectedText = "";
            this.customertxt.ShadowDecoration.Parent = this.customertxt;
            this.customertxt.Size = new System.Drawing.Size(346, 36);
            this.customertxt.TabIndex = 0;
            this.customertxt.TextChanged += new System.EventHandler(this.customernametxt_TextChanged);
            this.customertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customertxt_KeyPress);
            // 
            // noofunittxt
            // 
            this.noofunittxt.BorderColor = System.Drawing.Color.Black;
            this.noofunittxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noofunittxt.DefaultText = "";
            this.noofunittxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.noofunittxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.noofunittxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noofunittxt.DisabledState.Parent = this.noofunittxt;
            this.noofunittxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noofunittxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noofunittxt.FocusedState.Parent = this.noofunittxt;
            this.noofunittxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofunittxt.ForeColor = System.Drawing.Color.Black;
            this.noofunittxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noofunittxt.HoverState.Parent = this.noofunittxt;
            this.noofunittxt.Location = new System.Drawing.Point(587, 226);
            this.noofunittxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.noofunittxt.Name = "noofunittxt";
            this.noofunittxt.PasswordChar = '\0';
            this.noofunittxt.PlaceholderText = "";
            this.noofunittxt.SelectedText = "";
            this.noofunittxt.ShadowDecoration.Parent = this.noofunittxt;
            this.noofunittxt.Size = new System.Drawing.Size(346, 36);
            this.noofunittxt.TabIndex = 1;
            this.noofunittxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noofunittxt.TextChanged += new System.EventHandler(this.noofunittxt_TextChanged);
            this.noofunittxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noofunittxt_KeyPress);
            // 
            // companytxt
            // 
            this.companytxt.AutoSize = true;
            this.companytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companytxt.Location = new System.Drawing.Point(73, 357);
            this.companytxt.Name = "companytxt";
            this.companytxt.Size = new System.Drawing.Size(113, 25);
            this.companytxt.TabIndex = 39;
            this.companytxt.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(582, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Price Per Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(73, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Customer Name";
            // 
            // formulatxt
            // 
            this.formulatxt.AutoSize = true;
            this.formulatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formulatxt.Location = new System.Drawing.Point(73, 275);
            this.formulatxt.Name = "formulatxt";
            this.formulatxt.Size = new System.Drawing.Size(148, 25);
            this.formulatxt.TabIndex = 37;
            this.formulatxt.Text = "Medicine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(578, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(581, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "No of Units";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametxt.Location = new System.Drawing.Point(73, 193);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(115, 25);
            this.nametxt.TabIndex = 34;
            this.nametxt.Text = "Medicine ID";
            // 
            // purchasemeddatagrid
            // 
            this.purchasemeddatagrid.AllowUserToAddRows = false;
            this.purchasemeddatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.purchasemeddatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchasemeddatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasemeddatagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.purchasemeddatagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchasemeddatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchasemeddatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchasemeddatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchasemeddatagrid.ColumnHeadersHeight = 25;
            this.purchasemeddatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Med_Name,
            this.Unit_Price,
            this.No_of_Unit,
            this.Total_Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasemeddatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchasemeddatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasemeddatagrid.EnableHeadersVisualStyles = false;
            this.purchasemeddatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchasemeddatagrid.Location = new System.Drawing.Point(0, 0);
            this.purchasemeddatagrid.Name = "purchasemeddatagrid";
            this.purchasemeddatagrid.ReadOnly = true;
            this.purchasemeddatagrid.RowHeadersVisible = false;
            this.purchasemeddatagrid.RowHeadersWidth = 62;
            this.purchasemeddatagrid.RowTemplate.Height = 28;
            this.purchasemeddatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasemeddatagrid.Size = new System.Drawing.Size(868, 256);
            this.purchasemeddatagrid.TabIndex = 0;
            this.purchasemeddatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.purchasemeddatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchasemeddatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.purchasemeddatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.purchasemeddatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.purchasemeddatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.purchasemeddatagrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purchasemeddatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchasemeddatagrid.ThemeStyle.HeaderStyle.Height = 25;
            this.purchasemeddatagrid.ThemeStyle.ReadOnly = true;
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.Height = 28;
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchasemeddatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchasemeddatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasemeddatagrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Customer Name";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Med_Name
            // 
            this.Med_Name.HeaderText = "Med Name";
            this.Med_Name.MinimumWidth = 8;
            this.Med_Name.Name = "Med_Name";
            this.Med_Name.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.MinimumWidth = 8;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // No_of_Unit
            // 
            this.No_of_Unit.HeaderText = "No of Unit";
            this.No_of_Unit.MinimumWidth = 8;
            this.No_of_Unit.Name = "No_of_Unit";
            this.No_of_Unit.ReadOnly = true;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.MinimumWidth = 8;
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalRSlbl);
            this.panel3.Controls.Add(this.purchaseprintbtn);
            this.panel3.Controls.Add(this.removebtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(399, 739);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 103);
            this.panel3.TabIndex = 0;
            // 
            // totalRSlbl
            // 
            this.totalRSlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.totalRSlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRSlbl.Location = new System.Drawing.Point(435, 6);
            this.totalRSlbl.Name = "totalRSlbl";
            this.totalRSlbl.Size = new System.Drawing.Size(145, 51);
            this.totalRSlbl.TabIndex = 43;
            this.totalRSlbl.Text = "Rs. 00";
            this.totalRSlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchaseprintbtn
            // 
            this.purchaseprintbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseprintbtn.BorderRadius = 12;
            this.purchaseprintbtn.BorderThickness = 1;
            this.purchaseprintbtn.CheckedState.Parent = this.purchaseprintbtn;
            this.purchaseprintbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseprintbtn.CustomImages.Parent = this.purchaseprintbtn;
            this.purchaseprintbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.purchaseprintbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseprintbtn.ForeColor = System.Drawing.Color.White;
            this.purchaseprintbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.purchaseprintbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.purchaseprintbtn.HoverState.Parent = this.purchaseprintbtn;
            this.purchaseprintbtn.Image = global::DB_Project__PMS_.Properties.Resources.purchase_40px;
            this.purchaseprintbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.purchaseprintbtn.Location = new System.Drawing.Point(643, 6);
            this.purchaseprintbtn.Name = "purchaseprintbtn";
            this.purchaseprintbtn.ShadowDecoration.Parent = this.purchaseprintbtn;
            this.purchaseprintbtn.Size = new System.Drawing.Size(235, 51);
            this.purchaseprintbtn.TabIndex = 0;
            this.purchaseprintbtn.Text = "Purchase & Print";
            this.purchaseprintbtn.Click += new System.EventHandler(this.purchaseprintbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.BorderRadius = 12;
            this.removebtn.BorderThickness = 1;
            this.removebtn.CheckedState.Parent = this.removebtn;
            this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebtn.CustomImages.Parent = this.removebtn;
            this.removebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.HoverState.FillColor = System.Drawing.Color.White;
            this.removebtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.removebtn.HoverState.Parent = this.removebtn;
            this.removebtn.Image = global::DB_Project__PMS_.Properties.Resources.remove_64px;
            this.removebtn.ImageSize = new System.Drawing.Size(25, 25);
            this.removebtn.Location = new System.Drawing.Point(10, 6);
            this.removebtn.Name = "removebtn";
            this.removebtn.ShadowDecoration.Parent = this.removebtn;
            this.removebtn.Size = new System.Drawing.Size(188, 51);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "Remove";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(399, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 256);
            this.panel6.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1277, 483);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(91, 256);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.purchasemeddatagrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(409, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 256);
            this.panel4.TabIndex = 8;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // priceperunitlbl
            // 
            this.priceperunitlbl.BackColor = System.Drawing.SystemColors.Control;
            this.priceperunitlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceperunitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceperunitlbl.Location = new System.Drawing.Point(587, 142);
            this.priceperunitlbl.Name = "priceperunitlbl";
            this.priceperunitlbl.Size = new System.Drawing.Size(350, 36);
            this.priceperunitlbl.TabIndex = 44;
            this.priceperunitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalpricetxt
            // 
            this.totalpricetxt.BorderColor = System.Drawing.Color.Black;
            this.totalpricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalpricetxt.DefaultText = "";
            this.totalpricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalpricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalpricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalpricetxt.DisabledState.Parent = this.totalpricetxt;
            this.totalpricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalpricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalpricetxt.FocusedState.Parent = this.totalpricetxt;
            this.totalpricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricetxt.ForeColor = System.Drawing.Color.Black;
            this.totalpricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalpricetxt.HoverState.Parent = this.totalpricetxt;
            this.totalpricetxt.Location = new System.Drawing.Point(583, 307);
            this.totalpricetxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.totalpricetxt.Name = "totalpricetxt";
            this.totalpricetxt.PasswordChar = '\0';
            this.totalpricetxt.PlaceholderText = "";
            this.totalpricetxt.SelectedText = "";
            this.totalpricetxt.ShadowDecoration.Parent = this.totalpricetxt;
            this.totalpricetxt.Size = new System.Drawing.Size(346, 36);
            this.totalpricetxt.TabIndex = 1;
            this.totalpricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalpricetxt.TextChanged += new System.EventHandler(this.noofunittxt_TextChanged);
            this.totalpricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noofunittxt_KeyPress);
            // 
            // Sell_Med_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sell_Med_UC";
            this.Size = new System.Drawing.Size(1368, 842);
            this.Load += new System.EventHandler(this.Sell_Med_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasemeddatagrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMedicines;
        private Guna.UI2.WinForms.Guna2TextBox searchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView purchasemeddatagrid;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox noofunittxt;
        private System.Windows.Forms.Label companytxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label formulatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nametxt;
        private Guna.UI2.WinForms.Guna2Button addtocartbtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button purchaseprintbtn;
        private Guna.UI2.WinForms.Guna2Button removebtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label totalRSlbl;
        private System.Windows.Forms.Label mednamelbl;
        private System.Windows.Forms.Label medidlbl;
        private System.Windows.Forms.Label expdatelbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox customertxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.Label priceperunitlbl;
        private Guna.UI2.WinForms.Guna2TextBox totalpricetxt;
    }
}
