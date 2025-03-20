
namespace MangerUniversity
{
    partial class frmManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageStudent));
            this.lvMainClass = new System.Windows.Forms.ListView();
            this.chIDMain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameMain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthMain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSubjects = new System.Windows.Forms.GroupBox();
            this.fpnClassTeach = new System.Windows.Forms.FlowLayoutPanel();
            this.lvStudentLearn = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHocKi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbListStudent = new System.Windows.Forms.GroupBox();
            this.cbbStudent = new System.Windows.Forms.ComboBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMark = new System.Windows.Forms.GroupBox();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.cbbPercentKTHP = new System.Windows.Forms.ComboBox();
            this.cbbPercentKTDK = new System.Windows.Forms.ComboBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.txtKTHP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKTDK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKickStudent = new System.Windows.Forms.Button();
            this.gbSubjects.SuspendLayout();
            this.gbListStudent.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbMark.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMainClass
            // 
            this.lvMainClass.CheckBoxes = true;
            this.lvMainClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIDMain,
            this.chNameMain,
            this.chBirthMain});
            this.lvMainClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMainClass.FullRowSelect = true;
            this.lvMainClass.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMainClass.HideSelection = false;
            this.lvMainClass.Location = new System.Drawing.Point(27, 41);
            this.lvMainClass.Name = "lvMainClass";
            this.lvMainClass.Size = new System.Drawing.Size(426, 749);
            this.lvMainClass.TabIndex = 0;
            this.lvMainClass.UseCompatibleStateImageBehavior = false;
            this.lvMainClass.View = System.Windows.Forms.View.Details;
            this.lvMainClass.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvMainClass_ItemChecked);
            this.lvMainClass.SelectedIndexChanged += new System.EventHandler(this.lvMainClass_SelectedIndexChanged);
            // 
            // chIDMain
            // 
            this.chIDMain.Text = "Mã SV";
            this.chIDMain.Width = 82;
            // 
            // chNameMain
            // 
            this.chNameMain.Text = "Họ tên";
            this.chNameMain.Width = 202;
            // 
            // chBirthMain
            // 
            this.chBirthMain.Text = "Ngày sinh";
            this.chBirthMain.Width = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách lớp quản lý";
            // 
            // gbSubjects
            // 
            this.gbSubjects.Controls.Add(this.fpnClassTeach);
            this.gbSubjects.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubjects.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbSubjects.Location = new System.Drawing.Point(866, 41);
            this.gbSubjects.Name = "gbSubjects";
            this.gbSubjects.Size = new System.Drawing.Size(549, 376);
            this.gbSubjects.TabIndex = 2;
            this.gbSubjects.TabStop = false;
            this.gbSubjects.Text = "Danh sách lớp đang dạy";
            // 
            // fpnClassTeach
            // 
            this.fpnClassTeach.AutoScroll = true;
            this.fpnClassTeach.BackColor = System.Drawing.Color.LightGreen;
            this.fpnClassTeach.Location = new System.Drawing.Point(16, 37);
            this.fpnClassTeach.Name = "fpnClassTeach";
            this.fpnClassTeach.Size = new System.Drawing.Size(510, 299);
            this.fpnClassTeach.TabIndex = 0;
            // 
            // lvStudentLearn
            // 
            this.lvStudentLearn.CheckBoxes = true;
            this.lvStudentLearn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chHocKi,
            this.chYear});
            this.lvStudentLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStudentLearn.FullRowSelect = true;
            this.lvStudentLearn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudentLearn.HideSelection = false;
            this.lvStudentLearn.Location = new System.Drawing.Point(16, 59);
            this.lvStudentLearn.Name = "lvStudentLearn";
            this.lvStudentLearn.Size = new System.Drawing.Size(520, 333);
            this.lvStudentLearn.TabIndex = 3;
            this.lvStudentLearn.UseCompatibleStateImageBehavior = false;
            this.lvStudentLearn.View = System.Windows.Forms.View.Details;
            this.lvStudentLearn.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudentLearn_ItemChecked);
            this.lvStudentLearn.SelectedIndexChanged += new System.EventHandler(this.lvStudentLearn_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "Mã SV";
            this.chID.Width = 90;
            // 
            // chName
            // 
            this.chName.Text = "Họ tên";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 222;
            // 
            // chHocKi
            // 
            this.chHocKi.Text = "Học kì";
            this.chHocKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHocKi.Width = 102;
            // 
            // chYear
            // 
            this.chYear.Text = "Năm";
            this.chYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chYear.Width = 99;
            // 
            // gbListStudent
            // 
            this.gbListStudent.Controls.Add(this.cbbStudent);
            this.gbListStudent.Controls.Add(this.lvStudentLearn);
            this.gbListStudent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListStudent.ForeColor = System.Drawing.Color.Indigo;
            this.gbListStudent.Location = new System.Drawing.Point(866, 398);
            this.gbListStudent.Name = "gbListStudent";
            this.gbListStudent.Size = new System.Drawing.Size(549, 400);
            this.gbListStudent.TabIndex = 4;
            this.gbListStudent.TabStop = false;
            this.gbListStudent.Text = "Danh sách sinh viên tham gia môn";
            // 
            // cbbStudent
            // 
            this.cbbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStudent.FormattingEnabled = true;
            this.cbbStudent.Items.AddRange(new object[] {
            "Sinh viên hiện tại",
            "Sinh viên cũ"});
            this.cbbStudent.Location = new System.Drawing.Point(328, 22);
            this.cbbStudent.Name = "cbbStudent";
            this.cbbStudent.Size = new System.Drawing.Size(208, 27);
            this.cbbStudent.TabIndex = 4;
            this.cbbStudent.SelectedIndexChanged += new System.EventHandler(this.cbbStudent_SelectedIndexChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Lavender;
            this.gbInfo.Controls.Add(this.txtID);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtEmail);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.dtpBirth);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Enabled = false;
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbInfo.Location = new System.Drawing.Point(476, 41);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(384, 387);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin cá nhân";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(138, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(222, 27);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "SV-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(40, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã SV";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(138, 304);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(222, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(40, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(222, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(40, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Enabled = false;
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Location = new System.Drawing.Point(139, 161);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(222, 22);
            this.dtpBirth.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(138, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(222, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(40, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(41, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(138, 109);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(222, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // gbMark
            // 
            this.gbMark.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbMark.Controls.Add(this.btnDeleteMark);
            this.gbMark.Controls.Add(this.lblSum);
            this.gbMark.Controls.Add(this.cbbPercentKTHP);
            this.gbMark.Controls.Add(this.cbbPercentKTDK);
            this.gbMark.Controls.Add(this.btnMark);
            this.gbMark.Controls.Add(this.txtKTHP);
            this.gbMark.Controls.Add(this.label10);
            this.gbMark.Controls.Add(this.txtKTDK);
            this.gbMark.Controls.Add(this.label9);
            this.gbMark.Enabled = false;
            this.gbMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMark.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbMark.Location = new System.Drawing.Point(477, 528);
            this.gbMark.Name = "gbMark";
            this.gbMark.Size = new System.Drawing.Size(383, 262);
            this.gbMark.TabIndex = 6;
            this.gbMark.TabStop = false;
            this.gbMark.Text = "Chấm điểm";
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMark.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteMark.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMark.Image")));
            this.btnDeleteMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMark.Location = new System.Drawing.Point(205, 192);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(144, 53);
            this.btnDeleteMark.TabIndex = 23;
            this.btnDeleteMark.Text = "Xoá điểm";
            this.btnDeleteMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblSum.Location = new System.Drawing.Point(18, 145);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(120, 23);
            this.lblSum.TabIndex = 21;
            this.lblSum.Text = "Tổng điểm: 0";
            // 
            // cbbPercentKTHP
            // 
            this.cbbPercentKTHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPercentKTHP.FormattingEnabled = true;
            this.cbbPercentKTHP.Location = new System.Drawing.Point(290, 96);
            this.cbbPercentKTHP.Name = "cbbPercentKTHP";
            this.cbbPercentKTHP.Size = new System.Drawing.Size(69, 28);
            this.cbbPercentKTHP.TabIndex = 20;
            this.cbbPercentKTHP.SelectedIndexChanged += new System.EventHandler(this.changePercent_ComboBox);
            // 
            // cbbPercentKTDK
            // 
            this.cbbPercentKTDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPercentKTDK.FormattingEnabled = true;
            this.cbbPercentKTDK.Location = new System.Drawing.Point(290, 46);
            this.cbbPercentKTDK.Name = "cbbPercentKTDK";
            this.cbbPercentKTDK.Size = new System.Drawing.Size(69, 28);
            this.cbbPercentKTDK.TabIndex = 19;
            this.cbbPercentKTDK.SelectedIndexChanged += new System.EventHandler(this.changePercent_ComboBox);
            // 
            // btnMark
            // 
            this.btnMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMark.Image = ((System.Drawing.Image)(resources.GetObject("btnMark.Image")));
            this.btnMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMark.Location = new System.Drawing.Point(42, 192);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(142, 53);
            this.btnMark.TabIndex = 9;
            this.btnMark.Text = "Lưu điểm";
            this.btnMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // txtKTHP
            // 
            this.txtKTHP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtKTHP.Location = new System.Drawing.Point(115, 93);
            this.txtKTHP.Name = "txtKTHP";
            this.txtKTHP.Size = new System.Drawing.Size(125, 27);
            this.txtKTHP.TabIndex = 8;
            this.txtKTHP.TextChanged += new System.EventHandler(this.inputValueMark);
            this.txtKTHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressInputValueMark);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(17, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "KTHP";
            // 
            // txtKTDK
            // 
            this.txtKTDK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtKTDK.Location = new System.Drawing.Point(116, 46);
            this.txtKTDK.Name = "txtKTDK";
            this.txtKTDK.Size = new System.Drawing.Size(124, 27);
            this.txtKTDK.TabIndex = 7;
            this.txtKTDK.TextChanged += new System.EventHandler(this.inputValueMark);
            this.txtKTDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressInputValueMark);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(18, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "KTDK";
            // 
            // btnKickStudent
            // 
            this.btnKickStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKickStudent.Enabled = false;
            this.btnKickStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKickStudent.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnKickStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnKickStudent.Image")));
            this.btnKickStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKickStudent.Location = new System.Drawing.Point(477, 443);
            this.btnKickStudent.Name = "btnKickStudent";
            this.btnKickStudent.Size = new System.Drawing.Size(190, 53);
            this.btnKickStudent.TabIndex = 22;
            this.btnKickStudent.Text = "Loại sinh viên";
            this.btnKickStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKickStudent.UseVisualStyleBackColor = true;
            this.btnKickStudent.Click += new System.EventHandler(this.btnKickStudent_Click);
            // 
            // frmManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1425, 822);
            this.Controls.Add(this.btnKickStudent);
            this.Controls.Add(this.gbMark);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbListStudent);
            this.Controls.Add(this.gbSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMainClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.gbSubjects.ResumeLayout(false);
            this.gbListStudent.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMark.ResumeLayout(false);
            this.gbMark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMainClass;
        private System.Windows.Forms.ColumnHeader chIDMain;
        private System.Windows.Forms.ColumnHeader chNameMain;
        private System.Windows.Forms.ColumnHeader chBirthMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSubjects;
        private System.Windows.Forms.FlowLayoutPanel fpnClassTeach;
        private System.Windows.Forms.ListView lvStudentLearn;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbListStudent;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMark;
        private System.Windows.Forms.ComboBox cbbPercentKTDK;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.TextBox txtKTHP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKTDK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbPercentKTHP;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnKickStudent;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.ColumnHeader chHocKi;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.ComboBox cbbStudent;
    }
}