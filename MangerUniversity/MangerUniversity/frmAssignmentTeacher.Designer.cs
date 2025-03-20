
namespace MangerUniversity
{
    partial class frmAssignmentTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignmentTeacher));
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.gbMoreInfo = new System.Windows.Forms.GroupBox();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeach = new System.Windows.Forms.Button();
            this.lvTeachers = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAssignedSubject = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fpnAssignedSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbTeacher.SuspendLayout();
            this.gbMoreInfo.SuspendLayout();
            this.gbAssignedSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.gbMoreInfo);
            this.gbTeacher.Controls.Add(this.btnTeach);
            this.gbTeacher.Controls.Add(this.lvTeachers);
            this.gbTeacher.Enabled = false;
            this.gbTeacher.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeacher.ForeColor = System.Drawing.Color.Snow;
            this.gbTeacher.Location = new System.Drawing.Point(801, 133);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(424, 587);
            this.gbTeacher.TabIndex = 1;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Danh sách giảng viên";
            // 
            // gbMoreInfo
            // 
            this.gbMoreInfo.Controls.Add(this.txtMaxCount);
            this.gbMoreInfo.Controls.Add(this.label1);
            this.gbMoreInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoreInfo.ForeColor = System.Drawing.Color.Cyan;
            this.gbMoreInfo.Location = new System.Drawing.Point(20, 402);
            this.gbMoreInfo.Name = "gbMoreInfo";
            this.gbMoreInfo.Size = new System.Drawing.Size(292, 92);
            this.gbMoreInfo.TabIndex = 2;
            this.gbMoreInfo.TabStop = false;
            this.gbMoreInfo.Text = "Thông tin bổ sung";
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(159, 42);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(107, 27);
            this.txtMaxCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sỉ số lớp tối đa";
            // 
            // btnTeach
            // 
            this.btnTeach.BackColor = System.Drawing.Color.SlateGray;
            this.btnTeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeach.Enabled = false;
            this.btnTeach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTeach.FlatAppearance.BorderSize = 3;
            this.btnTeach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnTeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeach.Image = ((System.Drawing.Image)(resources.GetObject("btnTeach.Image")));
            this.btnTeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeach.Location = new System.Drawing.Point(20, 512);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(143, 54);
            this.btnTeach.TabIndex = 1;
            this.btnTeach.Text = "Phân công";
            this.btnTeach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeach.UseVisualStyleBackColor = false;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // lvTeachers
            // 
            this.lvTeachers.CheckBoxes = true;
            this.lvTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName});
            this.lvTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTeachers.FullRowSelect = true;
            this.lvTeachers.HideSelection = false;
            this.lvTeachers.Location = new System.Drawing.Point(20, 32);
            this.lvTeachers.Name = "lvTeachers";
            this.lvTeachers.Size = new System.Drawing.Size(383, 364);
            this.lvTeachers.TabIndex = 0;
            this.lvTeachers.UseCompatibleStateImageBehavior = false;
            this.lvTeachers.View = System.Windows.Forms.View.Details;
            this.lvTeachers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTeachers_ItemChecked);
            // 
            // chID
            // 
            this.chID.Text = "Mã GV";
            this.chID.Width = 98;
            // 
            // chName
            // 
            this.chName.Text = "Họ tên";
            this.chName.Width = 280;
            // 
            // gbAssignedSubject
            // 
            this.gbAssignedSubject.Controls.Add(this.btnCancel);
            this.gbAssignedSubject.Controls.Add(this.fpnAssignedSubject);
            this.gbAssignedSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAssignedSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAssignedSubject.Location = new System.Drawing.Point(16, 198);
            this.gbAssignedSubject.Name = "gbAssignedSubject";
            this.gbAssignedSubject.Size = new System.Drawing.Size(518, 583);
            this.gbAssignedSubject.TabIndex = 2;
            this.gbAssignedSubject.TabStop = false;
            this.gbAssignedSubject.Text = "Danh sách môn đã sắp";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(16, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 54);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ phân công";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fpnAssignedSubject
            // 
            this.fpnAssignedSubject.AutoScroll = true;
            this.fpnAssignedSubject.BackColor = System.Drawing.Color.FloralWhite;
            this.fpnAssignedSubject.Location = new System.Drawing.Point(16, 32);
            this.fpnAssignedSubject.Name = "fpnAssignedSubject";
            this.fpnAssignedSubject.Size = new System.Drawing.Size(482, 460);
            this.fpnAssignedSubject.TabIndex = 0;
            // 
            // cbbSubject
            // 
            this.cbbSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(821, 72);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(383, 27);
            this.cbbSubject.TabIndex = 3;
            this.cbbSubject.SelectedIndexChanged += new System.EventHandler(this.cbbSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(920, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách môn học";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(16, 66);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(266, 27);
            this.cbbKhoa.TabIndex = 5;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngành";
            // 
            // cbbMajor
            // 
            this.cbbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMajor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMajor.Enabled = false;
            this.cbbMajor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Location = new System.Drawing.Point(16, 154);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(266, 27);
            this.cbbMajor.TabIndex = 7;
            this.cbbMajor.SelectedIndexChanged += new System.EventHandler(this.cbbMajor_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmAssignmentTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1244, 803);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.gbAssignedSubject);
            this.Controls.Add(this.gbTeacher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAssignmentTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giảng dạy môn học";
            this.gbTeacher.ResumeLayout(false);
            this.gbMoreInfo.ResumeLayout(false);
            this.gbMoreInfo.PerformLayout();
            this.gbAssignedSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.ListView lvTeachers;
        private System.Windows.Forms.GroupBox gbAssignedSubject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel fpnAssignedSubject;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbMoreInfo;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}