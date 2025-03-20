
namespace MangerUniversity
{
    partial class frmManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubject));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khoa / Viện");
            this.lvSubject = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMust = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHocKi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoSortHocKiAndYear = new System.Windows.Forms.RadioButton();
            this.rdoSortMoney = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.rdoSortName = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoInscrease = new System.Windows.Forms.RadioButton();
            this.rdoDescrease = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.lblHocKi = new System.Windows.Forms.Label();
            this.lblMust = new System.Windows.Forms.Label();
            this.ckMust = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbMajors = new System.Windows.Forms.GroupBox();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.rdoFilterMust = new System.Windows.Forms.RadioButton();
            this.rdoFilterNotMust = new System.Windows.Forms.RadioButton();
            this.rdoFilterNormal = new System.Windows.Forms.RadioButton();
            this.pnSubject = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbMajors.SuspendLayout();
            this.pnSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSubject
            // 
            this.lvSubject.BackColor = System.Drawing.SystemColors.Menu;
            this.lvSubject.CheckBoxes = true;
            this.lvSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chMust,
            this.chSoTC,
            this.chSoTiet,
            this.chMoney,
            this.chHocKi,
            this.chYear});
            this.lvSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSubject.FullRowSelect = true;
            this.lvSubject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubject.HideSelection = false;
            this.lvSubject.Location = new System.Drawing.Point(10, 226);
            this.lvSubject.MultiSelect = false;
            this.lvSubject.Name = "lvSubject";
            this.lvSubject.Size = new System.Drawing.Size(738, 305);
            this.lvSubject.TabIndex = 9;
            this.lvSubject.UseCompatibleStateImageBehavior = false;
            this.lvSubject.View = System.Windows.Forms.View.Details;
            this.lvSubject.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvSubject_ItemChecked);
            this.lvSubject.SelectedIndexChanged += new System.EventHandler(this.lvSubject_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Tên môn";
            this.chName.Width = 268;
            // 
            // chMust
            // 
            this.chMust.Text = "Bắt buộc";
            this.chMust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMust.Width = 73;
            // 
            // chSoTC
            // 
            this.chSoTC.Text = "Số TC";
            this.chSoTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSoTC.Width = 87;
            // 
            // chSoTiet
            // 
            this.chSoTiet.Text = "Số tiết";
            this.chSoTiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMoney
            // 
            this.chMoney.Text = "Phí";
            this.chMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMoney.Width = 89;
            // 
            // chHocKi
            // 
            this.chHocKi.Text = "Học kì";
            this.chHocKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHocKi.Width = 75;
            // 
            // chYear
            // 
            this.chYear.Text = "Năm";
            this.chYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chYear.Width = 80;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(10, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 86);
            this.panel5.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoSortHocKiAndYear);
            this.panel2.Controls.Add(this.rdoSortMoney);
            this.panel2.Controls.Add(this.lblSort);
            this.panel2.Controls.Add(this.rdoSortName);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 51);
            this.panel2.TabIndex = 16;
            // 
            // rdoSortHocKiAndYear
            // 
            this.rdoSortHocKiAndYear.AutoSize = true;
            this.rdoSortHocKiAndYear.Checked = true;
            this.rdoSortHocKiAndYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSortHocKiAndYear.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSortHocKiAndYear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoSortHocKiAndYear.Location = new System.Drawing.Point(7, 24);
            this.rdoSortHocKiAndYear.Name = "rdoSortHocKiAndYear";
            this.rdoSortHocKiAndYear.Size = new System.Drawing.Size(110, 21);
            this.rdoSortHocKiAndYear.TabIndex = 18;
            this.rdoSortHocKiAndYear.TabStop = true;
            this.rdoSortHocKiAndYear.Text = "Học kì - Năm";
            this.rdoSortHocKiAndYear.UseVisualStyleBackColor = true;
            this.rdoSortHocKiAndYear.CheckedChanged += new System.EventHandler(this.rdoSortBy_CheckedChanged);
            // 
            // rdoSortMoney
            // 
            this.rdoSortMoney.AutoSize = true;
            this.rdoSortMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSortMoney.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSortMoney.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoSortMoney.Location = new System.Drawing.Point(212, 24);
            this.rdoSortMoney.Name = "rdoSortMoney";
            this.rdoSortMoney.Size = new System.Drawing.Size(49, 21);
            this.rdoSortMoney.TabIndex = 17;
            this.rdoSortMoney.Text = "Phí";
            this.rdoSortMoney.UseVisualStyleBackColor = true;
            this.rdoSortMoney.CheckedChanged += new System.EventHandler(this.rdoSortBy_CheckedChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSort.Location = new System.Drawing.Point(67, 2);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(139, 19);
            this.lblSort.TabIndex = 14;
            this.lblSort.Text = "Sắp xếp danh sách";
            // 
            // rdoSortName
            // 
            this.rdoSortName.AutoSize = true;
            this.rdoSortName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSortName.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSortName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoSortName.Location = new System.Drawing.Point(124, 24);
            this.rdoSortName.Name = "rdoSortName";
            this.rdoSortName.Size = new System.Drawing.Size(82, 21);
            this.rdoSortName.TabIndex = 12;
            this.rdoSortName.Text = "Tên môn";
            this.rdoSortName.UseVisualStyleBackColor = true;
            this.rdoSortName.CheckedChanged += new System.EventHandler(this.rdoSortBy_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoInscrease);
            this.panel3.Controls.Add(this.rdoDescrease);
            this.panel3.Location = new System.Drawing.Point(41, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 26);
            this.panel3.TabIndex = 17;
            // 
            // rdoInscrease
            // 
            this.rdoInscrease.AutoSize = true;
            this.rdoInscrease.Checked = true;
            this.rdoInscrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoInscrease.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInscrease.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoInscrease.Location = new System.Drawing.Point(5, 3);
            this.rdoInscrease.Name = "rdoInscrease";
            this.rdoInscrease.Size = new System.Drawing.Size(85, 21);
            this.rdoInscrease.TabIndex = 12;
            this.rdoInscrease.TabStop = true;
            this.rdoInscrease.Text = "Tăng dần";
            this.rdoInscrease.UseVisualStyleBackColor = true;
            this.rdoInscrease.CheckedChanged += new System.EventHandler(this.radio_CheckedTypeSort);
            // 
            // rdoDescrease
            // 
            this.rdoDescrease.AutoSize = true;
            this.rdoDescrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDescrease.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDescrease.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoDescrease.Location = new System.Drawing.Point(105, 3);
            this.rdoDescrease.Name = "rdoDescrease";
            this.rdoDescrease.Size = new System.Drawing.Size(88, 21);
            this.rdoDescrease.TabIndex = 13;
            this.rdoDescrease.Text = "Giảm dần";
            this.rdoDescrease.UseVisualStyleBackColor = true;
            this.rdoDescrease.CheckedChanged += new System.EventHandler(this.radio_CheckedTypeSort);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Lavender;
            this.lblSearch.Location = new System.Drawing.Point(7, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(143, 19);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Tìm kiếm tên môn";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 27);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Snow;
            this.gbInfo.Controls.Add(this.txtSoTiet);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.cbbYear);
            this.gbInfo.Controls.Add(this.lblYear);
            this.gbInfo.Controls.Add(this.cbbHocKi);
            this.gbInfo.Controls.Add(this.lblHocKi);
            this.gbInfo.Controls.Add(this.lblMust);
            this.gbInfo.Controls.Add(this.ckMust);
            this.gbInfo.Controls.Add(this.btnAccept);
            this.gbInfo.Controls.Add(this.txtMoney);
            this.gbInfo.Controls.Add(this.lblMoney);
            this.gbInfo.Controls.Add(this.txtSoTC);
            this.gbInfo.Controls.Add(this.lblSoTC);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Enabled = false;
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.Purple;
            this.gbInfo.Location = new System.Drawing.Point(756, 226);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(390, 305);
            this.gbInfo.TabIndex = 13;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin môn";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoTiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(118, 99);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(107, 27);
            this.txtSoTiet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số Tiết";
            // 
            // cbbYear
            // 
            this.cbbYear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbYear.Location = new System.Drawing.Point(119, 204);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(106, 28);
            this.cbbYear.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Navy;
            this.lblYear.Location = new System.Drawing.Point(19, 205);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 19);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Năm";
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbHocKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbHocKi.Location = new System.Drawing.Point(119, 169);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(106, 28);
            this.cbbHocKi.TabIndex = 5;
            // 
            // lblHocKi
            // 
            this.lblHocKi.AutoSize = true;
            this.lblHocKi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKi.ForeColor = System.Drawing.Color.Navy;
            this.lblHocKi.Location = new System.Drawing.Point(19, 174);
            this.lblHocKi.Name = "lblHocKi";
            this.lblHocKi.Size = new System.Drawing.Size(55, 19);
            this.lblHocKi.TabIndex = 13;
            this.lblHocKi.Text = "Học kì";
            // 
            // lblMust
            // 
            this.lblMust.AutoSize = true;
            this.lblMust.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMust.ForeColor = System.Drawing.Color.Navy;
            this.lblMust.Location = new System.Drawing.Point(18, 243);
            this.lblMust.Name = "lblMust";
            this.lblMust.Size = new System.Drawing.Size(69, 19);
            this.lblMust.TabIndex = 12;
            this.lblMust.Text = "Bắt buộc";
            // 
            // ckMust
            // 
            this.ckMust.AutoSize = true;
            this.ckMust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckMust.Location = new System.Drawing.Point(118, 246);
            this.ckMust.Name = "ckMust";
            this.ckMust.Size = new System.Drawing.Size(18, 17);
            this.ckMust.TabIndex = 7;
            this.ckMust.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(247, 246);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(127, 48);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(118, 134);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(107, 27);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Navy;
            this.lblMoney.Location = new System.Drawing.Point(18, 139);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(32, 19);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "Phí";
            // 
            // txtSoTC
            // 
            this.txtSoTC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoTC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTC.Location = new System.Drawing.Point(119, 62);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(106, 27);
            this.txtSoTC.TabIndex = 2;
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTC.ForeColor = System.Drawing.Color.Navy;
            this.lblSoTC.Location = new System.Drawing.Point(19, 67);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(51, 19);
            this.lblSoTC.TabIndex = 6;
            this.lblSoTC.Text = "Số TC";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(119, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(19, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên môn";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(420, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 54);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá môn";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(756, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm môn";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbMajors
            // 
            this.gbMajors.Controls.Add(this.tvKhoa);
            this.gbMajors.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMajors.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbMajors.Location = new System.Drawing.Point(12, 20);
            this.gbMajors.Name = "gbMajors";
            this.gbMajors.Size = new System.Drawing.Size(681, 279);
            this.gbMajors.TabIndex = 19;
            this.gbMajors.TabStop = false;
            this.gbMajors.Text = "Danh sách ngành";
            // 
            // tvKhoa
            // 
            this.tvKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvKhoa.ForeColor = System.Drawing.Color.DarkCyan;
            this.tvKhoa.Location = new System.Drawing.Point(6, 26);
            this.tvKhoa.Name = "tvKhoa";
            treeNode2.Name = "nodeRoot";
            treeNode2.Text = "Khoa / Viện";
            this.tvKhoa.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvKhoa.Size = new System.Drawing.Size(659, 233);
            this.tvKhoa.TabIndex = 0;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            // 
            // rdoFilterMust
            // 
            this.rdoFilterMust.AutoSize = true;
            this.rdoFilterMust.BackColor = System.Drawing.Color.Transparent;
            this.rdoFilterMust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFilterMust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFilterMust.ForeColor = System.Drawing.Color.Maroon;
            this.rdoFilterMust.Location = new System.Drawing.Point(112, 26);
            this.rdoFilterMust.Name = "rdoFilterMust";
            this.rdoFilterMust.Size = new System.Drawing.Size(93, 21);
            this.rdoFilterMust.TabIndex = 20;
            this.rdoFilterMust.Text = "Bắt buộc";
            this.rdoFilterMust.UseVisualStyleBackColor = false;
            this.rdoFilterMust.CheckedChanged += new System.EventHandler(this.rdo_CheckedChangeFilter);
            // 
            // rdoFilterNotMust
            // 
            this.rdoFilterNotMust.AutoSize = true;
            this.rdoFilterNotMust.BackColor = System.Drawing.Color.Transparent;
            this.rdoFilterNotMust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFilterNotMust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFilterNotMust.ForeColor = System.Drawing.Color.Maroon;
            this.rdoFilterNotMust.Location = new System.Drawing.Point(239, 26);
            this.rdoFilterNotMust.Name = "rdoFilterNotMust";
            this.rdoFilterNotMust.Size = new System.Drawing.Size(143, 21);
            this.rdoFilterNotMust.TabIndex = 23;
            this.rdoFilterNotMust.Text = "Không bắt buộc";
            this.rdoFilterNotMust.UseVisualStyleBackColor = false;
            this.rdoFilterNotMust.CheckedChanged += new System.EventHandler(this.rdo_CheckedChangeFilter);
            // 
            // rdoFilterNormal
            // 
            this.rdoFilterNormal.AutoSize = true;
            this.rdoFilterNormal.BackColor = System.Drawing.Color.Transparent;
            this.rdoFilterNormal.Checked = true;
            this.rdoFilterNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFilterNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFilterNormal.ForeColor = System.Drawing.Color.Maroon;
            this.rdoFilterNormal.Location = new System.Drawing.Point(6, 26);
            this.rdoFilterNormal.Name = "rdoFilterNormal";
            this.rdoFilterNormal.Size = new System.Drawing.Size(89, 21);
            this.rdoFilterNormal.TabIndex = 21;
            this.rdoFilterNormal.TabStop = true;
            this.rdoFilterNormal.Text = "Toàn bộ";
            this.rdoFilterNormal.UseVisualStyleBackColor = false;
            this.rdoFilterNormal.CheckedChanged += new System.EventHandler(this.rdo_CheckedChangeFilter);
            // 
            // pnSubject
            // 
            this.pnSubject.BackColor = System.Drawing.Color.Teal;
            this.pnSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSubject.Controls.Add(this.panel5);
            this.pnSubject.Controls.Add(this.pictureBox1);
            this.pnSubject.Controls.Add(this.lblSearch);
            this.pnSubject.Controls.Add(this.groupBox1);
            this.pnSubject.Controls.Add(this.txtSearch);
            this.pnSubject.Controls.Add(this.btnAdd);
            this.pnSubject.Controls.Add(this.btnDelete);
            this.pnSubject.Controls.Add(this.gbInfo);
            this.pnSubject.Controls.Add(this.lvSubject);
            this.pnSubject.Enabled = false;
            this.pnSubject.Location = new System.Drawing.Point(12, 305);
            this.pnSubject.Name = "pnSubject";
            this.pnSubject.Size = new System.Drawing.Size(1157, 543);
            this.pnSubject.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(934, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.rdoFilterNotMust);
            this.groupBox1.Controls.Add(this.rdoFilterNormal);
            this.groupBox1.Controls.Add(this.rdoFilterMust);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 54);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc danh sách";
            // 
            // frmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1184, 860);
            this.Controls.Add(this.pnSubject);
            this.Controls.Add(this.gbMajors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMajors.ResumeLayout(false);
            this.pnSubject.ResumeLayout(false);
            this.pnSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSubject;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chMust;
        private System.Windows.Forms.ColumnHeader chSoTC;
        private System.Windows.Forms.ColumnHeader chMoney;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoInscrease;
        private System.Windows.Forms.RadioButton rdoDescrease;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton rdoSortName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoSortMoney;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbMajors;
        private System.Windows.Forms.Label lblMust;
        private System.Windows.Forms.CheckBox ckMust;
        private System.Windows.Forms.ColumnHeader chHocKi;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label lblHocKi;
        private System.Windows.Forms.RadioButton rdoFilterMust;
        private System.Windows.Forms.RadioButton rdoFilterNormal;
        private System.Windows.Forms.RadioButton rdoFilterNotMust;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.RadioButton rdoSortHocKiAndYear;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.Panel pnSubject;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader chSoTiet;
    }
}