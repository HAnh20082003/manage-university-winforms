
namespace MangerUniversity
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameAcct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSignIn
            // 
            this.gbSignIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbSignIn.Controls.Add(this.ckbShowPassword);
            this.gbSignIn.Controls.Add(this.label1);
            this.gbSignIn.Controls.Add(this.txtNameAcct);
            this.gbSignIn.Controls.Add(this.label2);
            this.gbSignIn.Controls.Add(this.txtPassword);
            this.gbSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignIn.ForeColor = System.Drawing.Color.Yellow;
            this.gbSignIn.Location = new System.Drawing.Point(31, 35);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(453, 220);
            this.gbSignIn.TabIndex = 0;
            this.gbSignIn.TabStop = false;
            this.gbSignIn.Text = "Đăng nhập";
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShowPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPassword.ForeColor = System.Drawing.Color.Lavender;
            this.ckbShowPassword.Location = new System.Drawing.Point(282, 175);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(138, 23);
            this.ckbShowPassword.TabIndex = 10;
            this.ckbShowPassword.Text = "Hiện mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên tài khoản";
            // 
            // txtNameAcct
            // 
            this.txtNameAcct.Location = new System.Drawing.Point(149, 51);
            this.txtNameAcct.Name = "txtNameAcct";
            this.txtNameAcct.Size = new System.Drawing.Size(271, 30);
            this.txtNameAcct.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Thistle;
            this.lblForgotPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblForgotPassword.Image")));
            this.lblForgotPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblForgotPassword.Location = new System.Drawing.Point(27, 270);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(183, 50);
            this.lblForgotPassword.TabIndex = 11;
            this.lblForgotPassword.Text = "Quên mật khẩu";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            this.lblForgotPassword.MouseLeave += new System.EventHandler(this.lblForgotPassword_MouseLeave);
            this.lblForgotPassword.MouseHover += new System.EventHandler(this.lblForgotPassword_MouseHover);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.MintCream;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSignIn.FlatAppearance.BorderSize = 3;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignIn.Location = new System.Drawing.Point(69, 338);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(121, 51);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.MintCream;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSignUp.FlatAppearance.BorderSize = 3;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.Location = new System.Drawing.Point(222, 338);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(121, 51);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.MintCream;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnChangePassword.FlatAppearance.BorderSize = 3;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangePassword.Location = new System.Drawing.Point(373, 338);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(121, 51);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(702, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.gbSignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameAcct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}