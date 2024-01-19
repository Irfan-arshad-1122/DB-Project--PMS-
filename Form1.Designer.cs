namespace DB_Project__PMS_
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.signinbtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 750);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project__PMS_.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(39, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 210);
            this.label1.TabIndex = 0;
            this.label1.Text = "M.\r\n Abdullah\r\n  Pharmacy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.resetbtn);
            this.panel2.Controls.Add(this.signinbtn);
            this.panel2.Controls.Add(this.passwordtxt);
            this.panel2.Controls.Add(this.usernametxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.exitbtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(382, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 750);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(550, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Forgot Password";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // resetbtn
            // 
            this.resetbtn.BorderRadius = 12;
            this.resetbtn.BorderThickness = 1;
            this.resetbtn.CheckedState.Parent = this.resetbtn;
            this.resetbtn.CustomImages.Parent = this.resetbtn;
            this.resetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.resetbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.White;
            this.resetbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.resetbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.resetbtn.HoverState.Parent = this.resetbtn;
            this.resetbtn.Image = global::DB_Project__PMS_.Properties.Resources.reset_25px;
            this.resetbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.resetbtn.Location = new System.Drawing.Point(547, 567);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.ShadowDecoration.Parent = this.resetbtn;
            this.resetbtn.Size = new System.Drawing.Size(155, 50);
            this.resetbtn.TabIndex = 8;
            this.resetbtn.Text = "Reset";
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.BorderRadius = 12;
            this.signinbtn.BorderThickness = 1;
            this.signinbtn.CheckedState.Parent = this.signinbtn;
            this.signinbtn.CustomImages.Parent = this.signinbtn;
            this.signinbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.signinbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.ForeColor = System.Drawing.Color.White;
            this.signinbtn.HoverState.FillColor = System.Drawing.Color.White;
            this.signinbtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.signinbtn.HoverState.Parent = this.signinbtn;
            this.signinbtn.Image = global::DB_Project__PMS_.Properties.Resources.signin_100px;
            this.signinbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.signinbtn.Location = new System.Drawing.Point(352, 567);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.ShadowDecoration.Parent = this.signinbtn;
            this.signinbtn.Size = new System.Drawing.Size(155, 50);
            this.signinbtn.TabIndex = 2;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxt.DefaultText = "";
            this.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.DisabledState.Parent = this.passwordtxt;
            this.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.FocusedState.Parent = this.passwordtxt;
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.Color.Black;
            this.passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.HoverState.Parent = this.passwordtxt;
            this.passwordtxt.Location = new System.Drawing.Point(346, 448);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.PlaceholderText = "";
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.ShadowDecoration.Parent = this.passwordtxt;
            this.passwordtxt.Size = new System.Drawing.Size(350, 43);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.UseSystemPasswordChar = true;
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
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.Color.Black;
            this.usernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametxt.HoverState.Parent = this.usernametxt;
            this.usernametxt.Location = new System.Drawing.Point(346, 337);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.PlaceholderText = "";
            this.usernametxt.SelectedText = "";
            this.usernametxt.ShadowDecoration.Parent = this.usernametxt;
            this.usernametxt.Size = new System.Drawing.Size(350, 43);
            this.usernametxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sign In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DB_Project__PMS_.Properties.Resources.Untitled;
            this.pictureBox2.Location = new System.Drawing.Point(426, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.CheckedState.Parent = this.exitbtn;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.CustomImages.Parent = this.exitbtn;
            this.exitbtn.FillColor = System.Drawing.Color.Transparent;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.HoverState.Parent = this.exitbtn;
            this.exitbtn.Image = global::DB_Project__PMS_.Properties.Resources.Close_all_jframe;
            this.exitbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exitbtn.Location = new System.Drawing.Point(855, 12);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.ShadowDecoration.Parent = this.exitbtn;
            this.exitbtn.Size = new System.Drawing.Size(55, 52);
            this.exitbtn.TabIndex = 15;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel3.Location = new System.Drawing.Point(167, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 450);
            this.panel3.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Enter += new System.EventHandler(this.signinbtn_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button exitbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button resetbtn;
        private Guna.UI2.WinForms.Guna2Button signinbtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordtxt;
        private Guna.UI2.WinForms.Guna2TextBox usernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

