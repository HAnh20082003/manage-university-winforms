
namespace MangerUniversity
{
    partial class frmManageClassroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClassroom));
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnClassRoom = new System.Windows.Forms.Panel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtCountMax = new System.Windows.Forms.TextBox();
            this.lblCountMax = new System.Windows.Forms.Label();
            this.lblNameRoom = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSubjectAllowAssign = new System.Windows.Forms.Label();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.pnDayOfWeek = new System.Windows.Forms.Panel();
            this.rdoCN = new System.Windows.Forms.RadioButton();
            this.rdoThu7 = new System.Windows.Forms.RadioButton();
            this.rdoThu6 = new System.Windows.Forms.RadioButton();
            this.rdoThu5 = new System.Windows.Forms.RadioButton();
            this.rdoThu4 = new System.Windows.Forms.RadioButton();
            this.rdoThu3 = new System.Windows.Forms.RadioButton();
            this.rdoThu2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTietEnd = new System.Windows.Forms.TextBox();
            this.txtTietStart = new System.Windows.Forms.TextBox();
            this.lblTietEnd = new System.Windows.Forms.Label();
            this.lblTietStart = new System.Windows.Forms.Label();
            this.btnAssignSubject = new System.Windows.Forms.Button();
            this.btnCancelSubject = new System.Windows.Forms.Button();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.lblDateSubject = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fpnClassAssign = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvClassSubject = new System.Windows.Forms.ListView();
            this.chIDSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.cbbAssignRoom = new System.Windows.Forms.ComboBox();
            this.gbInfo.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.pnDayOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Honeydew;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(311, 719);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 52);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xoá phòng";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnClassRoom
            // 
            this.pnClassRoom.AutoScroll = true;
            this.pnClassRoom.BackColor = System.Drawing.Color.DimGray;
            this.pnClassRoom.Location = new System.Drawing.Point(38, 326);
            this.pnClassRoom.Name = "pnClassRoom";
            this.pnClassRoom.Size = new System.Drawing.Size(418, 376);
            this.pnClassRoom.TabIndex = 14;
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.SeaGreen;
            this.gbInfo.Controls.Add(this.btnAccept);
            this.gbInfo.Controls.Add(this.txtCountMax);
            this.gbInfo.Controls.Add(this.lblCountMax);
            this.gbInfo.Controls.Add(this.lblNameRoom);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Enabled = false;
            this.gbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.gbInfo.Location = new System.Drawing.Point(38, 35);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(418, 215);
            this.gbInfo.TabIndex = 15;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phòng";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Honeydew;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAccept.FlatAppearance.BorderSize = 3;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(249, 140);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(138, 51);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtCountMax
            // 
            this.txtCountMax.Location = new System.Drawing.Point(150, 89);
            this.txtCountMax.Name = "txtCountMax";
            this.txtCountMax.Size = new System.Drawing.Size(95, 30);
            this.txtCountMax.TabIndex = 4;
            // 
            // lblCountMax
            // 
            this.lblCountMax.AutoSize = true;
            this.lblCountMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMax.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountMax.Location = new System.Drawing.Point(15, 92);
            this.lblCountMax.Name = "lblCountMax";
            this.lblCountMax.Size = new System.Drawing.Size(101, 23);
            this.lblCountMax.TabIndex = 3;
            this.lblCountMax.Text = "Sỉ số tối đa";
            // 
            // lblNameRoom
            // 
            this.lblNameRoom.AutoSize = true;
            this.lblNameRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRoom.ForeColor = System.Drawing.Color.Yellow;
            this.lblNameRoom.Location = new System.Drawing.Point(15, 38);
            this.lblNameRoom.Name = "lblNameRoom";
            this.lblNameRoom.Size = new System.Drawing.Size(97, 23);
            this.lblNameRoom.TabIndex = 1;
            this.lblNameRoom.Text = "Tên phòng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblSubjectAllowAssign
            // 
            this.lblSubjectAllowAssign.AutoSize = true;
            this.lblSubjectAllowAssign.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectAllowAssign.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblSubjectAllowAssign.Location = new System.Drawing.Point(480, 454);
            this.lblSubjectAllowAssign.Name = "lblSubjectAllowAssign";
            this.lblSubjectAllowAssign.Size = new System.Drawing.Size(167, 19);
            this.lblSubjectAllowAssign.TabIndex = 19;
            this.lblSubjectAllowAssign.Text = "Danh sách lớp đề xuất";
            // 
            // gbSubject
            // 
            this.gbSubject.BackColor = System.Drawing.Color.Snow;
            this.gbSubject.Controls.Add(this.pnDayOfWeek);
            this.gbSubject.Controls.Add(this.label4);
            this.gbSubject.Controls.Add(this.txtSearch);
            this.gbSubject.Controls.Add(this.btnSearch);
            this.gbSubject.Controls.Add(this.dtpDateEnd);
            this.gbSubject.Controls.Add(this.label1);
            this.gbSubject.Controls.Add(this.btnSave);
            this.gbSubject.Controls.Add(this.txtTietEnd);
            this.gbSubject.Controls.Add(this.txtTietStart);
            this.gbSubject.Controls.Add(this.lblTietEnd);
            this.gbSubject.Controls.Add(this.lblTietStart);
            this.gbSubject.Controls.Add(this.btnAssignSubject);
            this.gbSubject.Controls.Add(this.btnCancelSubject);
            this.gbSubject.Controls.Add(this.dtpDateStart);
            this.gbSubject.Controls.Add(this.lblDateSubject);
            this.gbSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubject.ForeColor = System.Drawing.Color.Tomato;
            this.gbSubject.Location = new System.Drawing.Point(484, 35);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(597, 407);
            this.gbSubject.TabIndex = 20;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Đăng ký phòng";
            // 
            // pnDayOfWeek
            // 
            this.pnDayOfWeek.Controls.Add(this.rdoCN);
            this.pnDayOfWeek.Controls.Add(this.rdoThu7);
            this.pnDayOfWeek.Controls.Add(this.rdoThu6);
            this.pnDayOfWeek.Controls.Add(this.rdoThu5);
            this.pnDayOfWeek.Controls.Add(this.rdoThu4);
            this.pnDayOfWeek.Controls.Add(this.rdoThu3);
            this.pnDayOfWeek.Controls.Add(this.rdoThu2);
            this.pnDayOfWeek.Location = new System.Drawing.Point(9, 198);
            this.pnDayOfWeek.Name = "pnDayOfWeek";
            this.pnDayOfWeek.Size = new System.Drawing.Size(582, 45);
            this.pnDayOfWeek.TabIndex = 29;
            // 
            // rdoCN
            // 
            this.rdoCN.AutoSize = true;
            this.rdoCN.Location = new System.Drawing.Point(472, 11);
            this.rdoCN.Name = "rdoCN";
            this.rdoCN.Size = new System.Drawing.Size(99, 23);
            this.rdoCN.TabIndex = 42;
            this.rdoCN.Text = "Chủ Nhật";
            this.rdoCN.UseVisualStyleBackColor = true;
            // 
            // rdoThu7
            // 
            this.rdoThu7.AutoSize = true;
            this.rdoThu7.Location = new System.Drawing.Point(394, 11);
            this.rdoThu7.Name = "rdoThu7";
            this.rdoThu7.Size = new System.Drawing.Size(72, 23);
            this.rdoThu7.TabIndex = 41;
            this.rdoThu7.Text = "Thứ 7";
            this.rdoThu7.UseVisualStyleBackColor = true;
            // 
            // rdoThu6
            // 
            this.rdoThu6.AutoSize = true;
            this.rdoThu6.Location = new System.Drawing.Point(316, 11);
            this.rdoThu6.Name = "rdoThu6";
            this.rdoThu6.Size = new System.Drawing.Size(72, 23);
            this.rdoThu6.TabIndex = 40;
            this.rdoThu6.Text = "Thứ 6";
            this.rdoThu6.UseVisualStyleBackColor = true;
            // 
            // rdoThu5
            // 
            this.rdoThu5.AutoSize = true;
            this.rdoThu5.Location = new System.Drawing.Point(238, 11);
            this.rdoThu5.Name = "rdoThu5";
            this.rdoThu5.Size = new System.Drawing.Size(72, 23);
            this.rdoThu5.TabIndex = 39;
            this.rdoThu5.Text = "Thứ 5";
            this.rdoThu5.UseVisualStyleBackColor = true;
            // 
            // rdoThu4
            // 
            this.rdoThu4.AutoSize = true;
            this.rdoThu4.Location = new System.Drawing.Point(160, 11);
            this.rdoThu4.Name = "rdoThu4";
            this.rdoThu4.Size = new System.Drawing.Size(72, 23);
            this.rdoThu4.TabIndex = 38;
            this.rdoThu4.Text = "Thứ 4";
            this.rdoThu4.UseVisualStyleBackColor = true;
            // 
            // rdoThu3
            // 
            this.rdoThu3.AutoSize = true;
            this.rdoThu3.Location = new System.Drawing.Point(82, 11);
            this.rdoThu3.Name = "rdoThu3";
            this.rdoThu3.Size = new System.Drawing.Size(72, 23);
            this.rdoThu3.TabIndex = 37;
            this.rdoThu3.Text = "Thứ 3";
            this.rdoThu3.UseVisualStyleBackColor = true;
            // 
            // rdoThu2
            // 
            this.rdoThu2.AutoSize = true;
            this.rdoThu2.Checked = true;
            this.rdoThu2.Location = new System.Drawing.Point(4, 11);
            this.rdoThu2.Name = "rdoThu2";
            this.rdoThu2.Size = new System.Drawing.Size(72, 23);
            this.rdoThu2.TabIndex = 36;
            this.rdoThu2.TabStop = true;
            this.rdoThu2.Text = "Thứ 2";
            this.rdoThu2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(22, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên phòng: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(132, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 27);
            this.txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Honeydew;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(413, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 48);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm phòng";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEnd.Location = new System.Drawing.Point(136, 75);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(273, 22);
            this.dtpDateEnd.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày kết thúc";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Honeydew;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(413, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 52);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTietEnd
            // 
            this.txtTietEnd.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTietEnd.Location = new System.Drawing.Point(134, 156);
            this.txtTietEnd.Name = "txtTietEnd";
            this.txtTietEnd.Size = new System.Drawing.Size(143, 22);
            this.txtTietEnd.TabIndex = 6;
            // 
            // txtTietStart
            // 
            this.txtTietStart.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTietStart.Location = new System.Drawing.Point(134, 116);
            this.txtTietStart.Name = "txtTietStart";
            this.txtTietStart.Size = new System.Drawing.Size(143, 22);
            this.txtTietStart.TabIndex = 5;
            // 
            // lblTietEnd
            // 
            this.lblTietEnd.AutoSize = true;
            this.lblTietEnd.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTietEnd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTietEnd.Location = new System.Drawing.Point(23, 157);
            this.lblTietEnd.Name = "lblTietEnd";
            this.lblTietEnd.Size = new System.Drawing.Size(93, 17);
            this.lblTietEnd.TabIndex = 5;
            this.lblTietEnd.Text = "Tiết kết thúc:";
            // 
            // lblTietStart
            // 
            this.lblTietStart.AutoSize = true;
            this.lblTietStart.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTietStart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTietStart.Location = new System.Drawing.Point(23, 117);
            this.lblTietStart.Name = "lblTietStart";
            this.lblTietStart.Size = new System.Drawing.Size(86, 17);
            this.lblTietStart.TabIndex = 4;
            this.lblTietStart.Text = "Tiết bắt đầu:";
            // 
            // btnAssignSubject
            // 
            this.btnAssignSubject.BackColor = System.Drawing.Color.Honeydew;
            this.btnAssignSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignSubject.Enabled = false;
            this.btnAssignSubject.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAssignSubject.FlatAppearance.BorderSize = 3;
            this.btnAssignSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAssignSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAssignSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignSubject.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAssignSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignSubject.Image")));
            this.btnAssignSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignSubject.Location = new System.Drawing.Point(19, 339);
            this.btnAssignSubject.Name = "btnAssignSubject";
            this.btnAssignSubject.Size = new System.Drawing.Size(132, 52);
            this.btnAssignSubject.TabIndex = 22;
            this.btnAssignSubject.Text = "Đăng ký";
            this.btnAssignSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignSubject.UseVisualStyleBackColor = false;
            this.btnAssignSubject.Click += new System.EventHandler(this.btnAssignSubject_Click);
            // 
            // btnCancelSubject
            // 
            this.btnCancelSubject.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSubject.Enabled = false;
            this.btnCancelSubject.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnCancelSubject.FlatAppearance.BorderSize = 3;
            this.btnCancelSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCancelSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSubject.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCancelSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSubject.Image")));
            this.btnCancelSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSubject.Location = new System.Drawing.Point(203, 339);
            this.btnCancelSubject.Name = "btnCancelSubject";
            this.btnCancelSubject.Size = new System.Drawing.Size(154, 52);
            this.btnCancelSubject.TabIndex = 21;
            this.btnCancelSubject.Text = "Huỷ đăng ký";
            this.btnCancelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelSubject.UseVisualStyleBackColor = false;
            this.btnCancelSubject.Click += new System.EventHandler(this.btnCancelSubject_Click);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateStart.Location = new System.Drawing.Point(134, 38);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(275, 22);
            this.dtpDateStart.TabIndex = 3;
            // 
            // lblDateSubject
            // 
            this.lblDateSubject.AutoSize = true;
            this.lblDateSubject.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSubject.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDateSubject.Location = new System.Drawing.Point(23, 38);
            this.lblDateSubject.Name = "lblDateSubject";
            this.lblDateSubject.Size = new System.Drawing.Size(87, 17);
            this.lblDateSubject.TabIndex = 2;
            this.lblDateSubject.Text = "Ngày bắt đầu";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Honeydew;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(38, 720);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 51);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm phòng";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fpnClassAssign
            // 
            this.fpnClassAssign.AutoScroll = true;
            this.fpnClassAssign.BackColor = System.Drawing.Color.MediumAquamarine;
            this.fpnClassAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnClassAssign.ForeColor = System.Drawing.Color.Indigo;
            this.fpnClassAssign.Location = new System.Drawing.Point(1113, 85);
            this.fpnClassAssign.Name = "fpnClassAssign";
            this.fpnClassAssign.Size = new System.Drawing.Size(412, 659);
            this.fpnClassAssign.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(1109, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Các lớp đã đăng ký phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(34, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Danh sách phòng học hiện có";
            // 
            // lvClassSubject
            // 
            this.lvClassSubject.CheckBoxes = true;
            this.lvClassSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIDSubject,
            this.chMaGV,
            this.chNameSubject});
            this.lvClassSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvClassSubject.FullRowSelect = true;
            this.lvClassSubject.GridLines = true;
            this.lvClassSubject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClassSubject.HideSelection = false;
            this.lvClassSubject.Location = new System.Drawing.Point(484, 489);
            this.lvClassSubject.Name = "lvClassSubject";
            this.lvClassSubject.Size = new System.Drawing.Size(597, 267);
            this.lvClassSubject.TabIndex = 32;
            this.lvClassSubject.UseCompatibleStateImageBehavior = false;
            this.lvClassSubject.View = System.Windows.Forms.View.Details;
            this.lvClassSubject.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvSubjects_ItemChecked);
            // 
            // chIDSubject
            // 
            this.chIDSubject.Text = "Mã môn";
            this.chIDSubject.Width = 98;
            // 
            // chMaGV
            // 
            this.chMaGV.Text = "Mã GV";
            this.chMaGV.Width = 103;
            // 
            // chNameSubject
            // 
            this.chNameSubject.Text = "Tên môn";
            this.chNameSubject.Width = 391;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Honeydew;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(338, 264);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 49);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbAssignRoom
            // 
            this.cbbAssignRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbAssignRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAssignRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbAssignRoom.Enabled = false;
            this.cbbAssignRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAssignRoom.FormattingEnabled = true;
            this.cbbAssignRoom.Location = new System.Drawing.Point(1353, 40);
            this.cbbAssignRoom.Name = "cbbAssignRoom";
            this.cbbAssignRoom.Size = new System.Drawing.Size(172, 27);
            this.cbbAssignRoom.TabIndex = 34;
            this.cbbAssignRoom.SelectedIndexChanged += new System.EventHandler(this.cbbAssignRoom_SelectedIndexChanged);
            // 
            // frmManageClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1545, 787);
            this.Controls.Add(this.cbbAssignRoom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lvClassSubject);
            this.Controls.Add(this.lblSubjectAllowAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fpnClassAssign);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.pnClassRoom);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng học";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.pnDayOfWeek.ResumeLayout(false);
            this.pnDayOfWeek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnClassRoom;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblCountMax;
        private System.Windows.Forms.Label lblNameRoom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCountMax;
        private System.Windows.Forms.Label lblSubjectAllowAssign;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.Label lblTietEnd;
        private System.Windows.Forms.Label lblTietStart;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label lblDateSubject;
        private System.Windows.Forms.TextBox txtTietEnd;
        private System.Windows.Forms.TextBox txtTietStart;
        private System.Windows.Forms.Button btnCancelSubject;
        private System.Windows.Forms.Button btnAssignSubject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel fpnClassAssign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvClassSubject;
        private System.Windows.Forms.ColumnHeader chIDSubject;
        private System.Windows.Forms.ColumnHeader chMaGV;
        private System.Windows.Forms.ColumnHeader chNameSubject;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbbAssignRoom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnDayOfWeek;
        private System.Windows.Forms.RadioButton rdoCN;
        private System.Windows.Forms.RadioButton rdoThu7;
        private System.Windows.Forms.RadioButton rdoThu6;
        private System.Windows.Forms.RadioButton rdoThu5;
        private System.Windows.Forms.RadioButton rdoThu4;
        private System.Windows.Forms.RadioButton rdoThu3;
        private System.Windows.Forms.RadioButton rdoThu2;
    }
}