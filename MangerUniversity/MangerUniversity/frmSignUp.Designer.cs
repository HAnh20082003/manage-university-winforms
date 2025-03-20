
namespace MangerUniversity
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.gbSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.gbInfoPerson = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbInfoAccount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.txtNameAcct = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSignUp.SuspendLayout();
            this.gbInfoPerson.SuspendLayout();
            this.gbInfoAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSignUp
            // 
            this.gbSignUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbSignUp.Controls.Add(this.btnSignUp);
            this.gbSignUp.Controls.Add(this.gbInfoPerson);
            this.gbSignUp.Controls.Add(this.gbInfoAccount);
            this.gbSignUp.Controls.Add(this.pictureBox1);
            this.gbSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignUp.ForeColor = System.Drawing.Color.Purple;
            this.gbSignUp.Location = new System.Drawing.Point(29, 19);
            this.gbSignUp.Name = "gbSignUp";
            this.gbSignUp.Size = new System.Drawing.Size(681, 750);
            this.gbSignUp.TabIndex = 0;
            this.gbSignUp.TabStop = false;
            this.gbSignUp.Text = "Đăng ký tài khoản quản trị";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Azure;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Location = new System.Drawing.Point(518, 350);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(144, 53);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // gbInfoPerson
            // 
            this.gbInfoPerson.Controls.Add(this.txtID);
            this.gbInfoPerson.Controls.Add(this.label9);
            this.gbInfoPerson.Controls.Add(this.dtpBirth);
            this.gbInfoPerson.Controls.Add(this.label8);
            this.gbInfoPerson.Controls.Add(this.txtAddress);
            this.gbInfoPerson.Controls.Add(this.label7);
            this.gbInfoPerson.Controls.Add(this.label4);
            this.gbInfoPerson.Controls.Add(this.txtName);
            this.gbInfoPerson.Controls.Add(this.txtPhone);
            this.gbInfoPerson.Controls.Add(this.txtEmail);
            this.gbInfoPerson.Controls.Add(this.label6);
            this.gbInfoPerson.Controls.Add(this.label5);
            this.gbInfoPerson.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbInfoPerson.Location = new System.Drawing.Point(25, 334);
            this.gbInfoPerson.Name = "gbInfoPerson";
            this.gbInfoPerson.Size = new System.Drawing.Size(474, 391);
            this.gbInfoPerson.TabIndex = 9;
            this.gbInfoPerson.TabStop = false;
            this.gbInfoPerson.Text = "Điền thông tin cá nhân";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(183, 329);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 30);
            this.txtID.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã ID";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(183, 101);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(271, 30);
            this.dtpBirth.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày sinh";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(183, 277);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 30);
            this.txtAddress.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ và tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(183, 165);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(271, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // gbInfoAccount
            // 
            this.gbInfoAccount.Controls.Add(this.label1);
            this.gbInfoAccount.Controls.Add(this.ckbShowPassword);
            this.gbInfoAccount.Controls.Add(this.txtNameAcct);
            this.gbInfoAccount.Controls.Add(this.txtRePassword);
            this.gbInfoAccount.Controls.Add(this.label2);
            this.gbInfoAccount.Controls.Add(this.label3);
            this.gbInfoAccount.Controls.Add(this.txtPassword);
            this.gbInfoAccount.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbInfoAccount.Location = new System.Drawing.Point(25, 52);
            this.gbInfoAccount.Name = "gbInfoAccount";
            this.gbInfoAccount.Size = new System.Drawing.Size(474, 266);
            this.gbInfoAccount.TabIndex = 8;
            this.gbInfoAccount.TabStop = false;
            this.gbInfoAccount.Text = "Điền thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPassword.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ckbShowPassword.Location = new System.Drawing.Point(283, 229);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(138, 23);
            this.ckbShowPassword.TabIndex = 15;
            this.ckbShowPassword.Text = "Hiện mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // txtNameAcct
            // 
            this.txtNameAcct.Location = new System.Drawing.Point(183, 45);
            this.txtNameAcct.Name = "txtNameAcct";
            this.txtNameAcct.Size = new System.Drawing.Size(271, 30);
            this.txtNameAcct.TabIndex = 0;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(183, 179);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(271, 30);
            this.txtRePassword.TabIndex = 2;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignUp
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 785);
            this.Controls.Add(this.gbSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.gbSignUp.ResumeLayout(false);
            this.gbInfoPerson.ResumeLayout(false);
            this.gbInfoPerson.PerformLayout();
            this.gbInfoAccount.ResumeLayout(false);
            this.gbInfoAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInfoAccount;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.TextBox txtNameAcct;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbInfoPerson;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}