
namespace MangerUniversity
{
    partial class frmDateAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDateAssign));
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblNameSubject = new System.Windows.Forms.Label();
            this.fpnDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblMaLop.Location = new System.Drawing.Point(31, 41);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(69, 23);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp";
            // 
            // lblNameSubject
            // 
            this.lblNameSubject.AutoSize = true;
            this.lblNameSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSubject.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNameSubject.Location = new System.Drawing.Point(31, 91);
            this.lblNameSubject.Name = "lblNameSubject";
            this.lblNameSubject.Size = new System.Drawing.Size(116, 23);
            this.lblNameSubject.TabIndex = 1;
            this.lblNameSubject.Text = "Tên môn học";
            // 
            // fpnDate
            // 
            this.fpnDate.AutoScroll = true;
            this.fpnDate.BackColor = System.Drawing.Color.LightCyan;
            this.fpnDate.Location = new System.Drawing.Point(35, 208);
            this.fpnDate.Name = "fpnDate";
            this.fpnDate.Size = new System.Drawing.Size(792, 121);
            this.fpnDate.TabIndex = 2;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblMaGV.Location = new System.Drawing.Point(31, 148);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(73, 23);
            this.lblMaGV.TabIndex = 3;
            this.lblMaGV.Text = "Mã GV";
            // 
            // frmDateAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 379);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.fpnDate);
            this.Controls.Add(this.lblNameSubject);
            this.Controls.Add(this.lblMaLop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDateAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch học của môn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNameSubject;
        private System.Windows.Forms.FlowLayoutPanel fpnDate;
        private System.Windows.Forms.Label lblMaGV;
    }
}