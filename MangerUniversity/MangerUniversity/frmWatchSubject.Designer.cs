
namespace MangerUniversity
{
    partial class frmWatchSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatchSubject));
            this.gbMajor = new System.Windows.Forms.GroupBox();
            this.fpnMajor = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.fpnSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMajor.SuspendLayout();
            this.gbSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMajor
            // 
            this.gbMajor.Controls.Add(this.fpnMajor);
            this.gbMajor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMajor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbMajor.Location = new System.Drawing.Point(22, 27);
            this.gbMajor.Name = "gbMajor";
            this.gbMajor.Size = new System.Drawing.Size(410, 420);
            this.gbMajor.TabIndex = 0;
            this.gbMajor.TabStop = false;
            this.gbMajor.Text = "Danh sách ngành học thuộc khoa";
            // 
            // fpnMajor
            // 
            this.fpnMajor.AutoScroll = true;
            this.fpnMajor.BackColor = System.Drawing.Color.LemonChiffon;
            this.fpnMajor.Location = new System.Drawing.Point(11, 67);
            this.fpnMajor.Name = "fpnMajor";
            this.fpnMajor.Size = new System.Drawing.Size(380, 335);
            this.fpnMajor.TabIndex = 0;
            // 
            // gbSubject
            // 
            this.gbSubject.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbSubject.Controls.Add(this.cbbYear);
            this.gbSubject.Controls.Add(this.fpnSubject);
            this.gbSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubject.Location = new System.Drawing.Point(582, 27);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(570, 602);
            this.gbSubject.TabIndex = 1;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Môn học";
            // 
            // cbbYear
            // 
            this.cbbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(383, 16);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(159, 31);
            this.cbbYear.TabIndex = 2;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // fpnSubject
            // 
            this.fpnSubject.AutoScroll = true;
            this.fpnSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnSubject.Location = new System.Drawing.Point(12, 53);
            this.fpnSubject.Name = "fpnSubject";
            this.fpnSubject.Size = new System.Drawing.Size(549, 503);
            this.fpnSubject.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmWatchSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1191, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbMajor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWatchSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem môn học thuộc khoa";
            this.gbMajor.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMajor;
        private System.Windows.Forms.FlowLayoutPanel fpnMajor;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.FlowLayoutPanel fpnSubject;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}