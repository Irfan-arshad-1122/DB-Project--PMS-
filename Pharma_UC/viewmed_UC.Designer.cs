namespace DB_Project__PMS_.Pharma_UC
{
    partial class viewmed_UC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mednametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicinedatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.printreport = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stocktxt = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedatagrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mednametxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 315);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // refreshbtn
            // 
            this.refreshbtn.CheckedState.Parent = this.refreshbtn;
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.CustomImages.Parent = this.refreshbtn;
            this.refreshbtn.FillColor = System.Drawing.Color.Transparent;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.HoverState.Parent = this.refreshbtn;
            this.refreshbtn.Image = global::DB_Project__PMS_.Properties.Resources.sync_64px;
            this.refreshbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.refreshbtn.Location = new System.Drawing.Point(394, 78);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(46, 42);
            this.refreshbtn.TabIndex = 10;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(374, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mednametxt
            // 
            this.mednametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mednametxt.DefaultText = "";
            this.mednametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mednametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mednametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mednametxt.DisabledState.Parent = this.mednametxt;
            this.mednametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mednametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mednametxt.FocusedState.Parent = this.mednametxt;
            this.mednametxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednametxt.ForeColor = System.Drawing.Color.Black;
            this.mednametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mednametxt.HoverState.Parent = this.mednametxt;
            this.mednametxt.Location = new System.Drawing.Point(239, 262);
            this.mednametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mednametxt.Name = "mednametxt";
            this.mednametxt.PasswordChar = '\0';
            this.mednametxt.PlaceholderText = "Search------------------";
            this.mednametxt.SelectedText = "";
            this.mednametxt.ShadowDecoration.Parent = this.mednametxt;
            this.mednametxt.Size = new System.Drawing.Size(300, 42);
            this.mednametxt.TabIndex = 3;
            this.mednametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mednametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Medicines";
            // 
            // medicinedatagrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.medicinedatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.medicinedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinedatagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.medicinedatagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicinedatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicinedatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicinedatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.medicinedatagrid.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicinedatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.medicinedatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinedatagrid.EnableHeadersVisualStyles = false;
            this.medicinedatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagrid.Location = new System.Drawing.Point(0, 0);
            this.medicinedatagrid.Name = "medicinedatagrid";
            this.medicinedatagrid.RowHeadersVisible = false;
            this.medicinedatagrid.RowHeadersWidth = 62;
            this.medicinedatagrid.RowTemplate.Height = 28;
            this.medicinedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicinedatagrid.Size = new System.Drawing.Size(843, 309);
            this.medicinedatagrid.TabIndex = 0;
            this.medicinedatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.medicinedatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicinedatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicinedatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicinedatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicinedatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicinedatagrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.medicinedatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicinedatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicinedatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicinedatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicinedatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicinedatagrid.ThemeStyle.HeaderStyle.Height = 25;
            this.medicinedatagrid.ThemeStyle.ReadOnly = false;
            this.medicinedatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicinedatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicinedatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicinedatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicinedatagrid.ThemeStyle.RowsStyle.Height = 28;
            this.medicinedatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicinedatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicinedatagrid_CellClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // printreport
            // 
            this.printreport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printreport.BorderRadius = 12;
            this.printreport.BorderThickness = 1;
            this.printreport.CheckedState.Parent = this.printreport;
            this.printreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printreport.CustomImages.Parent = this.printreport;
            this.printreport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.printreport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printreport.ForeColor = System.Drawing.Color.White;
            this.printreport.HoverState.FillColor = System.Drawing.Color.White;
            this.printreport.HoverState.ForeColor = System.Drawing.Color.Black;
            this.printreport.HoverState.Parent = this.printreport;
            this.printreport.Image = global::DB_Project__PMS_.Properties.Resources.save;
            this.printreport.Location = new System.Drawing.Point(906, 6);
            this.printreport.Name = "printreport";
            this.printreport.ShadowDecoration.Parent = this.printreport;
            this.printreport.Size = new System.Drawing.Size(176, 48);
            this.printreport.TabIndex = 5;
            this.printreport.Text = "Print Report";
            this.printreport.Click += new System.EventHandler(this.printreport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.amountlbl);
            this.panel2.Controls.Add(this.stocktxt);
            this.panel2.Controls.Add(this.printreport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 146);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 309);
            this.panel3.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1082, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 309);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.medicinedatagrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(239, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 309);
            this.panel4.TabIndex = 9;
            // 
            // stocktxt
            // 
            this.stocktxt.AutoSize = true;
            this.stocktxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stocktxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxt.Location = new System.Drawing.Point(548, 16);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(267, 38);
            this.stocktxt.TabIndex = 6;
            this.stocktxt.Text = "Stock Quantity: 000";
            this.stocktxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.amountlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(552, 69);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(258, 38);
            this.amountlbl.TabIndex = 6;
            this.amountlbl.Text = "Stock Amount: 000";
            this.amountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewmed_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "viewmed_UC";
            this.Size = new System.Drawing.Size(1308, 770);
            this.Load += new System.EventHandler(this.viewmed_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedatagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView medicinedatagrid;
        private Guna.UI2.WinForms.Guna2TextBox mednametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button printreport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label stocktxt;
        private System.Windows.Forms.Label amountlbl;
    }
}
