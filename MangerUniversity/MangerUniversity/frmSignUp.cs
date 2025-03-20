using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            foreach (Control control in gbInfoAccount.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đầy đủ thông tin tài khoản!");
                        control.Focus();
                        return;
                    }
                }
            }

            foreach (Control control in gbInfoPerson.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đầy đủ thông tin cá nhân!");
                        control.Focus();
                        return;
                    }
                }
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Mật khẩu nhập lại không khớp!");
                txtRePassword.Focus();
                return;
            }
            if (!Person.isPhoneValid(txtPhone.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Số điện thoại không khả dụng!");
                txtRePassword.Focus();
                return;
            }
            if (!Person.isEmailValid(txtEmail.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Email không khả dụng!");
                txtRePassword.Focus();
                return;
            }

            Person info = new Person(txtID.Text, txtPhone.Text, txtName.Text, txtAddress.Text, txtEmail.Text, new Date(dtpBirth.Value));

            if (Account.signUp(txtNameAcct.Text, txtPassword.Text, info))
            {
                Close();
            }
        }
        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            txtRePassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
        }

        
    }
}
