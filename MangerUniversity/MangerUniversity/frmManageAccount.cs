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
    public partial class frmManageAccount : Form
    {
        public string ID;
        List<Person> people;
        Person currentPerson;
        public frmManageAccount(string ID)
        {
            InitializeComponent();
            this.ID = ID;
            Text = "Quản lý đại học - Quản lý tài khoản giảng viên và sinh viên - " + ID;
            cbbTypeSearch.SelectedIndex = 0;
            cbbSortBy.SelectedIndex = 0;
            currentPerson = null;
            reloadList();
        }

        void reloadCountAcct()
        {
            lblCountAccount.Text = "Số lượng: " + lvInfo.Items.Count.ToString();
        }


        void loadList()
        {
            lvInfo.Items.Clear();
            for (int i = 0; i < people.Count; i++)
            {
                string type;
                if (Student.isExistStudentID(people[i].getID()))
                {
                    type = "Sinh viên";
                }
                else
                {
                    type = "Giảng viên";
                }
                ListViewItem lvi = new ListViewItem()
                {
                    Text = people[i].getID(),
                };
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = people[i].getFullName().getFullName() });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = type });
                lvInfo.Items.Add(lvi);
            }
        }

        void removeListByCharName(char c)
        {
            c = char.ToLower(c);
            for (int i = 0; i < people.Count; i++)
            {
                bool remove = !people[i].getFullName().getFullName().ToLower().Contains(c);
                if (remove)
                {
                    people.RemoveAt(i);
                    i--;
                }
            }
        }

        void removeListByCharID(char c)
        {
            c = char.ToLower(c);
            for (int i = 0; i < people.Count; i++)
            {
                bool remove = !people[i].getID().ToLower().Contains(c);
                if (remove)
                {
                    people.RemoveAt(i);
                    i--;
                }
            }
        }

        void Search()
        {
            if (cbbTypeSearch.Text == cbbTypeSearch.Items[0].ToString()) //sắp xếp theo tên
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        removeListByCharName(txtSearch.Text[i]);
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        removeListByCharID(txtSearch.Text[i]);
                    }
                }
            }
        }

        void reloadList()
        {
            findAndSort();
            findAndFilter();
            Search();
            loadList();
            reloadCountAcct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            reloadList();
        }

        
        void findAndSort()
        {
            if (cbbSortBy.SelectedIndex == 0)
            {
                ckbIncrease.Enabled = false;
                people = Person.getPeopleExceptAdmin();
                return;
            }

            ckbIncrease.Enabled = true;
            if (cbbSortBy.SelectedIndex == 1)
            {
                people = Person.getPersonSorted("Ten", ckbIncrease.Checked);
            }
            else
            {
                people = Person.getPersonSorted("ID", ckbIncrease.Checked);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameAccount.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtAddress.Text) || txtID.Text[txtID.Text.Length - 1] == '-')
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đủ thông tin!");
                return;
            }
            if (string.IsNullOrEmpty(cbbTypeAcct.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn kiểu tài khoản!");
                return;
            }
            if (!Person.isPhoneValid(txtPhone.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Số điện thoại không hợp lệ!");
                return;
            }
            if (!Person.isEmailValid(txtEmail.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Email không hợp lệ!");
                return;
            }
            if (cbbTypeAcct.SelectedIndex == 0) //giảng viên
            {
                string tenKhoa = null;
                foreach (Control control in gbInfo.Controls)
                {
                    if (control.Name == "cbbTenKhoa")
                    {
                        tenKhoa = control.Text;
                    }
                }
                if (currentPerson == null)
                {
                    Teacher newTeacher = new Teacher(txtID.Text, txtPhone.Text, txtName.Text, txtAddress.Text, txtEmail.Text, new Date(dtpBirth.Value), tenKhoa);
                    if (!Account.signUp(txtNameAccount.Text, txtPassword.Text, newTeacher))
                    {
                        return;
                    }
                }
                else
                {
                    Account acct = new Account(txtNameAccount.Text, txtPassword.Text);
                    Teacher newTeacher = new Teacher(currentPerson.getID(), txtPhone.Text, txtName.Text, txtAddress.Text, txtEmail.Text, new Date(dtpBirth.Value), tenKhoa);
                    if (!acct.updateAccount(newTeacher, txtID.Text))
                    {
                        return;
                    }
                }
            }
            else
            {
                int year = 0;
                string nameMajor = null;
                int hocKi = 1;
                foreach (Control control in gbInfo.Controls)
                {
                    if (control.Name == "cbbNameMajor")
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn tên ngành học!");
                            return;
                        }
                        nameMajor = control.Text;
                    }
                    else if (control.Name == "cbbYear")
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn năm của sinh viên!");
                            return;
                        }
                        year = int.Parse(control.Text);
                    }
                    else if (control.Name == "cbbHocKi")
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn học kì của sinh viên!");
                            return;
                        }
                        hocKi = int.Parse(control.Text);
                    }
                }
                if (currentPerson == null)
                {
                    Student newStudent = new Student(txtID.Text, txtPhone.Text, txtName.Text, txtAddress.Text, txtEmail.Text, new Date(dtpBirth.Value), hocKi, year, nameMajor);
                    if (!Account.signUp(txtNameAccount.Text, txtPassword.Text, newStudent))
                    {
                        return;
                    }
                }
                else
                {
                    Account acct = new Account(txtNameAccount.Text, txtPassword.Text);
                    Student newStudent = new Student(currentPerson.getID(), txtPhone.Text, txtName.Text, txtAddress.Text, txtEmail.Text, new Date(dtpBirth.Value), hocKi, year, nameMajor);
                    if (!acct.updateAccount(newStudent, txtID.Text))
                    {
                        return;
                    }
                }
            }
            int index = -1;
            if (lvInfo.SelectedIndices.Count != 0)
            {
                index = lvInfo.SelectedIndices[0];
            }
            reloadList();
            if (index != -1)
            {
                lvInfo.SelectedIndices.Add(index);
            }
        }

        private void lvInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInfo.SelectedIndices.Count == 0)
            {
                currentPerson = null;
                pnInfo.Enabled = false;
                defaultGBInfo();
                return;
            }
            int index = lvInfo.SelectedIndices[0];
            ListViewItem lv = lvInfo.Items[index];
            string ID = lv.SubItems[0].Text;
            currentPerson = people[index];
            Account account = Account.getInfoByID(ID);
            cbbTypeAcct.SelectedIndex = -1;
            if (lv.SubItems[2].Text == "Sinh viên")
            {
                cbbTypeAcct.SelectedIndex = 1;
            }
            else
            {
                cbbTypeAcct.SelectedIndex = 0;
            }
            txtName.Text = currentPerson.getFullName().getFullName();
            txtPhone.Text = currentPerson.getPhone();
            txtEmail.Text = currentPerson.getEmail();
            txtAddress.Text = currentPerson.getAddress();
            txtID.Text = currentPerson.getID();
            txtNameAccount.Text = account.getName();
            txtPassword.Text = account.getPassword();
            dtpBirth.Value = currentPerson.getBirth().getDate();
            cbbTypeAcct.Enabled = false;
            pnInfo.Enabled = true;
        }

        Label getLabel(string name, string text, int X, int Y)
        {
            Label lbl = new Label()
            {
                Name = name,
                Text = text,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Location = new Point(X, Y),
            };
            return lbl;
        }

        ComboBox getCombobox(string name, int X, int Y)
        {
            ComboBox cbb = new ComboBox()
            {
                Font= new Font("Times New Roman", 10, FontStyle.Bold),
                ForeColor = Color.RoyalBlue,
                Name = name,
                Width = 301,
                DropDownStyle = ComboBoxStyle.DropDownList,
                AutoCompleteSource = AutoCompleteSource.ListItems,
                AutoCompleteMode = AutoCompleteMode.SuggestAppend,
                Location = new Point(X, Y),
                Cursor = Cursors.Hand,
            };
            return cbb;
        }

        void showMoreInfoTeacher()
        {
            gbInfo.Height = 440;
            Label lblTenKhoa = getLabel("lblTenKhoa", "Tên khoa", lblAddress.Left, lblAddress.Top + 50);
            gbInfo.Controls.Add(lblTenKhoa);
            ComboBox cbbTenKhoa = getCombobox("cbbTenKhoa", txtAddress.Left, lblTenKhoa.Top - 3);
            List<string> nameKhoa = new List<string>();
            List<Khoa> khoas = Khoa.getAllKhoa();
            for (int i = 0; i < khoas.Count; i++)
            {
                nameKhoa.Add(khoas[i].getName());
            }
            cbbTenKhoa.DataSource = nameKhoa;
            gbInfo.Controls.Add(cbbTenKhoa);
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Text = "GV-";
            }
            else
            {
                txtID.Text = "GV-" + txtID.Text.Substring(3);
            }
            if (currentPerson != null)
            {
                Teacher teacher = (Teacher)Teacher.getInfo("ID", currentPerson.getID());
                for (int i =0; i < cbbTenKhoa.Items.Count; i++)
                {
                    if (teacher.getTenKhoa() == cbbTenKhoa.Items[i].ToString())
                    {
                        cbbTenKhoa.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        void showMoreInfoStudent()
        {
            gbInfo.Height = 550;

            Label lblNameMajor = getLabel("lblNameMajor", "Tên ngành", lblAddress.Left, lblAddress.Top + 50);
            gbInfo.Controls.Add(lblNameMajor);
            ComboBox cbbNameMajor = getCombobox("cbbNameMajor", txtAddress.Left, lblNameMajor.Top - 3);
            List<string> nameMajor = new List<string>();
            List<Major> majors = Major.getAllMajor();
            cbbNameMajor.Items.Clear();
            for (int i = 0; i < majors.Count; i++)
            {
                cbbNameMajor.Items.Add(majors[i].getName());
            }
            cbbNameMajor.SelectedIndexChanged += cbbNameMajor_SelectedIndexChanged;
            gbInfo.Controls.Add(cbbNameMajor); 
            Label lblHocKi = getLabel("lblHocKi", "Học kì", lblNameMajor.Left, lblNameMajor.Top + 50);
            gbInfo.Controls.Add(lblHocKi);
            ComboBox cbbHocKi = getCombobox("cbbHocKi", txtAddress.Left, lblHocKi.Top - 3);
            for (int i = 1; i <= 2; i++)
            {
                cbbHocKi.Items.Add(i);
            }
            gbInfo.Controls.Add(cbbHocKi);
            Label lblYear = getLabel("lbllYear", "Năm", lblHocKi.Left, lblHocKi.Top + 50);
            gbInfo.Controls.Add(lblYear);
            ComboBox cbbYear = getCombobox("cbbYear", txtAddress.Left, lblYear.Top - 3);
            cbbHocKi.DropDownStyle = ComboBoxStyle.DropDownList;
            gbInfo.Controls.Add(cbbYear);
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Text = "SV-";
            }
            else
            {
                txtID.Text = "SV-" + txtID.Text.Substring(3);
            }
            if (currentPerson != null)
            {
                Student student = (Student)Student.getInfo("ID", currentPerson.getID());
                for (int i = 0; i < cbbNameMajor.Items.Count; i++)
                {
                    if (student.getNameMajor() == cbbNameMajor.Items[i].ToString())
                    {
                        cbbNameMajor.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbHocKi.Items.Count; i++)
                {
                    if (student.getHocKi().ToString() == cbbHocKi.Items[i].ToString())
                    {
                        cbbHocKi.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbYear.Items.Count; i++)
                {
                    if (student.getYear().ToString() == cbbYear.Items[i].ToString())
                    {
                        cbbYear.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {

                cbbNameMajor.SelectedIndex = -1;
            }
        }

        private void cbbTypeAcct_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTextInfo();
            if (cbbTypeAcct.SelectedIndex == -1)
            {
                return;
            }
            if (cbbTypeAcct.SelectedIndex == 0)
            {
                showMoreInfoTeacher();
            }
            else
            {
                showMoreInfoStudent();
            }
        }

        private void cbbNameMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbbNameMajor = (ComboBox)sender;
            if (cbbNameMajor.SelectedIndex == -1)
            {
                return;
            }
            string nameMajor = cbbNameMajor.Text;
            int years = (int)Major.getField("SoNam", "Ten", nameMajor);
            List<int> datas = new List<int>();
            for (int i = 1; i <= years; i++)
            {
                datas.Add(i);
            }
            foreach (Control control in gbInfo.Controls)
            {
                if (control.Name == "cbbYear")
                {
                    ComboBox cbb = (ComboBox)control;
                    cbb.DataSource = datas;
                    return;
                }
            }
        }

        void findAndFilter()
        {
            if (rdoTeacher.Checked)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (Student.isExistStudentID(people[i].getID()))
                    {
                        people.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (rdoStudent.Checked)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (Teacher.isExistTeacherID(people[i].getID()))
                    {
                        people.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void rdoFilter_CheckedChanged(object sender, EventArgs e)
        {
            reloadList();
        }

        void defaultGBInfo()
        {
            for (int i = 0; i < gbInfo.Controls.Count; i++)
            {
                if (gbInfo.Controls[i].Name == "lblTenKhoa" || gbInfo.Controls[i].Name == "cbbTenKhoa" || gbInfo.Controls[i].Name == "lblNameMajor" || gbInfo.Controls[i].Name == "cbbNameMajor" || gbInfo.Controls[i].Name == "lblYear" || gbInfo.Controls[i].Name == "cbbYear" || gbInfo.Controls[i].Name == "lblHocKi" || gbInfo.Controls[i].Name == "cbbHocKi")
                {
                    gbInfo.Controls.RemoveAt(i);
                    i--;
                }
            }
            clearTextAccount();
            clearTextInfo();
        }

        void clearTextAccount()
        {
            foreach (Control control in gbAccount.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        void clearTextInfo()
        {
            foreach (Control control in gbInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lvInfo.SelectedIndices.Clear();
            defaultGBInfo();
            gbInfo.Height = 397;
            cbbTypeAcct.SelectedIndex = -1;
            cbbTypeAcct.Enabled = true;
            currentPerson = null;
            pnInfo.Enabled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if (!string.IsNullOrEmpty(txtID.Text) && txtID.Text[txtID.Text.Length - 1] == '-')
                {
                    e.Handled = true;
                }
            }
            else if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar > 30))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắn chắn muốn xoá các tài khoản đã check?") != DialogResult.Yes)
            {
                return;
            }
            for (int i = 0; i < lvInfo.CheckedIndices.Count; i++)
            {
                string ID = lvInfo.Items[lvInfo.CheckedIndices[i]].SubItems[0].Text;
                if (Student.isExistStudentID(ID))
                {
                    Student.deleteStudent(ID);
                }
                else
                {
                    Teacher.deleteTeacher(ID);
                }
            }
            reloadList();
            btnDelete.Enabled = false;
            currentPerson = null;
        }

        private void ckbIncrease_CheckedChanged(object sender, EventArgs e)
        {
            reloadList();
        }

        private void cbbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadList();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPassword.Checked;
        }

        private void lvInfo_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvInfo.CheckedIndices.Count != 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
