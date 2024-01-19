namespace DB_Project__PMS_.Supplier_UC
{
    partial class updatesup_UC
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
            this.resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addresstxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nictxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pendingamtxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.payedamtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uppayedamtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uptotalamtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalamlbl = new System.Windows.Forms.Label();
            this.pendingamlbl = new System.Windows.Forms.Label();
            this.payedamlbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sup_idtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.usererrorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetbtn
            // 
            this.resetbtn.BorderRadius = 12;
            this.resetbtn.BorderThickness = 1;
            this.resetbtn.CheckedState.Parent = this.resetbtn;
            this.resetbtn.CustomImages.Parent = this.resetbtn;
            this.resetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.resetbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.resetbtn.HoverState.Parent = this.resetbtn;
            this.resetbtn.Image = global::DB_Project__PMS_.Properties.Resources.reset_25px;
            this.resetbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.resetbtn.Location = new System.Drawing.Point(1016, 872);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.ShadowDecoration.Parent = this.resetbtn;
            this.resetbtn.Size = new System.Drawing.Size(180, 47);
            this.resetbtn.TabIndex = 47;
            this.resetbtn.Text = "Reset";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BorderRadius = 12;
            this.addbtn.BorderThickness = 1;
            this.addbtn.CheckedState.Parent = this.addbtn;
            this.addbtn.CustomImages.Parent = this.addbtn;
            this.addbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.addbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.addbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addbtn.HoverState.Parent = this.addbtn;
            this.addbtn.Image = global::DB_Project__PMS_.Properties.Resources.update_64px;
            this.addbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.addbtn.Location = new System.Drawing.Point(817, 872);
            this.addbtn.Name = "addbtn";
            this.addbtn.ShadowDecoration.Parent = this.addbtn;
            this.addbtn.Size = new System.Drawing.Size(180, 47);
            this.addbtn.TabIndex = 46;
            this.addbtn.Text = "Update";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstxt.DefaultText = "";
            this.addresstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstxt.DisabledState.Parent = this.addresstxt;
            this.addresstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstxt.FocusedState.Parent = this.addresstxt;
            this.addresstxt.ForeColor = System.Drawing.Color.Black;
            this.addresstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstxt.HoverState.Parent = this.addresstxt;
            this.addresstxt.Location = new System.Drawing.Point(265, 734);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.PasswordChar = '\0';
            this.addresstxt.PlaceholderText = "";
            this.addresstxt.SelectedText = "";
            this.addresstxt.ShadowDecoration.Parent = this.addresstxt;
            this.addresstxt.Size = new System.Drawing.Size(371, 45);
            this.addresstxt.TabIndex = 44;
            // 
            // nictxt
            // 
            this.nictxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nictxt.DefaultText = "";
            this.nictxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nictxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nictxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nictxt.DisabledState.Parent = this.nictxt;
            this.nictxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nictxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nictxt.FocusedState.Parent = this.nictxt;
            this.nictxt.ForeColor = System.Drawing.Color.Black;
            this.nictxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nictxt.HoverState.Parent = this.nictxt;
            this.nictxt.Location = new System.Drawing.Point(808, 313);
            this.nictxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nictxt.Name = "nictxt";
            this.nictxt.PasswordChar = '\0';
            this.nictxt.PlaceholderText = "";
            this.nictxt.SelectedText = "";
            this.nictxt.ShadowDecoration.Parent = this.nictxt;
            this.nictxt.Size = new System.Drawing.Size(371, 45);
            this.nictxt.TabIndex = 43;
            this.nictxt.TextChanged += new System.EventHandler(this.nictxt_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.DefaultText = "";
            this.nametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.DisabledState.Parent = this.nametxt;
            this.nametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.FocusedState.Parent = this.nametxt;
            this.nametxt.ForeColor = System.Drawing.Color.Black;
            this.nametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.HoverState.Parent = this.nametxt;
            this.nametxt.Location = new System.Drawing.Point(265, 436);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "";
            this.nametxt.SelectedText = "";
            this.nametxt.ShadowDecoration.Parent = this.nametxt;
            this.nametxt.Size = new System.Drawing.Size(371, 45);
            this.nametxt.TabIndex = 42;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            this.nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametxt_KeyPress);
            // 
            // phonetxt
            // 
            this.phonetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetxt.DefaultText = "";
            this.phonetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetxt.DisabledState.Parent = this.phonetxt;
            this.phonetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetxt.FocusedState.Parent = this.phonetxt;
            this.phonetxt.ForeColor = System.Drawing.Color.Black;
            this.phonetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetxt.HoverState.Parent = this.phonetxt;
            this.phonetxt.Location = new System.Drawing.Point(265, 573);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.PasswordChar = '\0';
            this.phonetxt.PlaceholderText = "";
            this.phonetxt.SelectedText = "";
            this.phonetxt.ShadowDecoration.Parent = this.phonetxt;
            this.phonetxt.Size = new System.Drawing.Size(371, 45);
            this.phonetxt.TabIndex = 41;
            this.phonetxt.TextChanged += new System.EventHandler(this.phonetxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(721, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 550);
            this.panel1.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(803, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone";
            // 
            // pendingamtxt
            // 
            this.pendingamtxt.AutoSize = true;
            this.pendingamtxt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingamtxt.Location = new System.Drawing.Point(803, 702);
            this.pendingamtxt.Name = "pendingamtxt";
            this.pendingamtxt.Size = new System.Drawing.Size(170, 27);
            this.pendingamtxt.TabIndex = 33;
            this.pendingamtxt.Text = "Pending Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name";
            // 
            // payedamtxt
            // 
            this.payedamtxt.AutoSize = true;
            this.payedamtxt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payedamtxt.Location = new System.Drawing.Point(812, 563);
            this.payedamtxt.Name = "payedamtxt";
            this.payedamtxt.Size = new System.Drawing.Size(152, 27);
            this.payedamtxt.TabIndex = 31;
            this.payedamtxt.Text = "Payed Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 43);
            this.label1.TabIndex = 30;
            this.label1.Text = "Update Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Add Amount:";
            // 
            // uppayedamtxt
            // 
            this.uppayedamtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uppayedamtxt.DefaultText = "";
            this.uppayedamtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uppayedamtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uppayedamtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uppayedamtxt.DisabledState.Parent = this.uppayedamtxt;
            this.uppayedamtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uppayedamtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uppayedamtxt.FocusedState.Parent = this.uppayedamtxt;
            this.uppayedamtxt.ForeColor = System.Drawing.Color.Black;
            this.uppayedamtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uppayedamtxt.HoverState.Parent = this.uppayedamtxt;
            this.uppayedamtxt.Location = new System.Drawing.Point(1095, 650);
            this.uppayedamtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uppayedamtxt.Name = "uppayedamtxt";
            this.uppayedamtxt.PasswordChar = '\0';
            this.uppayedamtxt.PlaceholderText = "0";
            this.uppayedamtxt.SelectedText = "";
            this.uppayedamtxt.ShadowDecoration.Parent = this.uppayedamtxt;
            this.uppayedamtxt.Size = new System.Drawing.Size(101, 42);
            this.uppayedamtxt.TabIndex = 51;
            this.uppayedamtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uppayedamtxt.TextChanged += new System.EventHandler(this.uppayedamtxt_TextChanged);
            this.uppayedamtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uppayedamtxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(976, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Add Amount:";
            // 
            // uptotalamtxt
            // 
            this.uptotalamtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uptotalamtxt.DefaultText = "";
            this.uptotalamtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uptotalamtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uptotalamtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uptotalamtxt.DisabledState.Parent = this.uptotalamtxt;
            this.uptotalamtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uptotalamtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uptotalamtxt.FocusedState.Parent = this.uptotalamtxt;
            this.uptotalamtxt.ForeColor = System.Drawing.Color.Black;
            this.uptotalamtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uptotalamtxt.HoverState.Parent = this.uptotalamtxt;
            this.uptotalamtxt.Location = new System.Drawing.Point(1091, 491);
            this.uptotalamtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uptotalamtxt.Name = "uptotalamtxt";
            this.uptotalamtxt.PasswordChar = '\0';
            this.uptotalamtxt.PlaceholderText = "0";
            this.uptotalamtxt.SelectedText = "";
            this.uptotalamtxt.ShadowDecoration.Parent = this.uptotalamtxt;
            this.uptotalamtxt.Size = new System.Drawing.Size(101, 42);
            this.uptotalamtxt.TabIndex = 51;
            this.uptotalamtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uptotalamtxt.TextChanged += new System.EventHandler(this.uptotalamtxt_TextChanged);
            this.uptotalamtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uptotalamtxt_KeyPress);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // totalamlbl
            // 
            this.totalamlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalamlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamlbl.Location = new System.Drawing.Point(808, 436);
            this.totalamlbl.Name = "totalamlbl";
            this.totalamlbl.Size = new System.Drawing.Size(383, 45);
            this.totalamlbl.TabIndex = 52;
            this.totalamlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pendingamlbl
            // 
            this.pendingamlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendingamlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingamlbl.Location = new System.Drawing.Point(808, 733);
            this.pendingamlbl.Name = "pendingamlbl";
            this.pendingamlbl.Size = new System.Drawing.Size(388, 45);
            this.pendingamlbl.TabIndex = 52;
            this.pendingamlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payedamlbl
            // 
            this.payedamlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payedamlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payedamlbl.Location = new System.Drawing.Point(813, 595);
            this.payedamlbl.Name = "payedamlbl";
            this.payedamlbl.Size = new System.Drawing.Size(383, 45);
            this.payedamlbl.TabIndex = 52;
            this.payedamlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 27);
            this.label10.TabIndex = 36;
            this.label10.Text = "Supplier ID";
            // 
            // sup_idtxt
            // 
            this.sup_idtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sup_idtxt.DefaultText = "";
            this.sup_idtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sup_idtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sup_idtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sup_idtxt.DisabledState.Parent = this.sup_idtxt;
            this.sup_idtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sup_idtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sup_idtxt.FocusedState.Parent = this.sup_idtxt;
            this.sup_idtxt.ForeColor = System.Drawing.Color.Black;
            this.sup_idtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sup_idtxt.HoverState.Parent = this.sup_idtxt;
            this.sup_idtxt.Location = new System.Drawing.Point(265, 313);
            this.sup_idtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sup_idtxt.Name = "sup_idtxt";
            this.sup_idtxt.PasswordChar = '\0';
            this.sup_idtxt.PlaceholderText = "";
            this.sup_idtxt.SelectedText = "";
            this.sup_idtxt.ShadowDecoration.Parent = this.sup_idtxt;
            this.sup_idtxt.Size = new System.Drawing.Size(224, 45);
            this.sup_idtxt.TabIndex = 43;
            this.sup_idtxt.TextChanged += new System.EventHandler(this.sup_idtxt_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BorderRadius = 12;
            this.searchbtn.BorderThickness = 1;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Image = global::DB_Project__PMS_.Properties.Resources.search_25px;
            this.searchbtn.Location = new System.Drawing.Point(497, 313);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(139, 45);
            this.searchbtn.TabIndex = 53;
            this.searchbtn.Text = "Search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // usererrorlbl
            // 
            this.usererrorlbl.AutoSize = true;
            this.usererrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.usererrorlbl.Location = new System.Drawing.Point(344, 363);
            this.usererrorlbl.Name = "usererrorlbl";
            this.usererrorlbl.Size = new System.Drawing.Size(145, 20);
            this.usererrorlbl.TabIndex = 54;
            this.usererrorlbl.Text = "*Only for Searching";
            // 
            // updatesup_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usererrorlbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.payedamlbl);
            this.Controls.Add(this.pendingamlbl);
            this.Controls.Add(this.totalamlbl);
            this.Controls.Add(this.uptotalamtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uppayedamtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.sup_idtxt);
            this.Controls.Add(this.nictxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pendingamtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.payedamtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updatesup_UC";
            this.Size = new System.Drawing.Size(1319, 961);
            this.Load += new System.EventHandler(this.updatesup_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private Guna.UI2.WinForms.Guna2TextBox addresstxt;
        private Guna.UI2.WinForms.Guna2TextBox nictxt;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
        private Guna.UI2.WinForms.Guna2TextBox phonetxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pendingamtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label payedamtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox uppayedamtxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox uptotalamtxt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label payedamlbl;
        private System.Windows.Forms.Label pendingamlbl;
        private System.Windows.Forms.Label totalamlbl;
        private Guna.UI2.WinForms.Guna2Button searchbtn;
        private Guna.UI2.WinForms.Guna2TextBox sup_idtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label usererrorlbl;
    }
}
