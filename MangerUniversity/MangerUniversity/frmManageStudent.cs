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
    public partial class frmManageStudent : Form
    {
        Teacher teacher;
        InfoAssignTeacher currentAssignSubject;
        Account currentAcct;

        public frmManageStudent(string nameAcct)
        {
            InitializeComponent();
            int percent = 10;
            while(percent != 100)
            {
                cbbPercentKTDK.Items.Add(percent + "%");
                cbbPercentKTHP.Items.Add(percent + "%");
                percent += 10;
            }

            cbbPercentKTDK.SelectedIndex = 4;
            txtPhone.KeyPress += General.number_KeyPress;

            teacher = (Teacher) Account.getInfoByName(nameAcct);
            loadMainClassStudents();
            loadClassTeach();
        }

        private void changePercent_ComboBox(object sender, EventArgs e)
        {
            if (cbbPercentKTDK.SelectedIndex == cbbPercentKTHP.Items.Count - cbbPercentKTHP.SelectedIndex - 1)
            {
                return;
            }
            ComboBox currentCbb = (ComboBox)sender;
            if (currentCbb == cbbPercentKTDK)
            {
                cbbPercentKTHP.SelectedIndex = currentCbb.Items.Count - currentCbb.SelectedIndex - 1;
            }
            else
            {
                cbbPercentKTDK.SelectedIndex = currentCbb.Items.Count - currentCbb.SelectedIndex - 1;
            }

        }

        void loadMainClassStudents()
        {
            lvMainClass.Items.Clear();

            List<Student> students = teacher.getMyMainClass();
            if (students == null)
            {
                return;
            }
            for (int i =0; i<students.Count; i++)
            {
                ListViewItem li = new ListViewItem()
                {
                    Text = students[i].getID(),
                };
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = students[i].getFullName().getFullName() });
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = students[i].getBirth().getStrDate('-')});
                lvMainClass.Items.Add(li);
            }
        }

        private void selectInfoAssign(object sender, EventArgs e)
        {
            currentAssignSubject = (InfoAssignTeacher)((Control)sender).Tag;
            cbbStudent.SelectedIndex = -1;
            cbbStudent.SelectedIndex = 0;
        }

        private void cbbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStudent.SelectedIndex == -1)
            {
                return;
            }
            lvStudentLearn.Items.Clear();
            List<Student> students = InfoAssignSubject.getStudentsAssignSubject(currentAssignSubject.getMaLop());
            for (int j = 0; j < students.Count; j++)
            {
                List<InfoAssignSubject> infoAssigns = InfoAssignSubject.getAssign(students[j].getID(), currentAssignSubject.getMaLop());
                for (int i = 0; i < infoAssigns.Count; i++)
                {
                    if (cbbStudent.SelectedIndex == 0)
                    {
                        if (students[j].getHocKi() != infoAssigns[i].getHocKi() || students[j].getYear() != infoAssigns[i].getYear())
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (students[j].getHocKi() == infoAssigns[i].getHocKi() && students[j].getYear() == infoAssigns[i].getYear())
                        {
                            continue;
                        }
                    }
                    ListViewItem li = new ListViewItem()
                    {
                        Text = students[j].getID(),
                    };
                    li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = students[j].getFullName().getFullName() });
                    li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = infoAssigns[i].getHocKi().ToString() });
                    li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = infoAssigns[i].getYear().ToString() });
                    lvStudentLearn.Items.Add(li);
                }
            }
            clearText();
        }

        GroupBox getGroupInfoAssign(InfoAssignTeacher infoAssign)
        {
            GroupBox gb = new GroupBox()
            {
                Size = new Size(500, 150),
                Cursor = Cursors.Hand,
                Tag = infoAssign,
                BackColor = Color.LavenderBlush,
            };

            int xstart = 5, yStart = 10;
            Label lblMaLop = new Label()
            {
                Text = "Mã lớp: " + infoAssign.getMaLop(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaLop);
            yStart += 27;
            Label lblNameSubject = new Label()
            {
                Text = "Tên môn: " + infoAssign.getNameSubject(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameSubject);
            yStart += 27;
            List<Student> students = InfoAssignSubject.getStudentsAssignSubject(infoAssign.getMaLop());
            Label lblCount = new Label()
            {
                Text = "Số lượng sinh viên: " + students.Count,
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblCount);
            yStart += 27;
            gb.Click += selectInfoAssign;
            return gb;
        }
        void loadClassTeach()
        {
            fpnClassTeach.Controls.Clear();
            List<InfoAssignTeacher> infoAssigns = teacher.getInfoAssign();
            for (int i = 0; i < infoAssigns.Count; i++)
            {
                fpnClassTeach.Controls.Add(getGroupInfoAssign(infoAssigns[i]));
            }
            currentAssignSubject = null;
            lvStudentLearn.Items.Clear();
            clearText();
        }

        private void keyPressInputValueMark(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar > 30)))
            {
                e.Handled = true;
            }
        }

        private void inputValueMark(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKTDK.Text) || string.IsNullOrEmpty(txtKTHP.Text))
            {
                lblSum.Text = "Tổng điểm: 0";
                return;
            }

            double ptA = double.Parse(txtKTDK.Text);
            double ptB = double.Parse(txtKTHP.Text);
            double result = ptA * (cbbPercentKTDK.SelectedIndex + 1) / 10 + ptB * (cbbPercentKTHP.SelectedIndex + 1) / 10;
            lblSum.Text = "Tổng điểm: " + result;
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKTDK.Text) || string.IsNullOrEmpty(txtKTHP.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Điểm không thể để trống!");
                return;
            }
            int percentKTDK = (cbbPercentKTDK.SelectedIndex + 1) * 10;
            List<MarkSubject> pointSubs = MarkSubject.getAllPoint();
            for (int i = 0; i < pointSubs.Count; i++)
            {
                pointSubs[i].updateMarkSubject(pointSubs[i].getKTDK(), pointSubs[i].getKTHP(), percentKTDK);
            }
            Student student = (Student)Person.getInfo("ID", currentAcct.getID());
            InfoAssignSubject infoAssign = InfoAssignSubject.getInfo(student.getID(), currentAssignSubject.getMaLop(), student.getHocKi(), student.getYear());
            
            if (MarkSubject.isExistsMarkSubject(currentAcct.getID(), currentAssignSubject.getMaLop(), infoAssign.getHocKi(), infoAssign.getYear()))
            {
                MarkSubject mark = MarkSubject.getInfo(currentAssignSubject.getMaLop(), student.getID(), infoAssign.getHocKi(), infoAssign.getYear());
                ;if (!mark.updateMarkSubject(double.Parse(txtKTDK.Text), double.Parse(txtKTHP.Text), percentKTDK))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Lưu điểm thất bại!");
                }
                else
                {
                    clearText();
                    lvStudentLearn.SelectedItems.Clear();
                }
            }
            else
            {
                MarkSubject mark = new MarkSubject(currentAcct.getID(), currentAssignSubject.getMaLop(), double.Parse(txtKTDK.Text), double.Parse(txtKTHP.Text), percentKTDK, infoAssign.getHocKi(), infoAssign.getYear());

                if (mark.insertMark())
                {
                    clearText();
                    lvStudentLearn.SelectedItems.Clear();
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Lưu điểm thất bại!");
                }
            }
        }

        void clearText()
        {
            txtID.Clear();
            txtName.Clear();
            dtpBirth.Value = DateTime.Now;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtKTDK.Clear();
            txtKTHP.Clear();
            cbbPercentKTDK.SelectedIndex = 4;
        }


        private void lvMainClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMainClass.SelectedIndices.Count != 0)
            {
                lvStudentLearn.SelectedIndices.Clear();
                string ID = lvMainClass.Items[lvMainClass.SelectedIndices[0]].Text;
                string nameAcct = (string) Account.getField("TenTK", "ID", ID);
                currentAcct = new Account(nameAcct);
                gbInfo.Enabled = true;
                gbMark.Enabled = false;
                Student student = (Student) Person.getInfo("ID", ID);
                txtName.Text = student.getFullName().getFullName();
                txtAddress.Text = student.getAddress();
                txtEmail.Text = student.getEmail();
                txtID.Text = ID;
                txtPhone.Text = student.getPhone();
                dtpBirth.Value = student.getBirth().getDate();
            }
            else
            {
                currentAcct = null;
                gbInfo.Enabled = false;
                clearText();
            }
        }

        private void lvStudentLearn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudentLearn.SelectedIndices.Count != 0)
            {
                lvMainClass.SelectedIndices.Clear();
                ListViewItem li = lvStudentLearn.SelectedItems[0];
                string nameAcct = (string)Account.getField("TenTK", "ID", lvStudentLearn.Items[lvStudentLearn.SelectedIndices[0]].Text);
                currentAcct = new Account(nameAcct);
                Student student = (Student)Person.getInfo("ID", currentAcct.getID());
                txtName.Text = student.getFullName().getFullName();
                txtAddress.Text = student.getAddress();
                txtEmail.Text = student.getEmail();
                txtID.Text = student.getID();
                txtPhone.Text = student.getPhone();
                dtpBirth.Value = student.getBirth().getDate();
                if (cbbStudent.SelectedIndex == 0)
                {
                    gbInfo.Enabled = true;
                }
                else
                {
                    gbInfo.Enabled = false;
                }
                gbMark.Enabled = true;
                InfoAssignSubject infoAssign = InfoAssignSubject.getInfo(student.getID(), currentAssignSubject.getMaLop(), int.Parse(li.SubItems[2].Text), int.Parse(li.SubItems[3].Text));
                MarkSubject mark = MarkSubject.getInfo(currentAssignSubject.getMaLop(), currentAcct.getID(), infoAssign.getHocKi(), infoAssign.getYear());
                if (mark == null)
                {
                    btnDeleteMark.Enabled = false;
                    txtKTDK.Clear();
                    txtKTHP.Clear();
                }
                else
                {
                    if (infoAssign.getHocKi() != student.getHocKi() || infoAssign.getYear() != student.getYear())
                    {
                        btnDeleteMark.Enabled = false;
                    }
                    else
                    {
                        btnDeleteMark.Enabled = true;
                    }
                    int percent = mark.getPercentKTDK();
                    cbbPercentKTDK.SelectedIndex = percent / 10 - 1;
                    txtKTDK.Text = mark.getKTDK().ToString();
                    txtKTHP.Text = mark.getKTHP().ToString();
                }
                if (infoAssign.getHocKi() != student.getHocKi() || infoAssign.getYear() != student.getYear())
                {
                    btnMark.Enabled = false;
                }
                else
                {
                    btnMark.Enabled = true;
                }
            }
            else
            {
                clearText();
                btnDeleteMark.Enabled = false;
                btnKickStudent.Enabled = false;
                currentAcct = null;
                gbInfo.Enabled = false;
                gbMark.Enabled = false;
            }
        }
        private void btnKickStudent_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc chắn muốn loại sinh viên khỏi lớp?") != DialogResult.Yes)
            {
                return;
            }
            for (int i = 0; i < lvMainClass.CheckedIndices.Count; i++)
            {
                InfoAssignStudent.kickStudent(lvMainClass.Items[lvMainClass.CheckedIndices[i]].SubItems[0].Text);
            }
            for (int i = 0; i < lvStudentLearn.CheckedIndices.Count; i++)
            {
                ListViewItem li = lvStudentLearn.Items[lvStudentLearn.CheckedIndices[i]];
                InfoAssignSubject infoAssignSubject = InfoAssignSubject.getInfo(li.SubItems[0].Text, currentAssignSubject.getMaLop(), int.Parse(li.SubItems[2].Text), int.Parse(li.SubItems[3].Text));
                infoAssignSubject.deleteAssignSubject();
            }
            loadMainClassStudents();
            loadClassTeach();
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            ListViewItem li = lvStudentLearn.SelectedItems[0];
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc chắn muốn xoá điểm của sinh viên " + txtID.Text + " - HK" + li.SubItems[2].Text + " - Năm " + li.SubItems[3].Text + " - Mã lớp: " + currentAssignSubject.getMaLop() +"?") != DialogResult.Yes)
            {
                return;
            }
            InfoAssignSubject infoAssignSubject = InfoAssignSubject.getInfo(txtID.Text, currentAssignSubject.getMaLop(), int.Parse(li.SubItems[2].Text), int.Parse(li.SubItems[3].Text));
            if (!MarkSubject.deleteMarkSubject(txtID.Text, currentAssignSubject.getMaLop(), infoAssignSubject.getHocKi(), infoAssignSubject.getYear()))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá điểm sinh viên thất bại!");
            }
            else
            {
                loadClassTeach();
            }
        }

        private void lvMainClass_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvMainClass.CheckedIndices.Count != 0)
            {
                btnKickStudent.Enabled = true;
            }
            else if (lvStudentLearn.CheckedIndices.Count != 0)
            {
                if (cbbStudent.SelectedIndex != 0)
                {
                    btnKickStudent.Enabled = false;
                }
                else
                {
                    btnKickStudent.Enabled = true;
                }
            }
            else
            {
                btnKickStudent.Enabled = false;
            }
        }

        private void lvStudentLearn_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvMainClass.CheckedIndices.Count != 0)
            {
                btnKickStudent.Enabled = true;
            }
            else if (lvStudentLearn.CheckedIndices.Count != 0)
            {
                if (cbbStudent.SelectedIndex != 0)
                {
                    btnKickStudent.Enabled = false;
                }
                else
                {
                    btnKickStudent.Enabled = true;
                }
            }
            else
            {
                btnKickStudent.Enabled = false;
            }
        }
    }
}
