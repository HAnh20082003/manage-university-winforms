
namespace MangerUniversity
{
    partial class frmManageSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSchool));
            this.ptrAvt = new System.Windows.Forms.PictureBox();
            this.pnOption = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.gbMoreInfo = new System.Windows.Forms.GroupBox();
            this.fpnMoreInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbMoreInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptrAvt
            // 
            this.ptrAvt.BackColor = System.Drawing.Color.Black;
            this.ptrAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrAvt.Location = new System.Drawing.Point(47, 93);
            this.ptrAvt.Name = "ptrAvt";
            this.ptrAvt.Size = new System.Drawing.Size(200, 200);
            this.ptrAvt.TabIndex = 0;
            this.ptrAvt.TabStop = false;
            // 
            // pnOption
            // 
            this.pnOption.AutoScroll = true;
            this.pnOption.Location = new System.Drawing.Point(47, 433);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(782, 300);
            this.pnOption.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(853, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpBirth);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Location = new System.Drawing.Point(281, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 259);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(38, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(38, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Location = new System.Drawing.Point(134, 151);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(278, 27);
            this.dtpBirth.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(134, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 27);
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(134, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(134, 21);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(278, 27);
            this.txtFullName.TabIndex = 5;
            // 
            // gbMoreInfo
            // 
            this.gbMoreInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.gbMoreInfo.Controls.Add(this.fpnMoreInfo);
            this.gbMoreInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoreInfo.ForeColor = System.Drawing.Color.Navy;
            this.gbMoreInfo.Location = new System.Drawing.Point(798, 93);
            this.gbMoreInfo.Name = "gbMoreInfo";
            this.gbMoreInfo.Size = new System.Drawing.Size(412, 256);
            this.gbMoreInfo.TabIndex = 10;
            this.gbMoreInfo.TabStop = false;
            this.gbMoreInfo.Text = "Thông tin bổ sung";
            // 
            // fpnMoreInfo
            // 
            this.fpnMoreInfo.Location = new System.Drawing.Point(14, 26);
            this.fpnMoreInfo.Name = "fpnMoreInfo";
            this.fpnMoreInfo.Size = new System.Drawing.Size(380, 207);
            this.fpnMoreInfo.TabIndex = 0;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.Lavender;
            this.btnSaveInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInfo.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnSaveInfo.FlatAppearance.BorderSize = 3;
            this.btnSaveInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInfo.Image")));
            this.btnSaveInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfo.Location = new System.Drawing.Point(661, 358);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(109, 55);
            this.btnSaveInfo.TabIndex = 7;
            this.btnSaveInfo.Text = "Lưu";
            this.btnSaveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.selectSaveInfo);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(47, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đổi ảnh đại diện";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectChangeAvt);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Lavender;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogOut.FlatAppearance.BorderSize = 3;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1050, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(160, 55);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmManageSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1233, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbMoreInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnOption);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.ptrAvt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hoạt động giảng dạy và học tập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageSchool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMoreInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrAvt;
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMoreInfo;
        private System.Windows.Forms.FlowLayoutPanel fpnMoreInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

