
namespace MangerUniversity
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtPhone.Location = new System.Drawing.Point(176, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(245, 27);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Yellow;
            this.lblPhone.Location = new System.Drawing.Point(20, 67);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(114, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Xác minh SĐT";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAccept.FlatAppearance.BorderSize = 3;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(274, 280);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(147, 59);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.selectAccept);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Yellow;
            this.lblPass.Location = new System.Drawing.Point(20, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(111, 19);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Navy;
            this.txtNewPassword.Location = new System.Drawing.Point(176, 123);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(245, 27);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass.ForeColor = System.Drawing.Color.Yellow;
            this.lblRePass.Location = new System.Drawing.Point(20, 192);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(142, 19);
            this.lblRePass.TabIndex = 7;
            this.lblRePass.Text = "Nhập lại mật khẩu";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.ForeColor = System.Drawing.Color.Navy;
            this.txtRePassword.Location = new System.Drawing.Point(176, 188);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(245, 27);
            this.txtRePassword.TabIndex = 2;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.pictureBox1);
            this.gbInfo.Controls.Add(this.ckbShowPassword);
            this.gbInfo.Controls.Add(this.btnAccept);
            this.gbInfo.Controls.Add(this.lblPhone);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.txtNewPassword);
            this.gbInfo.Controls.Add(this.lblPass);
            this.gbInfo.Controls.Add(this.lblRePass);
            this.gbInfo.Controls.Add(this.txtRePassword);
            this.gbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.GhostWhite;
            this.gbInfo.Location = new System.Drawing.Point(24, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(594, 358);
            this.gbInfo.TabIndex = 10;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Quên mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShowPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPassword.ForeColor = System.Drawing.Color.Yellow;
            this.ckbShowPassword.Location = new System.Drawing.Point(283, 240);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(138, 23);
            this.ckbShowPassword.TabIndex = 11;
            this.ckbShowPassword.Text = "Hiện mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // frmForgotPassword
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(639, 386);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbShowPassword;
    }
}