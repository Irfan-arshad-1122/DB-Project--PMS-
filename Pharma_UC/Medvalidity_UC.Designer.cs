namespace DB_Project__PMS_.Pharma_UC
{
    partial class Medvalidity_UC
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
            this.checktxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.medicinedatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinedatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checktxt);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.setlabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 273);
            this.panel1.TabIndex = 0;
            // 
            // checktxt
            // 
            this.checktxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checktxt.BackColor = System.Drawing.Color.Transparent;
            this.checktxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checktxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checktxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checktxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checktxt.FocusedState.Parent = this.checktxt;
            this.checktxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checktxt.ForeColor = System.Drawing.Color.Black;
            this.checktxt.HoverState.Parent = this.checktxt;
            this.checktxt.ItemHeight = 30;
            this.checktxt.Items.AddRange(new object[] {
            "Valid Medicines",
            "Expired Medicines"});
            this.checktxt.ItemsAppearance.Parent = this.checktxt;
            this.checktxt.Location = new System.Drawing.Point(811, 195);
            this.checktxt.Name = "checktxt";
            this.checktxt.ShadowDecoration.Parent = this.checktxt;
            this.checktxt.Size = new System.Drawing.Size(357, 36);
            this.checktxt.TabIndex = 17;
            this.checktxt.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            this.refreshbtn.Location = new System.Drawing.Point(364, 70);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(46, 42);
            this.refreshbtn.TabIndex = 16;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(344, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // setlabel
            // 
            this.setlabel.AutoSize = true;
            this.setlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlabel.Location = new System.Drawing.Point(131, 231);
            this.setlabel.Name = "setlabel";
            this.setlabel.Size = new System.Drawing.Size(162, 32);
            this.setlabel.TabIndex = 12;
            this.setlabel.Text = "All Medicines:";
            this.setlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(806, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Check:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Check Validity";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 643);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1307, 127);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1171, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 370);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 273);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(136, 370);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.medicinedatagridview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(136, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 370);
            this.panel3.TabIndex = 4;
            // 
            // medicinedatagridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.medicinedatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicinedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinedatagridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.medicinedatagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicinedatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicinedatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicinedatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicinedatagridview.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicinedatagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.medicinedatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinedatagridview.EnableHeadersVisualStyles = false;
            this.medicinedatagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagridview.Location = new System.Drawing.Point(0, 0);
            this.medicinedatagridview.Name = "medicinedatagridview";
            this.medicinedatagridview.RowHeadersVisible = false;
            this.medicinedatagridview.RowHeadersWidth = 62;
            this.medicinedatagridview.RowTemplate.Height = 28;
            this.medicinedatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicinedatagridview.Size = new System.Drawing.Size(1035, 370);
            this.medicinedatagridview.TabIndex = 0;
            this.medicinedatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.medicinedatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicinedatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicinedatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicinedatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicinedatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicinedatagridview.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.medicinedatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicinedatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicinedatagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicinedatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicinedatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicinedatagridview.ThemeStyle.HeaderStyle.Height = 25;
            this.medicinedatagridview.ThemeStyle.ReadOnly = false;
            this.medicinedatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicinedatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicinedatagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicinedatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicinedatagridview.ThemeStyle.RowsStyle.Height = 28;
            this.medicinedatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicinedatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Medvalidity_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Medvalidity_UC";
            this.Size = new System.Drawing.Size(1307, 770);
            this.Load += new System.EventHandler(this.Medvalidity_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinedatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView medicinedatagridview;
        private Guna.UI2.WinForms.Guna2ComboBox checktxt;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label setlabel;
    }
}
