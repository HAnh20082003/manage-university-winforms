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
    public partial class frmAssignmentStudent : Form
    {
        List<Class> classs;
        Class currentClass;
        List<Student> studentsInClass;
        List<Student> students;
        public frmAssignmentStudent()
        {
            InitializeComponent();
            loadKhoa();
        }

        void loadKhoa()
        {
            List<Khoa> khoas = Khoa.getAllKhoa();
            cbbKhoa.Items.Clear();
            cbbKhoa.Items.Add("Toàn bộ khoa");
            for (int i =0; i <khoas.Count; i++)
            {
                cbbKhoa.Items.Add(khoas[i].getName());
            }
            cbbKhoa.SelectedIndex = 0;
        }
        void loadMajor()
        {
            string tenKhoa = cbbKhoa.Text;
            Khoa khoa = new Khoa(tenKhoa);
            List<Major> majors = khoa.getMyMajor();
            cbbMajor.Items.Clear();
            cbbMajor.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i < majors.Count; i++)
            {
                cbbMajor.Items.Add(majors[i].getName());
            }
            cbbMajor.SelectedIndex = 0;
        }
        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedIndex == -1)
            {
                fpnClasss.Controls.Clear();
                gbStudentInClass.Enabled = false;
                gbStudents.Enabled = false;
                cbbMajor.Text = "";
                cbbMajor.Items.Clear();
                cbbMajor.Enabled = false;
                return;
            }
            else
            {
                if (cbbKhoa.SelectedIndex == 0)
                {
                    cbbMajor.Text = "";
                    cbbMajor.Items.Clear();
                    cbbMajor.Enabled = false;
                    loadClass();
                }
                else
                {
                    cbbMajor.Enabled = true;
                    loadMajor();
                }
            }
        }

        private void cbbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadClass();
        }

        GroupBox getGroupClass(Class aClass)
        {
            GroupBox gb = new GroupBox()
            {
                Text = "Tên lớp: " + aClass.getName(),
                Size = new Size(390, 150),
                Cursor = Cursors.Hand,
                Tag = aClass,
                BackColor = Color.LavenderBlush,
            };

            int xstart = 5, yStart = 30;

            Label lblMaCoVan = new Label()
            {
                Text = "Mã cố vấn: " + aClass.getMaGV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaCoVan);

            yStart += 27;
            Label lblCount = new Label()
            {
                Text = "Sỉ số: " + aClass.getStudents().Count() + "/" + aClass.getMaxCount(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblCount);

            yStart += 27;
            Label lblNameMajor = new Label()
            {
                Text = "Tên ngành: " + aClass.getNameMajor(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameMajor);
            gb.Click += selectClass;
            return gb;
        }

        void loadListStudentInClass()
        {
            btnKick.Enabled = false;
            lvStudentInClass.Items.Clear();
            if (currentClass == null)
            {
                return;
            }
            studentsInClass = currentClass.getStudents();
            for (int i = 0; i < studentsInClass.Count; i++)
            {
                ListViewItem li = new ListViewItem()
                {
                    Text = studentsInClass[i].getID(),
                };
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = studentsInClass[i].getFullName().getFullName() });
                lvStudentInClass.Items.Add(li);
            }
        }

        void loadListStudents()
        {
            if (currentClass == null)
            {
                return;
            }
            students = Student.getAllStudents();
            lvStudents.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].getNameMajor() != currentClass.getNameMajor() || Student.checkHadClass(students[i]))
                {
                    continue;
                }
                ListViewItem li = new ListViewItem()
                {
                    Text = students[i].getID(),
                };
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = students[i].getFullName().getFullName() });
                lvStudents.Items.Add(li);
            }
            btnAdd.Enabled = false;
        }

        private void selectClass(object sender, EventArgs e)
        {
            currentClass = (Class)((Control)sender).Tag;
            loadListStudentInClass();
            loadListStudents();
            gbStudentInClass.Enabled = true;
            gbStudents.Enabled = true;
            gbStudentInClass.Text = "Sinh viên lớp " + currentClass.getName();
        }

        void loadClass()
        {
            classs = Class.getAllClass();
            for (int i = 0; i < txtSearch.Text.Length; i++)
            {
                removeListByCharName(txtSearch.Text[i]);
            }
            Khoa khoa = null;
            if (cbbKhoa.SelectedIndex != 0)
            {
                khoa = new Khoa(cbbKhoa.Items[cbbKhoa.SelectedIndex].ToString());
            }
            fpnClasss.Controls.Clear();
            for (int i = 0; i < classs.Count; i++)
            {
                if (cbbMajor.SelectedIndex == 0 && cbbKhoa.SelectedIndex != 0)
                {
                    if (!khoa.majorInKhoa(classs[i].getNameMajor()))
                    {
                        classs.RemoveAt(i);
                        i--;
                        continue;
                    }
                }
                else if (cbbMajor.SelectedIndex > 0 && cbbMajor.Items[cbbMajor.SelectedIndex].ToString() != classs[i].getNameMajor())
                {
                    classs.RemoveAt(i);
                    i--;
                    continue;
                }
                fpnClasss.Controls.Add(getGroupClass(classs[i]));
            }
        }


        private void lvStudents_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvStudents.CheckedIndices.Count != 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void lvStudentInClass_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvStudentInClass.CheckedIndices.Count != 0)
            {
                btnKick.Enabled = true;
            }
            else
            {
                btnKick.Enabled = false;
            }
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn các loại sinh viên khỏi lớp " + currentClass.getName() +"?") != DialogResult.Yes)
            {
                return;
            }
            for (int i = 0; i < lvStudentInClass.CheckedIndices.Count; i++)
            {
                ListViewItem li = lvStudentInClass.Items[lvStudentInClass.CheckedIndices[i]];
                InfoAssignStudent.kickStudent(li.Text);
            }
            loadClass();
            loadListStudentInClass();
            loadListStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvStudents.CheckedIndices.Count; i++)
            {
                ListViewItem li = lvStudents.Items[lvStudents.CheckedIndices[i]];
                InfoAssignStudent.addAssignStudent(li.Text, currentClass.getName());
            }
            loadClass();
            loadListStudentInClass();
            loadListStudents();
        }
        void removeListByCharName(char c)
        {
            c = char.ToLower(c);
            for (int i = 0; i < classs.Count; i++)
            {
                bool remove = !classs[i].getName().ToLower().Contains(c);
                if (remove)
                {
                    classs.RemoveAt(i);
                    i--;
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadClass();
        }

        private void btnAssignAll_Click(object sender, EventArgs e)
        {
            List<Class> classs = Class.getAllClass();
            for (int i = 0; i < classs.Count; i++)
            {
                Major major = Major.getInfo(classs[i].getNameMajor());
                List<Student> studentInMajor = major.getStudents();

                for (int j = 0; j < studentInMajor.Count; j++)
                {
                    if (Student.checkHadClass(studentInMajor[j]) || InfoAssignStudent.isExistsAssignStudent(studentInMajor[j].getID()))
                    {
                        studentInMajor.RemoveAt(j);
                        j--;
                    }
                }
                while (studentInMajor.Count != 0 && classs[i].getStudents().Count() < classs[i].getMaxCount())
                {
                    if (!InfoAssignStudent.addAssignStudent(studentInMajor[0].getID(), classs[i].getName()))
                    {
                        MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi trong quá trình phân bổ sinh viên!");
                        break;
                    }
                    studentInMajor.RemoveAt(0);
                }
            }
            loadClass();
            loadListStudentInClass();
            loadListStudents();
        }

        private void btnKickAll_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn các loại toàn bộ sinh viên khỏi mọi lớp?") != DialogResult.Yes)
            {
                return;
            }
            List<Class> classs = Class.getAllClass();
            for (int i = 0; i < classs.Count; i++)
            {
                List<Student> studentInMajor = classs[i].getStudents();
                for (int j = 0; j < studentInMajor.Count; j++)
                {
                    if (!InfoAssignStudent.kickStudent(studentInMajor[j].getID()))
                    {
                        MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi trong quá trình loại bỏ sinh viên!");
                        break;
                    }
                }
            }
            loadClass();
            loadListStudentInClass();
            loadListStudents();
        }

        private void btnKickAllClass_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn các loại toàn bộ sinh viên khỏi lớp " + currentClass.getName() + "?") != DialogResult.Yes)
            {
                return;
            }
            List<Student> studentInMajor = currentClass.getStudents();

            for (int i = 0; i < studentInMajor.Count; i++)
            {
                if (!InfoAssignStudent.kickStudent(studentInMajor[i].getID()))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi trong quá trình loại bỏ sinh viên!");
                    break;
                }
            }
            loadClass();
            loadListStudentInClass();
            loadListStudents();
        }
    }
}
