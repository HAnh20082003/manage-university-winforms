
namespace MangerUniversity
{
    partial class frmEnrollSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrollSubject));
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.fpnSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSubjectReLearn = new System.Windows.Forms.GroupBox();
            this.fpnSubjectReLearn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssignSubject = new System.Windows.Forms.Button();
            this.gbSubjectAssigned = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.fpnSubjectAssigned = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelAssignSubject = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrentCount = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblNameSubject = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSubject.SuspendLayout();
            this.gbSubjectReLearn.SuspendLayout();
            this.gbSubjectAssigned.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSubject
            // 
            this.gbSubject.BackColor = System.Drawing.Color.PaleVioletRed;
            this.gbSubject.Controls.Add(this.fpnSubject);
            this.gbSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubject.ForeColor = System.Drawing.Color.White;
            this.gbSubject.Location = new System.Drawing.Point(25, 78);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(547, 314);
            this.gbSubject.TabIndex = 0;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Môn học theo tiến trình";
            // 
            // fpnSubject
            // 
            this.fpnSubject.AutoScroll = true;
            this.fpnSubject.BackColor = System.Drawing.Color.LavenderBlush;
            this.fpnSubject.Location = new System.Drawing.Point(25, 29);
            this.fpnSubject.Name = "fpnSubject";
            this.fpnSubject.Size = new System.Drawing.Size(495, 261);
            this.fpnSubject.TabIndex = 0;
            // 
            // gbSubjectReLearn
            // 
            this.gbSubjectReLearn.BackColor = System.Drawing.Color.BlueViolet;
            this.gbSubjectReLearn.Controls.Add(this.fpnSubjectReLearn);
            this.gbSubjectReLearn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubjectReLearn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.gbSubjectReLearn.Location = new System.Drawing.Point(31, 414);
            this.gbSubjectReLearn.Name = "gbSubjectReLearn";
            this.gbSubjectReLearn.Size = new System.Drawing.Size(547, 330);
            this.gbSubjectReLearn.TabIndex = 1;
            this.gbSubjectReLearn.TabStop = false;
            this.gbSubjectReLearn.Text = "Môn học nợ";
            // 
            // fpnSubjectReLearn
            // 
            this.fpnSubjectReLearn.AutoScroll = true;
            this.fpnSubjectReLearn.BackColor = System.Drawing.Color.LavenderBlush;
            this.fpnSubjectReLearn.Location = new System.Drawing.Point(25, 29);
            this.fpnSubjectReLearn.Name = "fpnSubjectReLearn";
            this.fpnSubjectReLearn.Size = new System.Drawing.Size(495, 273);
            this.fpnSubjectReLearn.TabIndex = 1;
            // 
            // btnAssignSubject
            // 
            this.btnAssignSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAssignSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignSubject.Enabled = false;
            this.btnAssignSubject.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAssignSubject.FlatAppearance.BorderSize = 3;
            this.btnAssignSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAssignSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnAssignSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignSubject.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnAssignSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignSubject.Image")));
            this.btnAssignSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignSubject.Location = new System.Drawing.Point(396, 137);
            this.btnAssignSubject.Name = "btnAssignSubject";
            this.btnAssignSubject.Size = new System.Drawing.Size(140, 53);
            this.btnAssignSubject.TabIndex = 2;
            this.btnAssignSubject.Text = "Đăng ký";
            this.btnAssignSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignSubject.UseVisualStyleBackColor = false;
            this.btnAssignSubject.Click += new System.EventHandler(this.btnAssignSubject_Click);
            // 
            // gbSubjectAssigned
            // 
            this.gbSubjectAssigned.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbSubjectAssigned.Controls.Add(this.btnPrint);
            this.gbSubjectAssigned.Controls.Add(this.fpnSubjectAssigned);
            this.gbSubjectAssigned.Controls.Add(this.btnCancelAssignSubject);
            this.gbSubjectAssigned.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubjectAssigned.ForeColor = System.Drawing.Color.Yellow;
            this.gbSubjectAssigned.Location = new System.Drawing.Point(637, 414);
            this.gbSubjectAssigned.Name = "gbSubjectAssigned";
            this.gbSubjectAssigned.Size = new System.Drawing.Size(553, 330);
            this.gbSubjectAssigned.TabIndex = 2;
            this.gbSubjectAssigned.TabStop = false;
            this.gbSubjectAssigned.Text = "Môn học đã đăng ký";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.FlatAppearance.BorderSize = 3;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(229, 256);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 55);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fpnSubjectAssigned
            // 
            this.fpnSubjectAssigned.AutoScroll = true;
            this.fpnSubjectAssigned.BackColor = System.Drawing.Color.LavenderBlush;
            this.fpnSubjectAssigned.Location = new System.Drawing.Point(16, 29);
            this.fpnSubjectAssigned.Name = "fpnSubjectAssigned";
            this.fpnSubjectAssigned.Size = new System.Drawing.Size(511, 216);
            this.fpnSubjectAssigned.TabIndex = 2;
            // 
            // btnCancelAssignSubject
            // 
            this.btnCancelAssignSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelAssignSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAssignSubject.Enabled = false;
            this.btnCancelAssignSubject.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnCancelAssignSubject.FlatAppearance.BorderSize = 3;
            this.btnCancelAssignSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancelAssignSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCancelAssignSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAssignSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAssignSubject.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnCancelAssignSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAssignSubject.Image")));
            this.btnCancelAssignSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAssignSubject.Location = new System.Drawing.Point(16, 256);
            this.btnCancelAssignSubject.Name = "btnCancelAssignSubject";
            this.btnCancelAssignSubject.Size = new System.Drawing.Size(174, 55);
            this.btnCancelAssignSubject.TabIndex = 4;
            this.btnCancelAssignSubject.Text = "Huỷ đăng ký";
            this.btnCancelAssignSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAssignSubject.UseVisualStyleBackColor = false;
            this.btnCancelAssignSubject.Click += new System.EventHandler(this.btnCancelAssignSubject_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Black;
            this.gbInfo.Controls.Add(this.lblCurrentCount);
            this.gbInfo.Controls.Add(this.lblMaGV);
            this.gbInfo.Controls.Add(this.lblNameSubject);
            this.gbInfo.Controls.Add(this.lblMaLop);
            this.gbInfo.Controls.Add(this.btnAssignSubject);
            this.gbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.gbInfo.Location = new System.Drawing.Point(637, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(553, 202);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin môn học đang chọn";
            // 
            // lblCurrentCount
            // 
            this.lblCurrentCount.AutoSize = true;
            this.lblCurrentCount.ForeColor = System.Drawing.Color.Lavender;
            this.lblCurrentCount.Location = new System.Drawing.Point(27, 167);
            this.lblCurrentCount.Name = "lblCurrentCount";
            this.lblCurrentCount.Size = new System.Drawing.Size(116, 23);
            this.lblCurrentCount.TabIndex = 3;
            this.lblCurrentCount.Text = "Sỉ số hiện tại";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.ForeColor = System.Drawing.Color.Lavender;
            this.lblMaGV.Location = new System.Drawing.Point(27, 123);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(73, 23);
            this.lblMaGV.TabIndex = 2;
            this.lblMaGV.Text = "Mã GV";
            // 
            // lblNameSubject
            // 
            this.lblNameSubject.AutoSize = true;
            this.lblNameSubject.ForeColor = System.Drawing.Color.Lavender;
            this.lblNameSubject.Location = new System.Drawing.Point(27, 80);
            this.lblNameSubject.Name = "lblNameSubject";
            this.lblNameSubject.Size = new System.Drawing.Size(82, 23);
            this.lblNameSubject.TabIndex = 1;
            this.lblNameSubject.Text = "Tên môn";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.ForeColor = System.Drawing.Color.Lavender;
            this.lblMaLop.Location = new System.Drawing.Point(27, 35);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(69, 23);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(234, 21);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(151, 31);
            this.cbbHocKi.TabIndex = 8;
            this.cbbHocKi.SelectedIndexChanged += new System.EventHandler(this.cbbHocKi_SelectedIndexChanged);
            // 
            // cbbYear
            // 
            this.cbbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(31, 21);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(132, 31);
            this.cbbYear.TabIndex = 7;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmEnrollSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1234, 793);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbSubjectAssigned);
            this.Controls.Add(this.gbSubjectReLearn);
            this.Controls.Add(this.gbSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnrollSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký môn";
            this.gbSubject.ResumeLayout(false);
            this.gbSubjectReLearn.ResumeLayout(false);
            this.gbSubjectAssigned.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.GroupBox gbSubjectReLearn;
        private System.Windows.Forms.Button btnAssignSubject;
        private System.Windows.Forms.GroupBox gbSubjectAssigned;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblNameSubject;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblCurrentCount;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Button btnCancelAssignSubject;
        private System.Windows.Forms.FlowLayoutPanel fpnSubject;
        private System.Windows.Forms.FlowLayoutPanel fpnSubjectReLearn;
        private System.Windows.Forms.FlowLayoutPanel fpnSubjectAssigned;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
    }
}