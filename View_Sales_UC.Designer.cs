namespace DB_Project__PMS_
{
    partial class View_Sales_UC
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
            this.searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.todatetxt = new System.Windows.Forms.DateTimePicker();
            this.fromdatetxt = new System.Windows.Forms.DateTimePicker();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printreport = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.salesdatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalincometxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.todatetxt);
            this.panel1.Controls.Add(this.fromdatetxt);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.setlabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 300);
            this.panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.BorderRadius = 12;
            this.searchbtn.BorderThickness = 1;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Image = global::DB_Project__PMS_.Properties.Resources.search_25px;
            this.searchbtn.Location = new System.Drawing.Point(968, 246);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(134, 48);
            this.searchbtn.TabIndex = 24;
            this.searchbtn.Text = "Search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // todatetxt
            // 
            this.todatetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.todatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todatetxt.Location = new System.Drawing.Point(762, 254);
            this.todatetxt.Name = "todatetxt";
            this.todatetxt.Size = new System.Drawing.Size(200, 30);
            this.todatetxt.TabIndex = 23;
            // 
            // fromdatetxt
            // 
            this.fromdatetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdatetxt.Location = new System.Drawing.Point(504, 254);
            this.fromdatetxt.Name = "fromdatetxt";
            this.fromdatetxt.Size = new System.Drawing.Size(200, 30);
            this.fromdatetxt.TabIndex = 23;
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
            this.refreshbtn.Location = new System.Drawing.Point(384, 77);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.PressedColor = System.Drawing.Color.White;
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(46, 42);
            this.refreshbtn.TabIndex = 22;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(356, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // setlabel
            // 
            this.setlabel.AutoSize = true;
            this.setlabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlabel.Location = new System.Drawing.Point(209, 248);
            this.setlabel.Name = "setlabel";
            this.setlabel.Size = new System.Drawing.Size(176, 38);
            this.setlabel.TabIndex = 19;
            this.setlabel.Text = "Sales Report:";
            this.setlabel.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "From:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sales Report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalincometxt);
            this.panel2.Controls.Add(this.printreport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 632);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 138);
            this.panel2.TabIndex = 0;
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
            this.printreport.Location = new System.Drawing.Point(940, 6);
            this.printreport.Name = "printreport";
            this.printreport.ShadowDecoration.Parent = this.printreport;
            this.printreport.Size = new System.Drawing.Size(162, 48);
            this.printreport.TabIndex = 0;
            this.printreport.Text = "Print Report";
            this.printreport.Click += new System.EventHandler(this.printreport_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 332);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1102, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 332);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.salesdatagridview);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(207, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(895, 332);
            this.panel5.TabIndex = 2;
            // 
            // salesdatagridview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.salesdatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.salesdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesdatagridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.salesdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesdatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.salesdatagridview.ColumnHeadersHeight = 25;
            this.salesdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesdatagridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.salesdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesdatagridview.EnableHeadersVisualStyles = false;
            this.salesdatagridview.GridColor = System.Drawing.Color.Silver;
            this.salesdatagridview.Location = new System.Drawing.Point(0, 0);
            this.salesdatagridview.Name = "salesdatagridview";
            this.salesdatagridview.ReadOnly = true;
            this.salesdatagridview.RowHeadersWidth = 62;
            this.salesdatagridview.RowTemplate.Height = 28;
            this.salesdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesdatagridview.Size = new System.Drawing.Size(895, 332);
            this.salesdatagridview.TabIndex = 0;
            this.salesdatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.salesdatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.salesdatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salesdatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salesdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salesdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salesdatagridview.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.salesdatagridview.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.salesdatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.salesdatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesdatagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.salesdatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesdatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesdatagridview.ThemeStyle.HeaderStyle.Height = 25;
            this.salesdatagridview.ThemeStyle.ReadOnly = true;
            this.salesdatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salesdatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesdatagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.salesdatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesdatagridview.ThemeStyle.RowsStyle.Height = 28;
            this.salesdatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesdatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // totalincometxt
            // 
            this.totalincometxt.AutoSize = true;
            this.totalincometxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.totalincometxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalincometxt.Location = new System.Drawing.Point(548, 16);
            this.totalincometxt.Name = "totalincometxt";
            this.totalincometxt.Size = new System.Drawing.Size(246, 38);
            this.totalincometxt.TabIndex = 1;
            this.totalincometxt.Text = "Total Income: 000";
            // 
            // View_Sales_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "View_Sales_UC";
            this.Size = new System.Drawing.Size(1390, 770);
            this.Load += new System.EventHandler(this.View_Sales_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label setlabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView salesdatagridview;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DateTimePicker todatetxt;
        private System.Windows.Forms.DateTimePicker fromdatetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button searchbtn;
        private Guna.UI2.WinForms.Guna2Button printreport;
        private System.Windows.Forms.Label totalincometxt;
    }
}
