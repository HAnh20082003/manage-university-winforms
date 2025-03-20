
namespace MangerUniversity
{
    partial class frmManageKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageKhoa));
            this.btnDelete = new System.Windows.Forms.Button();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.pnClass = new System.Windows.Forms.Panel();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.txtCountMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnMajor = new System.Windows.Forms.Panel();
            this.txtCountYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameMajor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.txtNameKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.pnClass.SuspendLayout();
            this.pnMajor.SuspendLayout();
            this.pnKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(34, 633);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 56);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tvKhoa
            // 
            this.tvKhoa.BackColor = System.Drawing.Color.LightCyan;
            this.tvKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvKhoa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvKhoa.Location = new System.Drawing.Point(33, 77);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(557, 540);
            this.tvKhoa.TabIndex = 14;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách các khoa";
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.gbInfo.Controls.Add(this.pnClass);
            this.gbInfo.Controls.Add(this.pnMajor);
            this.gbInfo.Controls.Add(this.pnKhoa);
            this.gbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.GhostWhite;
            this.gbInfo.Location = new System.Drawing.Point(628, 77);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(515, 471);
            this.gbInfo.TabIndex = 16;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // pnClass
            // 
            this.pnClass.BackColor = System.Drawing.Color.MintCream;
            this.pnClass.Controls.Add(this.cbbMaGV);
            this.pnClass.Controls.Add(this.txtCountMax);
            this.pnClass.Controls.Add(this.label7);
            this.pnClass.Controls.Add(this.txtNameClass);
            this.pnClass.Controls.Add(this.label6);
            this.pnClass.Controls.Add(this.label5);
            this.pnClass.Location = new System.Drawing.Point(23, 289);
            this.pnClass.Name = "pnClass";
            this.pnClass.Size = new System.Drawing.Size(470, 167);
            this.pnClass.TabIndex = 4;
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(120, 117);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(147, 31);
            this.cbbMaGV.TabIndex = 6;
            // 
            // txtCountMax
            // 
            this.txtCountMax.Location = new System.Drawing.Point(119, 68);
            this.txtCountMax.Name = "txtCountMax";
            this.txtCountMax.Size = new System.Drawing.Size(291, 30);
            this.txtCountMax.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sỉ số tối đa";
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(119, 19);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(291, 30);
            this.txtNameClass.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã GV";
            // 
            // pnMajor
            // 
            this.pnMajor.BackColor = System.Drawing.Color.MintCream;
            this.pnMajor.Controls.Add(this.txtCountYear);
            this.pnMajor.Controls.Add(this.label4);
            this.pnMajor.Controls.Add(this.txtNameMajor);
            this.pnMajor.Controls.Add(this.label3);
            this.pnMajor.Location = new System.Drawing.Point(23, 138);
            this.pnMajor.Name = "pnMajor";
            this.pnMajor.Size = new System.Drawing.Size(470, 122);
            this.pnMajor.TabIndex = 2;
            // 
            // txtCountYear
            // 
            this.txtCountYear.Location = new System.Drawing.Point(119, 66);
            this.txtCountYear.Name = "txtCountYear";
            this.txtCountYear.Size = new System.Drawing.Size(291, 30);
            this.txtCountYear.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số năm";
            // 
            // txtNameMajor
            // 
            this.txtNameMajor.Location = new System.Drawing.Point(119, 19);
            this.txtNameMajor.Name = "txtNameMajor";
            this.txtNameMajor.Size = new System.Drawing.Size(291, 30);
            this.txtNameMajor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên ngành";
            // 
            // pnKhoa
            // 
            this.pnKhoa.BackColor = System.Drawing.Color.MintCream;
            this.pnKhoa.Controls.Add(this.txtNameKhoa);
            this.pnKhoa.Controls.Add(this.label2);
            this.pnKhoa.Location = new System.Drawing.Point(23, 42);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(470, 62);
            this.pnKhoa.TabIndex = 0;
            // 
            // txtNameKhoa
            // 
            this.txtNameKhoa.Location = new System.Drawing.Point(119, 15);
            this.txtNameKhoa.Name = "txtNameKhoa";
            this.txtNameKhoa.Size = new System.Drawing.Size(291, 30);
            this.txtNameKhoa.TabIndex = 1;
            this.txtNameKhoa.TextChanged += new System.EventHandler(this.txtNameKhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Lavender;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAccept.FlatAppearance.BorderSize = 3;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(628, 563);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 54);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmManageKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1172, 710);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa, ngành và thêm lớp";
            this.gbInfo.ResumeLayout(false);
            this.pnClass.ResumeLayout(false);
            this.pnClass.PerformLayout();
            this.pnMajor.ResumeLayout(false);
            this.pnMajor.PerformLayout();
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnClass;
        private System.Windows.Forms.TextBox txtCountMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnMajor;
        private System.Windows.Forms.TextBox txtCountYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnKhoa;
        private System.Windows.Forms.TextBox txtNameKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaGV;
    }
}