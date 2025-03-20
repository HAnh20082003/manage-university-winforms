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
    public partial class frmAssignmentTeacher : Form
    {
        Subject currentSubject;
        InfoAssignTeacher currentInfoAssign;
        public frmAssignmentTeacher()
        {
            InitializeComponent();
            txtMaxCount.KeyPress += General.number_KeyPress;
            cbbKhoa.Items.Clear();
            List<Khoa> khoas = Khoa.getAllKhoa();
            cbbKhoa.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i < khoas.Count; i++)
            {
                cbbKhoa.Items.Add(khoas[i].getName());
            }
            cbbKhoa.SelectedIndex = 0;
        }
        GroupBox getGroupAssignSubject(InfoAssignTeacher infoAssign)
        {
            GroupBox gb = new GroupBox()
            {
                Text = "Mã lớp: " + infoAssign.getMaLop(),
                Size = new Size(480, 100),
                Cursor = Cursors.Hand,
                Tag = infoAssign,
                BackColor = Color.Teal,
                Font = new Font("Times New Roman", 9, FontStyle.Bold),
                ForeColor = Color.WhiteSmoke,
            };

            int xstart = 10, yStart = 30;

            Label lblNameSubject = new Label()
            {
                Text = "Tên môn: " + infoAssign.getNameSubject(),
                ForeColor = Color.White,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameSubject);
            yStart += 27;

            Label lblMaGV = new Label()
            {
                Text = "Mã GV: " + infoAssign.getMaGV(),
                ForeColor = Color.White,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaGV);
            yStart += 27;

            Label lblMaxCount = new Label()
            {
                Text = "Sỉ số tối đa: " + infoAssign.getMaxCount(),
                ForeColor = Color.White,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaGV);
            gb.Click += selectAssignSubject;
            gb.Click += selectAssignSubject;
            return gb;
        }


        private void selectAssignSubject(object sender, EventArgs e)
        {
            currentInfoAssign = (InfoAssignTeacher)((Control)sender).Tag;
            btnCancel.Enabled = true;
        }

        void loadSubjects()
        {
            cbbSubject.Items.Clear();
            List<Subject> subs;
            if (cbbMajor.SelectedIndex == 0)
            {
                if (cbbKhoa.SelectedIndex == 0)
                {
                    subs = Subject.getAllSubject();
                }
                else
                {
                    Khoa khoa = new Khoa(cbbKhoa.Items[cbbKhoa.SelectedIndex].ToString());
                    subs = khoa.getMySubjects();
                }
            }
            else
            {
                subs = Subject.getSubjectInMajor(cbbMajor.Items[cbbMajor.SelectedIndex].ToString());
            }
            for (int i = 0; i< subs.Count; i++)
            {
                cbbSubject.Items.Add(subs[i].getName());
            }
        }

        void loadAssignSubjects()
        {
            fpnAssignedSubject.Controls.Clear();
            List<InfoAssignTeacher> infoAssigns;
            if (cbbMajor.SelectedIndex == 0)
            {
                if (cbbKhoa.SelectedIndex == 0)
                {
                    infoAssigns = InfoAssignTeacher.getAllAssign();
                }
                else
                {
                    Khoa khoa = new Khoa(cbbKhoa.Items[cbbKhoa.SelectedIndex].ToString());
                    infoAssigns = InfoAssignTeacher.getInfoAssignByMajor(khoa.getMyMajor());
                }
            }
            else
            {
                List<Major> majors = new List<Major>() { Major.getInfo(cbbMajor.Items[cbbMajor.SelectedIndex].ToString()) };
                infoAssigns = InfoAssignTeacher.getInfoAssignByMajor(majors);
            }
            for (int i = 0; i < infoAssigns.Count; i++)
            {
                fpnAssignedSubject.Controls.Add(getGroupAssignSubject(infoAssigns[i]));
            }
        }

        void loadListTeachers()
        {
            lvTeachers.Items.Clear();
            if (currentSubject == null)
            {
                return;
            }
            List<Major> majors = currentSubject.getMajor();
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < majors.Count; i++)
            {
                Khoa khoa = new Khoa(majors[i].getTenKhoa());
                List<Teacher> tmpTeachers = khoa.getTeachers();
                for (int j = 0; j < tmpTeachers.Count; j++)
                {
                    bool ok = true;
                    for (int k = 0; k < teachers.Count; k++)
                    {
                        if (tmpTeachers[j].getID() == teachers[k].getID())
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        teachers.Add(tmpTeachers[j]);
                        ListViewItem li = new ListViewItem()
                        {
                            Text = tmpTeachers[j].getID(),
                        };
                        li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tmpTeachers[j].getFullName().getFullName() });
                        lvTeachers.Items.Add(li);
                    }

                }
            }
        }
        private void lvTeachers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvTeachers.CheckedIndices.Count != 0)
            {
                btnTeach.Enabled = true;
            }
            else
            {
                btnTeach.Enabled = false;
            }
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaxCount.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập sỉ số lớp tối đa!");
                txtMaxCount.Focus();
                return;
            }
            for (int i = 0; i < lvTeachers.CheckedIndices.Count; i++)
            {
                ListViewItem lv = lvTeachers.Items[lvTeachers.CheckedIndices[i]];
                InfoAssignTeacher info = new InfoAssignTeacher(currentSubject.getName(), lv.SubItems[0].Text, int.Parse(txtMaxCount.Text));
                info.addAssign();
            }
            MessageInfo.makeMessage("Information", "Chúc mừng", "Phân công thành công!");
            loadListTeachers();
            loadAssignSubjects();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentInfoAssign == null)
            {
                return;
            }
            if (currentInfoAssign.deleteAssign())
            {
                MessageInfo.makeMessage("Information", "Chúc mừng", "Xoá phân công thành công!");
                loadListTeachers();
                loadAssignSubjects();
            }
            else
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá phân công thất bại!");
            }
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSubject = Subject.getInfo("Ten", cbbSubject.Text);
            loadListTeachers();
            gbTeacher.Enabled = true;
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Major> majors;
            if (cbbKhoa.SelectedIndex == 0)
            {
                cbbMajor.Enabled = false;
                majors = Major.getAllMajor();

            }
            else
            {
                cbbMajor.Enabled = true;
                Khoa khoa = new Khoa(cbbKhoa.Items[cbbKhoa.SelectedIndex].ToString());
                majors = khoa.getMyMajor();
            }
            cbbMajor.Items.Clear();
            cbbMajor.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i< majors.Count; i++)
            {
                cbbMajor.Items.Add(majors[i].getName());
            }
            cbbMajor.SelectedIndex = 0;
        }

        private void cbbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAssignSubjects();

            loadSubjects();
        }
    }
}
