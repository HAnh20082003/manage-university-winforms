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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (Control control in gbInfo.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đủ thông tin!");
                    control.Focus();
                    return;
                }
            }
            if (!Account.isPasswordValid(txtNewPassword.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Mật khẩu mới không hợp lệ!");
                txtNewPassword.Focus();
                return;
            }
            if (txtNewPassword.Text != txtReNewPassword.Text)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Mật khẩu nhập lại không khớp!");
                txtReNewPassword.Focus();
                return;
            }
            if (!Account.isExistsName(txtNameAcct.Text))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Tên tài khoản không tồn tại!");
                txtNameAcct.Focus();
                return;
            }
            Account acct = new Account(txtNameAcct.Text);
            if (acct.getPassword() != txtOldPassword.Text)
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Mật khẩu không chính xác!");
                txtOldPassword.Focus();
                return;
            }
            if (Account.updateField(acct.getID(), "TenTK", txtNewPassword.Text))
            {
                MessageInfo.makeMessage("Information", "Chúc mừng", "Đổi mật khẩu thành công!");
                Close();
            }
            else
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Đổi mật khẩu thất bại!");
            }
        }

        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                if (e.KeyChar == ' ' || char.IsSymbol(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar > 30))
                {
                    e.Handled = true;
                }
            }
        }
        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            txtReNewPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
        }
    }
}
