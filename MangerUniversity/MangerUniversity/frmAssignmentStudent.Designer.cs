
namespace MangerUniversity
{
    partial class frmAssignmentStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignmentStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.fpnClasss = new System.Windows.Forms.FlowLayoutPanel();
            this.gbClasss = new System.Windows.Forms.GroupBox();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAssignAll = new System.Windows.Forms.Button();
            this.gbStudentInClass = new System.Windows.Forms.GroupBox();
            this.btnKick = new System.Windows.Forms.Button();
            this.btnKickAllClass = new System.Windows.Forms.Button();
            this.lvStudentInClass = new System.Windows.Forms.ListView();
            this.chIDStudentInClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameStudentInClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKickAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gbClasss.SuspendLayout();
            this.gbStudents.SuspendLayout();
            this.gbStudentInClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 74);
            this.panel1.TabIndex = 27;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Lavender;
            this.lblSearch.Location = new System.Drawing.Point(14, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 23);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Tìm kiếm tên lớp";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(18, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 27);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // fpnClasss
            // 
            this.fpnClasss.AutoScroll = true;
            this.fpnClasss.BackColor = System.Drawing.Color.GhostWhite;
            this.fpnClasss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnClasss.Location = new System.Drawing.Point(17, 29);
            this.fpnClasss.Name = "fpnClasss";
            this.fpnClasss.Size = new System.Drawing.Size(400, 507);
            this.fpnClasss.TabIndex = 35;
            // 
            // gbClasss
            // 
            this.gbClasss.Controls.Add(this.fpnClasss);
            this.gbClasss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClasss.ForeColor = System.Drawing.Color.Pink;
            this.gbClasss.Location = new System.Drawing.Point(12, 248);
            this.gbClasss.Name = "gbClasss";
            this.gbClasss.Size = new System.Drawing.Size(435, 559);
            this.gbClasss.TabIndex = 36;
            this.gbClasss.TabStop = false;
            this.gbClasss.Text = "Danh sách lớp";
            // 
            // gbStudents
            // 
            this.gbStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.gbStudents.Controls.Add(this.btnAdd);
            this.gbStudents.Controls.Add(this.lvStudents);
            this.gbStudents.Enabled = false;
            this.gbStudents.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudents.ForeColor = System.Drawing.Color.White;
            this.gbStudents.Location = new System.Drawing.Point(838, 10);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(396, 701);
            this.gbStudents.TabIndex = 37;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Danh sách sinh viên";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(23, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 53);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Thêm vào lớp";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvStudents
            // 
            this.lvStudents.CheckBoxes = true;
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName});
            this.lvStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStudents.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudents.FullRowSelect = true;
            this.lvStudents.GridLines = true;
            this.lvStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(23, 39);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(351, 572);
            this.lvStudents.TabIndex = 1;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            this.lvStudents.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudents_ItemChecked);
            // 
            // chID
            // 
            this.chID.Text = "Mã SV";
            this.chID.Width = 114;
            // 
            // chName
            // 
            this.chName.Text = "Họ tên";
            this.chName.Width = 233;
            // 
            // btnAssignAll
            // 
            this.btnAssignAll.BackColor = System.Drawing.Color.Black;
            this.btnAssignAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignAll.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnAssignAll.FlatAppearance.BorderSize = 3;
            this.btnAssignAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAssignAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAssignAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignAll.ForeColor = System.Drawing.Color.White;
            this.btnAssignAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignAll.Image")));
            this.btnAssignAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignAll.Location = new System.Drawing.Point(838, 731);
            this.btnAssignAll.Name = "btnAssignAll";
            this.btnAssignAll.Size = new System.Drawing.Size(191, 53);
            this.btnAssignAll.TabIndex = 39;
            this.btnAssignAll.Text = "Phân bổ tự động";
            this.btnAssignAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignAll.UseVisualStyleBackColor = false;
            this.btnAssignAll.Click += new System.EventHandler(this.btnAssignAll_Click);
            // 
            // gbStudentInClass
            // 
            this.gbStudentInClass.BackColor = System.Drawing.Color.CadetBlue;
            this.gbStudentInClass.Controls.Add(this.btnKick);
            this.gbStudentInClass.Controls.Add(this.btnKickAllClass);
            this.gbStudentInClass.Controls.Add(this.lvStudentInClass);
            this.gbStudentInClass.Enabled = false;
            this.gbStudentInClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInClass.ForeColor = System.Drawing.Color.MintCream;
            this.gbStudentInClass.Location = new System.Drawing.Point(453, 278);
            this.gbStudentInClass.Name = "gbStudentInClass";
            this.gbStudentInClass.Size = new System.Drawing.Size(363, 529);
            this.gbStudentInClass.TabIndex = 38;
            this.gbStudentInClass.TabStop = false;
            this.gbStudentInClass.Text = "Sinh viên lớp";
            // 
            // btnKick
            // 
            this.btnKick.BackColor = System.Drawing.Color.White;
            this.btnKick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKick.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.btnKick.FlatAppearance.BorderSize = 3;
            this.btnKick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnKick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnKick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKick.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKick.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnKick.Image = ((System.Drawing.Image)(resources.GetObject("btnKick.Image")));
            this.btnKick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKick.Location = new System.Drawing.Point(16, 454);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(133, 52);
            this.btnKick.TabIndex = 39;
            this.btnKick.Text = "Loại bỏ";
            this.btnKick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKick.UseVisualStyleBackColor = false;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // btnKickAllClass
            // 
            this.btnKickAllClass.BackColor = System.Drawing.Color.White;
            this.btnKickAllClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKickAllClass.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.btnKickAllClass.FlatAppearance.BorderSize = 3;
            this.btnKickAllClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnKickAllClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnKickAllClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKickAllClass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKickAllClass.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnKickAllClass.Image = ((System.Drawing.Image)(resources.GetObject("btnKickAllClass.Image")));
            this.btnKickAllClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKickAllClass.Location = new System.Drawing.Point(170, 454);
            this.btnKickAllClass.Name = "btnKickAllClass";
            this.btnKickAllClass.Size = new System.Drawing.Size(174, 53);
            this.btnKickAllClass.TabIndex = 41;
            this.btnKickAllClass.Text = "Loại bỏ cả lớp";
            this.btnKickAllClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKickAllClass.UseVisualStyleBackColor = false;
            this.btnKickAllClass.Click += new System.EventHandler(this.btnKickAllClass_Click);
            // 
            // lvStudentInClass
            // 
            this.lvStudentInClass.CheckBoxes = true;
            this.lvStudentInClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIDStudentInClass,
            this.chNameStudentInClass});
            this.lvStudentInClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStudentInClass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudentInClass.FullRowSelect = true;
            this.lvStudentInClass.GridLines = true;
            this.lvStudentInClass.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudentInClass.HideSelection = false;
            this.lvStudentInClass.Location = new System.Drawing.Point(16, 42);
            this.lvStudentInClass.Name = "lvStudentInClass";
            this.lvStudentInClass.Size = new System.Drawing.Size(328, 391);
            this.lvStudentInClass.TabIndex = 2;
            this.lvStudentInClass.UseCompatibleStateImageBehavior = false;
            this.lvStudentInClass.View = System.Windows.Forms.View.Details;
            this.lvStudentInClass.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudentInClass_ItemChecked);
            // 
            // chIDStudentInClass
            // 
            this.chIDStudentInClass.Text = "Mã SV";
            this.chIDStudentInClass.Width = 102;
            // 
            // chNameStudentInClass
            // 
            this.chNameStudentInClass.Text = "Họ tên";
            this.chNameStudentInClass.Width = 221;
            // 
            // btnKickAll
            // 
            this.btnKickAll.BackColor = System.Drawing.Color.Black;
            this.btnKickAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKickAll.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnKickAll.FlatAppearance.BorderSize = 3;
            this.btnKickAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnKickAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnKickAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKickAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKickAll.ForeColor = System.Drawing.Color.White;
            this.btnKickAll.Image = ((System.Drawing.Image)(resources.GetObject("btnKickAll.Image")));
            this.btnKickAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKickAll.Location = new System.Drawing.Point(1053, 731);
            this.btnKickAll.Name = "btnKickAll";
            this.btnKickAll.Size = new System.Drawing.Size(181, 53);
            this.btnKickAll.TabIndex = 40;
            this.btnKickAll.Text = "Loại bỏ toàn bộ";
            this.btnKickAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKickAll.UseVisualStyleBackColor = false;
            this.btnKickAll.Click += new System.EventHandler(this.btnKickAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(29, 124);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(261, 27);
            this.cbbKhoa.TabIndex = 40;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(25, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(25, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngành";
            // 
            // cbbMajor
            // 
            this.cbbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMajor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMajor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Location = new System.Drawing.Point(29, 193);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(261, 27);
            this.cbbMajor.TabIndex = 42;
            this.cbbMajor.SelectedIndexChanged += new System.EventHandler(this.cbbMajor_SelectedIndexChanged);
            // 
            // frmAssignmentStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1254, 819);
            this.Controls.Add(this.btnKickAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.btnAssignAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbStudentInClass);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.gbClasss);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAssignmentStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sắp lớp cho sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbClasss.ResumeLayout(false);
            this.gbStudents.ResumeLayout(false);
            this.gbStudentInClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel fpnClasss;
        private System.Windows.Forms.GroupBox gbClasss;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.GroupBox gbStudentInClass;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.ListView lvStudentInClass;
        private System.Windows.Forms.ColumnHeader chIDStudentInClass;
        private System.Windows.Forms.ColumnHeader chNameStudentInClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAssignAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKickAll;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.Button btnKickAllClass;
    }
}