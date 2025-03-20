
namespace MangerUniversity
{
    partial class frmManageSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSurvey));
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnSubjectClass = new System.Windows.Forms.FlowLayoutPanel();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.chMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHocKi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.gbSurvey = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdoBad5 = new System.Windows.Forms.RadioButton();
            this.rdoNormal5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoNice5 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdoBad4 = new System.Windows.Forms.RadioButton();
            this.rdoNormal4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoNice4 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdoBad3 = new System.Windows.Forms.RadioButton();
            this.rdoNormal3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoNice3 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoBad2 = new System.Windows.Forms.RadioButton();
            this.rdoNormal2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoNice2 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoBad1 = new System.Windows.Forms.RadioButton();
            this.rdoNormal1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNice1 = new System.Windows.Forms.RadioButton();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.ptrAvt = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllSurvey = new System.Windows.Forms.Button();
            this.btnDeleteAllSurveyGV = new System.Windows.Forms.Button();
            this.cbbSurvey = new System.Windows.Forms.ComboBox();
            this.gbSurvey.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(33, 71);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(281, 31);
            this.cbbMaGV.TabIndex = 0;
            this.cbbMaGV.SelectedIndexChanged += new System.EventHandler(this.cbbMaGV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giảng viên";
            // 
            // fpnSubjectClass
            // 
            this.fpnSubjectClass.AutoScroll = true;
            this.fpnSubjectClass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnSubjectClass.Location = new System.Drawing.Point(33, 127);
            this.fpnSubjectClass.Name = "fpnSubjectClass";
            this.fpnSubjectClass.Size = new System.Drawing.Size(518, 288);
            this.fpnSubjectClass.TabIndex = 2;
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMaSV,
            this.chNameStudent,
            this.chHocKi,
            this.chYear});
            this.lvStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudent.HideSelection = false;
            this.lvStudent.Location = new System.Drawing.Point(33, 515);
            this.lvStudent.MultiSelect = false;
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(518, 226);
            this.lvStudent.TabIndex = 3;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            // 
            // chMaSV
            // 
            this.chMaSV.Text = "Mã SV";
            this.chMaSV.Width = 110;
            // 
            // chNameStudent
            // 
            this.chNameStudent.Text = "Họ tên";
            this.chNameStudent.Width = 246;
            // 
            // chHocKi
            // 
            this.chHocKi.Text = "Học kì";
            this.chHocKi.Width = 76;
            // 
            // chYear
            // 
            this.chYear.Text = "Năm";
            this.chYear.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(29, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách sinh viên tham gia khảo sát";
            // 
            // gbSurvey
            // 
            this.gbSurvey.BackColor = System.Drawing.Color.Thistle;
            this.gbSurvey.Controls.Add(this.btnDelete);
            this.gbSurvey.Controls.Add(this.panel8);
            this.gbSurvey.Controls.Add(this.panel7);
            this.gbSurvey.Controls.Add(this.panel6);
            this.gbSurvey.Controls.Add(this.panel5);
            this.gbSurvey.Controls.Add(this.panel4);
            this.gbSurvey.Enabled = false;
            this.gbSurvey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSurvey.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbSurvey.Location = new System.Drawing.Point(819, 32);
            this.gbSurvey.Name = "gbSurvey";
            this.gbSurvey.Size = new System.Drawing.Size(430, 631);
            this.gbSurvey.TabIndex = 40;
            this.gbSurvey.TabStop = false;
            this.gbSurvey.Text = "Khảo sát chất lượng giảng viên";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(25, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 53);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Xoá khảo sát";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rdoBad5);
            this.panel8.Controls.Add(this.rdoNormal5);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.rdoNice5);
            this.panel8.Location = new System.Drawing.Point(25, 435);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(383, 93);
            this.panel8.TabIndex = 40;
            this.panel8.Tag = "5";
            // 
            // rdoBad5
            // 
            this.rdoBad5.AutoSize = true;
            this.rdoBad5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBad5.Enabled = false;
            this.rdoBad5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBad5.ForeColor = System.Drawing.Color.Purple;
            this.rdoBad5.Location = new System.Drawing.Point(313, 48);
            this.rdoBad5.Name = "rdoBad5";
            this.rdoBad5.Size = new System.Drawing.Size(54, 27);
            this.rdoBad5.TabIndex = 36;
            this.rdoBad5.Tag = "3";
            this.rdoBad5.Text = "Tệ";
            this.rdoBad5.UseVisualStyleBackColor = true;
            // 
            // rdoNormal5
            // 
            this.rdoNormal5.AutoSize = true;
            this.rdoNormal5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNormal5.Enabled = false;
            this.rdoNormal5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal5.ForeColor = System.Drawing.Color.Purple;
            this.rdoNormal5.Location = new System.Drawing.Point(155, 48);
            this.rdoNormal5.Name = "rdoNormal5";
            this.rdoNormal5.Size = new System.Drawing.Size(135, 27);
            this.rdoNormal5.TabIndex = 35;
            this.rdoNormal5.Tag = "2";
            this.rdoNormal5.Text = "Bình thường";
            this.rdoNormal5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chấm điểm công tâm";
            // 
            // rdoNice5
            // 
            this.rdoNice5.AutoSize = true;
            this.rdoNice5.Checked = true;
            this.rdoNice5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNice5.Enabled = false;
            this.rdoNice5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNice5.ForeColor = System.Drawing.Color.Purple;
            this.rdoNice5.Location = new System.Drawing.Point(22, 48);
            this.rdoNice5.Name = "rdoNice5";
            this.rdoNice5.Size = new System.Drawing.Size(79, 27);
            this.rdoNice5.TabIndex = 33;
            this.rdoNice5.TabStop = true;
            this.rdoNice5.Tag = "1";
            this.rdoNice5.Text = "Tuyệt";
            this.rdoNice5.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rdoBad4);
            this.panel7.Controls.Add(this.rdoNormal4);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.rdoNice4);
            this.panel7.Location = new System.Drawing.Point(25, 336);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 93);
            this.panel7.TabIndex = 39;
            this.panel7.Tag = "4";
            // 
            // rdoBad4
            // 
            this.rdoBad4.AutoSize = true;
            this.rdoBad4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBad4.Enabled = false;
            this.rdoBad4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBad4.ForeColor = System.Drawing.Color.Purple;
            this.rdoBad4.Location = new System.Drawing.Point(313, 48);
            this.rdoBad4.Name = "rdoBad4";
            this.rdoBad4.Size = new System.Drawing.Size(54, 27);
            this.rdoBad4.TabIndex = 36;
            this.rdoBad4.Tag = "3";
            this.rdoBad4.Text = "Tệ";
            this.rdoBad4.UseVisualStyleBackColor = true;
            // 
            // rdoNormal4
            // 
            this.rdoNormal4.AutoSize = true;
            this.rdoNormal4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNormal4.Enabled = false;
            this.rdoNormal4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal4.ForeColor = System.Drawing.Color.Purple;
            this.rdoNormal4.Location = new System.Drawing.Point(155, 48);
            this.rdoNormal4.Name = "rdoNormal4";
            this.rdoNormal4.Size = new System.Drawing.Size(135, 27);
            this.rdoNormal4.TabIndex = 35;
            this.rdoNormal4.Tag = "2";
            this.rdoNormal4.Text = "Bình thường";
            this.rdoNormal4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Thực hiện điểm danh";
            // 
            // rdoNice4
            // 
            this.rdoNice4.AutoSize = true;
            this.rdoNice4.Checked = true;
            this.rdoNice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNice4.Enabled = false;
            this.rdoNice4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNice4.ForeColor = System.Drawing.Color.Purple;
            this.rdoNice4.Location = new System.Drawing.Point(22, 48);
            this.rdoNice4.Name = "rdoNice4";
            this.rdoNice4.Size = new System.Drawing.Size(79, 27);
            this.rdoNice4.TabIndex = 33;
            this.rdoNice4.TabStop = true;
            this.rdoNice4.Tag = "1";
            this.rdoNice4.Text = "Tuyệt";
            this.rdoNice4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdoBad3);
            this.panel6.Controls.Add(this.rdoNormal3);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.rdoNice3);
            this.panel6.Location = new System.Drawing.Point(25, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 93);
            this.panel6.TabIndex = 38;
            this.panel6.Tag = "3";
            // 
            // rdoBad3
            // 
            this.rdoBad3.AutoSize = true;
            this.rdoBad3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBad3.Enabled = false;
            this.rdoBad3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBad3.ForeColor = System.Drawing.Color.Purple;
            this.rdoBad3.Location = new System.Drawing.Point(313, 48);
            this.rdoBad3.Name = "rdoBad3";
            this.rdoBad3.Size = new System.Drawing.Size(54, 27);
            this.rdoBad3.TabIndex = 36;
            this.rdoBad3.Tag = "3";
            this.rdoBad3.Text = "Tệ";
            this.rdoBad3.UseVisualStyleBackColor = true;
            // 
            // rdoNormal3
            // 
            this.rdoNormal3.AutoSize = true;
            this.rdoNormal3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNormal3.Enabled = false;
            this.rdoNormal3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal3.ForeColor = System.Drawing.Color.Purple;
            this.rdoNormal3.Location = new System.Drawing.Point(155, 48);
            this.rdoNormal3.Name = "rdoNormal3";
            this.rdoNormal3.Size = new System.Drawing.Size(135, 27);
            this.rdoNormal3.TabIndex = 35;
            this.rdoNormal3.Tag = "2";
            this.rdoNormal3.Text = "Bình thường";
            this.rdoNormal3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mức độ quan tâm sinh viên";
            // 
            // rdoNice3
            // 
            this.rdoNice3.AutoSize = true;
            this.rdoNice3.Checked = true;
            this.rdoNice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNice3.Enabled = false;
            this.rdoNice3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNice3.ForeColor = System.Drawing.Color.Purple;
            this.rdoNice3.Location = new System.Drawing.Point(22, 48);
            this.rdoNice3.Name = "rdoNice3";
            this.rdoNice3.Size = new System.Drawing.Size(79, 27);
            this.rdoNice3.TabIndex = 33;
            this.rdoNice3.TabStop = true;
            this.rdoNice3.Tag = "1";
            this.rdoNice3.Text = "Tuyệt";
            this.rdoNice3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdoBad2);
            this.panel5.Controls.Add(this.rdoNormal2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.rdoNice2);
            this.panel5.Location = new System.Drawing.Point(25, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 93);
            this.panel5.TabIndex = 37;
            this.panel5.Tag = "2";
            // 
            // rdoBad2
            // 
            this.rdoBad2.AutoSize = true;
            this.rdoBad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBad2.Enabled = false;
            this.rdoBad2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBad2.ForeColor = System.Drawing.Color.Purple;
            this.rdoBad2.Location = new System.Drawing.Point(313, 48);
            this.rdoBad2.Name = "rdoBad2";
            this.rdoBad2.Size = new System.Drawing.Size(54, 27);
            this.rdoBad2.TabIndex = 36;
            this.rdoBad2.Tag = "3";
            this.rdoBad2.Text = "Tệ";
            this.rdoBad2.UseVisualStyleBackColor = true;
            // 
            // rdoNormal2
            // 
            this.rdoNormal2.AutoSize = true;
            this.rdoNormal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNormal2.Enabled = false;
            this.rdoNormal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal2.ForeColor = System.Drawing.Color.Purple;
            this.rdoNormal2.Location = new System.Drawing.Point(155, 48);
            this.rdoNormal2.Name = "rdoNormal2";
            this.rdoNormal2.Size = new System.Drawing.Size(135, 27);
            this.rdoNormal2.TabIndex = 35;
            this.rdoNormal2.Tag = "2";
            this.rdoNormal2.Text = "Bình thường";
            this.rdoNormal2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(18, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mức độ nghiêm túc trong giảng dạy";
            // 
            // rdoNice2
            // 
            this.rdoNice2.AutoSize = true;
            this.rdoNice2.Checked = true;
            this.rdoNice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNice2.Enabled = false;
            this.rdoNice2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNice2.ForeColor = System.Drawing.Color.Purple;
            this.rdoNice2.Location = new System.Drawing.Point(22, 48);
            this.rdoNice2.Name = "rdoNice2";
            this.rdoNice2.Size = new System.Drawing.Size(79, 27);
            this.rdoNice2.TabIndex = 33;
            this.rdoNice2.TabStop = true;
            this.rdoNice2.Tag = "1";
            this.rdoNice2.Text = "Tuyệt";
            this.rdoNice2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoBad1);
            this.panel4.Controls.Add(this.rdoNormal1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.rdoNice1);
            this.panel4.Location = new System.Drawing.Point(25, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 93);
            this.panel4.TabIndex = 35;
            this.panel4.Tag = "1";
            // 
            // rdoBad1
            // 
            this.rdoBad1.AutoSize = true;
            this.rdoBad1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBad1.Enabled = false;
            this.rdoBad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBad1.ForeColor = System.Drawing.Color.Purple;
            this.rdoBad1.Location = new System.Drawing.Point(313, 48);
            this.rdoBad1.Name = "rdoBad1";
            this.rdoBad1.Size = new System.Drawing.Size(54, 27);
            this.rdoBad1.TabIndex = 36;
            this.rdoBad1.Tag = "3";
            this.rdoBad1.Text = "Tệ";
            this.rdoBad1.UseVisualStyleBackColor = true;
            // 
            // rdoNormal1
            // 
            this.rdoNormal1.AutoSize = true;
            this.rdoNormal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNormal1.Enabled = false;
            this.rdoNormal1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal1.ForeColor = System.Drawing.Color.Purple;
            this.rdoNormal1.Location = new System.Drawing.Point(155, 48);
            this.rdoNormal1.Name = "rdoNormal1";
            this.rdoNormal1.Size = new System.Drawing.Size(135, 27);
            this.rdoNormal1.TabIndex = 35;
            this.rdoNormal1.Tag = "2";
            this.rdoNormal1.Text = "Bình thường";
            this.rdoNormal1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Chất lượng bài giảng và slide";
            // 
            // rdoNice1
            // 
            this.rdoNice1.AutoSize = true;
            this.rdoNice1.Checked = true;
            this.rdoNice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNice1.Enabled = false;
            this.rdoNice1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNice1.ForeColor = System.Drawing.Color.Purple;
            this.rdoNice1.Location = new System.Drawing.Point(22, 48);
            this.rdoNice1.Name = "rdoNice1";
            this.rdoNice1.Size = new System.Drawing.Size(79, 27);
            this.rdoNice1.TabIndex = 33;
            this.rdoNice1.TabStop = true;
            this.rdoNice1.Tag = "1";
            this.rdoNice1.Text = "Tuyệt";
            this.rdoNice1.UseVisualStyleBackColor = true;
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNameStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStudent.ForeColor = System.Drawing.Color.Indigo;
            this.lblNameStudent.Location = new System.Drawing.Point(575, 385);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(212, 30);
            this.lblNameStudent.TabIndex = 48;
            this.lblNameStudent.Text = "Họ và tên";
            this.lblNameStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrAvt
            // 
            this.ptrAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrAvt.Image = ((System.Drawing.Image)(resources.GetObject("ptrAvt.Image")));
            this.ptrAvt.Location = new System.Drawing.Point(596, 192);
            this.ptrAvt.Name = "ptrAvt";
            this.ptrAvt.Size = new System.Drawing.Size(170, 170);
            this.ptrAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrAvt.TabIndex = 47;
            this.ptrAvt.TabStop = false;
            // 
            // btnDeleteAllSurvey
            // 
            this.btnDeleteAllSurvey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAllSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllSurvey.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteAllSurvey.FlatAppearance.BorderSize = 3;
            this.btnDeleteAllSurvey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteAllSurvey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnDeleteAllSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllSurvey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllSurvey.ForeColor = System.Drawing.Color.Purple;
            this.btnDeleteAllSurvey.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllSurvey.Image")));
            this.btnDeleteAllSurvey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllSurvey.Location = new System.Drawing.Point(563, 457);
            this.btnDeleteAllSurvey.Name = "btnDeleteAllSurvey";
            this.btnDeleteAllSurvey.Size = new System.Drawing.Size(244, 53);
            this.btnDeleteAllSurvey.TabIndex = 42;
            this.btnDeleteAllSurvey.Text = "Xoá toàn bộ khảo sát";
            this.btnDeleteAllSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllSurvey.UseVisualStyleBackColor = false;
            this.btnDeleteAllSurvey.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteAllSurveyGV
            // 
            this.btnDeleteAllSurveyGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAllSurveyGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllSurveyGV.Enabled = false;
            this.btnDeleteAllSurveyGV.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteAllSurveyGV.FlatAppearance.BorderSize = 3;
            this.btnDeleteAllSurveyGV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteAllSurveyGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnDeleteAllSurveyGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllSurveyGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllSurveyGV.ForeColor = System.Drawing.Color.Purple;
            this.btnDeleteAllSurveyGV.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllSurveyGV.Image")));
            this.btnDeleteAllSurveyGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllSurveyGV.Location = new System.Drawing.Point(819, 680);
            this.btnDeleteAllSurveyGV.Name = "btnDeleteAllSurveyGV";
            this.btnDeleteAllSurveyGV.Size = new System.Drawing.Size(228, 53);
            this.btnDeleteAllSurveyGV.TabIndex = 49;
            this.btnDeleteAllSurveyGV.Text = "Xoá khảo sát GV";
            this.btnDeleteAllSurveyGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllSurveyGV.UseVisualStyleBackColor = false;
            this.btnDeleteAllSurveyGV.Click += new System.EventHandler(this.btnDeleteAllSurveyGV_Click);
            // 
            // cbbSurvey
            // 
            this.cbbSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSurvey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSurvey.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSurvey.FormattingEnabled = true;
            this.cbbSurvey.Items.AddRange(new object[] {
            "Khảo sát hiện tại",
            "Khảo sát cũ hơn"});
            this.cbbSurvey.Location = new System.Drawing.Point(33, 472);
            this.cbbSurvey.Name = "cbbSurvey";
            this.cbbSurvey.Size = new System.Drawing.Size(281, 27);
            this.cbbSurvey.TabIndex = 50;
            this.cbbSurvey.SelectedIndexChanged += new System.EventHandler(this.cbbSurvey_SelectedIndexChanged);
            // 
            // frmManageSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1271, 766);
            this.Controls.Add(this.cbbSurvey);
            this.Controls.Add(this.btnDeleteAllSurveyGV);
            this.Controls.Add(this.btnDeleteAllSurvey);
            this.Controls.Add(this.lblNameStudent);
            this.Controls.Add(this.ptrAvt);
            this.Controls.Add(this.gbSurvey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.fpnSubjectClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMaGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khảo sát";
            this.gbSurvey.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnSubjectClass;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader chMaSV;
        private System.Windows.Forms.ColumnHeader chNameStudent;
        private System.Windows.Forms.ColumnHeader chHocKi;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSurvey;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rdoBad5;
        private System.Windows.Forms.RadioButton rdoNormal5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoNice5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdoBad4;
        private System.Windows.Forms.RadioButton rdoNormal4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoNice4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdoBad3;
        private System.Windows.Forms.RadioButton rdoNormal3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoNice3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdoBad2;
        private System.Windows.Forms.RadioButton rdoNormal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoNice2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoBad1;
        private System.Windows.Forms.RadioButton rdoNormal1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoNice1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.PictureBox ptrAvt;
        private System.Windows.Forms.Button btnDeleteAllSurvey;
        private System.Windows.Forms.Button btnDeleteAllSurveyGV;
        private System.Windows.Forms.ComboBox cbbSurvey;
    }
}