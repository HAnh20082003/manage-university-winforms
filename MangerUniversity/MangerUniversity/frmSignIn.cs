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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            foreach (Control control in gbSignIn.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đầy đủ thông tin!!!");
                        control.Focus();
                        return;
                    }
                }
            }
            if (!Account.isExistsName(txtNameAcct.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên tài khoản không tồn tại!");
                txtNameAcct.Focus();
                return;
            }
            if (!Account.isRightPassword(txtNameAcct.Text, txtPassword.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Mật khẩu không đúng!");
                txtNameAcct.Focus();
                return;
            }

            Hide();
            Person info = Account.getInfoByName(txtNameAcct.Text);
            string typeAccount;
            if (info is Student)
            {
                typeAccount = Account.typeSV;
            }
            else if (info is Teacher)
            {
                typeAccount = Account.typeGV;
            }
            else
            {
                typeAccount = Account.typeQT;
            }
            frmManageSchool frm = new frmManageSchool(typeAccount, txtNameAcct.Text   );
            frm.ShowDialog();
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
            Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Hide();
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
            Show();
        }
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Hide();
            frmForgotPassword frm = new frmForgotPassword();
            frm.ShowDialog();
            Show();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
        }

        private void lblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Navy;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Olive;
        }

        
    }
}
