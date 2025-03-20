using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    public partial class frmForgotPassword : Form
    {
        public int lengthPass = 8;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void selectAccept(object sender, EventArgs e)
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
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Mật khẩu phải tối thiểu 8 kí tự, bao gồm chữ cái in hoa, in thường, số và kí tự đặc biệt!!!");
                return;
            }
            if (txtRePassword.Text != txtNewPassword.Text)
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Mật khẩu nhập lại không trùng khớp!");
            }

            try
            {
                string id = (string)Person.getFieldPerson("ID", "SDT", txtPhone.Text);
                Account acct = Account.getInfoByID(id);
                Account.updateField(acct.getID(), "MatKhau", txtNewPassword.Text);
                MessageInfo.makeMessage("Information", "Chúc mừng", "Đã đổi mật khẩu thành công!!");
                Close();
            }
            catch
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Không tồn tại tài khoản có số điện thoại đã nhập!!");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
            txtRePassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
        }
    }
}
