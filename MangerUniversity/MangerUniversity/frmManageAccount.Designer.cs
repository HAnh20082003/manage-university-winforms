
namespace MangerUniversity
{
    partial class frmManageAccount
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
            System.Windows.Forms.Button btnAdd;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAccount));
            this.lvInfo = new System.Windows.Forms.ListView();
            this.chIDTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTypeAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ckbIncrease = new System.Windows.Forms.CheckBox();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.cbbTypeSearch = new System.Windows.Forms.ComboBox();
            this.lblCountAccount = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblTypeAcct = new System.Windows.Forms.Label();
            this.cbbTypeAcct = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNameAccount = new System.Windows.Forms.Label();
            this.txtNameAccount = new System.Windows.Forms.TextBox();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdd.ForeColor = System.Drawing.Color.Lavender;
            btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdd.Location = new System.Drawing.Point(30, 723);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(175, 57);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Thêm tài khoản";
            btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.CheckBoxes = true;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIDTeacher,
            this.chNameTeacher,
            this.chTypeAccount});
            this.lvInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(30, 278);
            this.lvInfo.MultiSelect = false;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.ShowItemToolTips = true;
            this.lvInfo.Size = new System.Drawing.Size(496, 409);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvInfo_ItemChecked);
            this.lvInfo.SelectedIndexChanged += new System.EventHandler(this.lvInfo_SelectedIndexChanged);
            // 
            // chIDTeacher
            // 
            this.chIDTeacher.Text = "Mã ID";
            this.chIDTeacher.Width = 105;
            // 
            // chNameTeacher
            // 
            this.chNameTeacher.Text = "Họ tên";
            this.chNameTeacher.Width = 216;
            // 
            // chTypeAccount
            // 
            this.chTypeAccount.Text = "Loại tài khoản";
            this.chTypeAccount.Width = 171;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 169);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 27);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblSearch.Location = new System.Drawing.Point(32, 138);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 23);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // ckbIncrease
            // 
            this.ckbIncrease.AutoSize = true;
            this.ckbIncrease.Checked = true;
            this.ckbIncrease.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbIncrease.ForeColor = System.Drawing.Color.Yellow;
            this.ckbIncrease.Location = new System.Drawing.Point(212, 44);
            this.ckbIncrease.Name = "ckbIncrease";
            this.ckbIncrease.Size = new System.Drawing.Size(97, 23);
            this.ckbIncrease.TabIndex = 34;
            this.ckbIncrease.Text = "Tăng dần";
            this.ckbIncrease.UseVisualStyleBackColor = true;
            this.ckbIncrease.CheckedChanged += new System.EventHandler(this.ckbIncrease_CheckedChanged);
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Items.AddRange(new object[] {
            "Mặc định",
            "Họ tên",
            "Mã ID"});
            this.cbbSortBy.Location = new System.Drawing.Point(21, 40);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(164, 27);
            this.cbbSortBy.TabIndex = 33;
            this.cbbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbbSortBy_SelectedIndexChanged);
            // 
            // cbbTypeSearch
            // 
            this.cbbTypeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeSearch.FormattingEnabled = true;
            this.cbbTypeSearch.Items.AddRange(new object[] {
            "Theo tên",
            "Theo ID"});
            this.cbbTypeSearch.Location = new System.Drawing.Point(305, 171);
            this.cbbTypeSearch.Name = "cbbTypeSearch";
            this.cbbTypeSearch.Size = new System.Drawing.Size(80, 24);
            this.cbbTypeSearch.TabIndex = 11;
            // 
            // lblCountAccount
            // 
            this.lblCountAccount.AutoSize = true;
            this.lblCountAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountAccount.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountAccount.Location = new System.Drawing.Point(383, 701);
            this.lblCountAccount.Name = "lblCountAccount";
            this.lblCountAccount.Size = new System.Drawing.Size(143, 20);
            this.lblCountAccount.TabIndex = 12;
            this.lblCountAccount.Text = "Số lượng tài khoản";
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbInfo.Controls.Add(this.lblTypeAcct);
            this.gbInfo.Controls.Add(this.cbbTypeAcct);
            this.gbInfo.Controls.Add(this.dtpBirth);
            this.gbInfo.Controls.Add(this.lblAddress);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.txtID);
            this.gbInfo.Controls.Add(this.txtEmail);
            this.gbInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.gbInfo.Location = new System.Drawing.Point(22, 228);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(478, 398);
            this.gbInfo.TabIndex = 13;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin người dùng";
            // 
            // lblTypeAcct
            // 
            this.lblTypeAcct.AutoSize = true;
            this.lblTypeAcct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAcct.ForeColor = System.Drawing.Color.Yellow;
            this.lblTypeAcct.Location = new System.Drawing.Point(27, 48);
            this.lblTypeAcct.Name = "lblTypeAcct";
            this.lblTypeAcct.Size = new System.Drawing.Size(115, 19);
            this.lblTypeAcct.TabIndex = 30;
            this.lblTypeAcct.Text = "Loại tài khoản";
            // 
            // cbbTypeAcct
            // 
            this.cbbTypeAcct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeAcct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeAcct.ForeColor = System.Drawing.Color.Black;
            this.cbbTypeAcct.FormattingEnabled = true;
            this.cbbTypeAcct.Items.AddRange(new object[] {
            "Giảng viên",
            "Sinh viên"});
            this.cbbTypeAcct.Location = new System.Drawing.Point(146, 48);
            this.cbbTypeAcct.Name = "cbbTypeAcct";
            this.cbbTypeAcct.Size = new System.Drawing.Size(301, 27);
            this.cbbTypeAcct.TabIndex = 28;
            this.cbbTypeAcct.SelectedIndexChanged += new System.EventHandler(this.cbbTypeAcct_SelectedIndexChanged);
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpBirth.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.dtpBirth.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.dtpBirth.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpBirth.CalendarTrailingForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Location = new System.Drawing.Point(146, 196);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(301, 27);
            this.dtpBirth.TabIndex = 21;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lblAddress.Location = new System.Drawing.Point(27, 343);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 19);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(27, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Yellow;
            this.label.Location = new System.Drawing.Point(27, 196);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 19);
            this.label.TabIndex = 27;
            this.label.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(27, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(27, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(147, 343);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 27);
            this.txtAddress.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(146, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 27);
            this.txtName.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(147, 243);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 27);
            this.txtPhone.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(146, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(301, 27);
            this.txtID.TabIndex = 16;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(147, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 27);
            this.txtEmail.TabIndex = 19;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Teal;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAccept.FlatAppearance.BorderSize = 3;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Lavender;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(537, 228);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(142, 57);
            this.btnAccept.TabIndex = 29;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // gbAccount
            // 
            this.gbAccount.BackColor = System.Drawing.Color.Transparent;
            this.gbAccount.Controls.Add(this.ckbShowPassword);
            this.gbAccount.Controls.Add(this.label7);
            this.gbAccount.Controls.Add(this.lblPassword);
            this.gbAccount.Controls.Add(this.txtPassword);
            this.gbAccount.Controls.Add(this.lblNameAccount);
            this.gbAccount.Controls.Add(this.txtNameAccount);
            this.gbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccount.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.gbAccount.Location = new System.Drawing.Point(22, 12);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(662, 210);
            this.gbAccount.TabIndex = 20;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Thông tin tài khoản";
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShowPassword.ForeColor = System.Drawing.Color.Yellow;
            this.ckbShowPassword.Location = new System.Drawing.Point(384, 100);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(134, 21);
            this.ckbShowPassword.TabIndex = 18;
            this.ckbShowPassword.Text = "Hiện mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(135, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(522, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mật khẩu phải tối thiểu 8 kí tự, bao gồm chữ cái in hoa, in thường, số và kí tự đ" +
    "ặc biệt";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblPassword.Location = new System.Drawing.Point(15, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.Location = new System.Drawing.Point(138, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNameAccount
            // 
            this.lblNameAccount.AutoSize = true;
            this.lblNameAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAccount.ForeColor = System.Drawing.Color.Yellow;
            this.lblNameAccount.Location = new System.Drawing.Point(15, 48);
            this.lblNameAccount.Name = "lblNameAccount";
            this.lblNameAccount.Size = new System.Drawing.Size(108, 19);
            this.lblNameAccount.TabIndex = 16;
            this.lblNameAccount.Text = "Tên tài khoản";
            // 
            // txtNameAccount
            // 
            this.txtNameAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNameAccount.Location = new System.Drawing.Point(138, 45);
            this.txtNameAccount.Name = "txtNameAccount";
            this.txtNameAccount.Size = new System.Drawing.Size(224, 27);
            this.txtNameAccount.TabIndex = 7;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnInfo.Controls.Add(this.btnDelete);
            this.pnInfo.Controls.Add(this.btnAccept);
            this.pnInfo.Controls.Add(this.gbAccount);
            this.pnInfo.Controls.Add(this.gbInfo);
            this.pnInfo.Enabled = false;
            this.pnInfo.Location = new System.Drawing.Point(544, 15);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(699, 791);
            this.pnInfo.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Lavender;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(537, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 56);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xoá TK";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rdoAll);
            this.gbFilter.Controls.Add(this.rdoStudent);
            this.gbFilter.Controls.Add(this.rdoTeacher);
            this.gbFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.Lavender;
            this.gbFilter.Location = new System.Drawing.Point(30, 209);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(355, 54);
            this.gbFilter.TabIndex = 31;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc danh sách";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAll.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdoAll.Location = new System.Drawing.Point(16, 26);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(74, 23);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Tất cả";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoFilter_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoStudent.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdoStudent.Location = new System.Drawing.Point(243, 26);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(98, 23);
            this.rdoStudent.TabIndex = 1;
            this.rdoStudent.Text = "Sinh viên";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoFilter_CheckedChanged);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTeacher.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdoTeacher.Location = new System.Drawing.Point(119, 26);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(111, 23);
            this.rdoTeacher.TabIndex = 0;
            this.rdoTeacher.Text = "Giảng viên";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoFilter_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.ckbIncrease);
            this.gbSort.Controls.Add(this.cbbSortBy);
            this.gbSort.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSort.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.gbSort.Location = new System.Drawing.Point(30, 28);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(324, 91);
            this.gbSort.TabIndex = 33;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sắp xếp danh sách";
            // 
            // frmManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1255, 818);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.cbbTypeSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(btnAdd);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.lblCountAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader chNameTeacher;
        private System.Windows.Forms.ColumnHeader chIDTeacher;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbbTypeSearch;
        private System.Windows.Forms.Label lblCountAccount;
        private System.Windows.Forms.ColumnHeader chTypeAccount;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbTypeAcct;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTypeAcct;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNameAccount;
        private System.Windows.Forms.TextBox txtNameAccount;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoTeacher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.CheckBox ckbIncrease;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.GroupBox gbSort;
    }
}