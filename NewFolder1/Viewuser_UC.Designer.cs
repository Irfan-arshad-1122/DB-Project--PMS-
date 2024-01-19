namespace DB_Project__PMS_.NewFolder1
{
    partial class Viewuser_UC
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
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.usernametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userdatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.usernametxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 318);
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
            this.refreshbtn.Location = new System.Drawing.Point(294, 71);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(42, 45);
            this.refreshbtn.TabIndex = 7;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(269, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.BorderRadius = 12;
            this.deletebtn.BorderThickness = 1;
            this.deletebtn.CheckedState.Parent = this.deletebtn;
            this.deletebtn.CustomImages.Parent = this.deletebtn;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.HoverState.Parent = this.deletebtn;
            this.deletebtn.Image = global::DB_Project__PMS_.Properties.Resources.remove_25px;
            this.deletebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deletebtn.Location = new System.Drawing.Point(1114, 261);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Parent = this.deletebtn;
            this.deletebtn.Size = new System.Drawing.Size(180, 45);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.DefaultText = "";
            this.usernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.DisabledState.Parent = this.usernametxt;
            this.usernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametxt.FocusedState.Parent = this.usernametxt;
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usernametxt.ForeColor = System.Drawing.Color.Black;
            this.usernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametxt.HoverState.Parent = this.usernametxt;
            this.usernametxt.Location = new System.Drawing.Point(108, 263);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.PlaceholderText = "Search-------------------------";
            this.usernametxt.SelectedText = "";
            this.usernametxt.ShadowDecoration.Parent = this.usernametxt;
            this.usernametxt.Size = new System.Drawing.Size(304, 43);
            this.usernametxt.TabIndex = 1;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "View User";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 678);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1411, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 360);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1303, 318);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(108, 360);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userdatagridview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(108, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1195, 360);
            this.panel3.TabIndex = 4;
            // 
            // userdatagridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userdatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userdatagridview.BackgroundColor = System.Drawing.Color.White;
            this.userdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userdatagridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userdatagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.userdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userdatagridview.EnableHeadersVisualStyles = false;
            this.userdatagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userdatagridview.Location = new System.Drawing.Point(0, 0);
            this.userdatagridview.Name = "userdatagridview";
            this.userdatagridview.RowHeadersVisible = false;
            this.userdatagridview.RowHeadersWidth = 62;
            this.userdatagridview.RowTemplate.Height = 28;
            this.userdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdatagridview.Size = new System.Drawing.Size(1195, 360);
            this.userdatagridview.TabIndex = 0;
            this.userdatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.userdatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userdatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userdatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userdatagridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userdatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userdatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userdatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.userdatagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userdatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userdatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userdatagridview.ThemeStyle.HeaderStyle.Height = 25;
            this.userdatagridview.ThemeStyle.ReadOnly = false;
            this.userdatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userdatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userdatagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userdatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userdatagridview.ThemeStyle.RowsStyle.Height = 28;
            this.userdatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userdatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdatagridview_CellClick);
            this.userdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdatagridview_CellContentClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Viewuser_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Viewuser_UC";
            this.Size = new System.Drawing.Size(1411, 778);
            this.Load += new System.EventHandler(this.Viewuser_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button deletebtn;
        private Guna.UI2.WinForms.Guna2TextBox usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView userdatagridview;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
