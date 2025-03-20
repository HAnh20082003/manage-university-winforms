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
    public partial class frmManageSurvey : Form
    {
        List<Teacher> teaches;
        InfoAssignTeacher currentAssign;
        public frmManageSurvey()
        {
            InitializeComponent();
            cbbMaGV.Items.Clear();
            cbbMaGV.Items.Add("Hiển thị toàn bộ");
            teaches = Teacher.getAllTeacher();
            for (int i = 0; i < teaches.Count; i++)
            {
                cbbMaGV.Items.Add(teaches[i].getID());
            }
            cbbMaGV.SelectedIndex = 0;
        }
        GroupBox getGroupSurvey(InfoAssignTeacher infoAssign)
        {
            GroupBox gb = new GroupBox()
            {
                Size = new Size(490, 150),
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
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
            Label lblMaGV = new Label()
            {
                Text = "Mã GV: " + infoAssign.getMaGV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaGV);

            yStart += 27;
            Label lblCount = new Label()
            {
                Text = "Sỉ số: " + infoAssign.getStudents().Count() + "/" + infoAssign.getMaxCount(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblCount);

            yStart += 27;

            Label lblCountSurvey = new Label()
            {
                Text = "Số bài khảo sát: " + InfoAssignSubject.getSurveysAssignSubject(infoAssign.getMaLop()).Count() + "/" + infoAssign.getStudents().Count(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblCountSurvey);

            gb.Click += selectInfoAssign;
            return gb;
        }

        private void selectInfoAssign(object sender, EventArgs e)
        {
            currentAssign = (InfoAssignTeacher)((Control)sender).Tag;
            cbbSurvey.Enabled = true;
            cbbSurvey.SelectedIndex = -1;
            cbbSurvey.SelectedIndex = 0;
            btnDeleteAllSurveyGV.Enabled = true;
        }

        private void cbbSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSurvey.SelectedIndex == -1)
            {
                return;
            }
            lvStudent.Items.Clear();
            List<Survey> survey = currentAssign.getAllSurveys();
            for (int i = 0; i < survey.Count; i++)
            {
                Student student = (Student)Person.getInfo("ID", survey[i].getMaSV());
                if (cbbSurvey.SelectedIndex == 0)
                {
                    if (survey[i].getHocKi() != student.getHocKi() || survey[i].getYear() != student.getYear())
                    {
                        continue;
                    }
                }
                else
                {
                    if (survey[i].getHocKi() == student.getHocKi() && survey[i].getYear() == student.getYear())
                    {
                        continue;
                    }
                }
                ListViewItem li = new ListViewItem()
                {
                    Text = survey[i].getMaSV(),
                };
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (string)Student.getFieldStudentByID("Ten", survey[i].getMaSV()) });
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = survey[i].getHocKi().ToString() });
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = survey[i].getYear().ToString() });
                lvStudent.Items.Add(li);
            }
            clearSurvey();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem li = lvStudent.Items[lvStudent.SelectedIndices[0]];
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn xoá khảo sát: " + li.SubItems[0].Text + "-" + currentAssign.getMaLop() + "-" + li.SubItems[2].Text + "-" + li.SubItems[3].Text + "?") != DialogResult.Yes)
            {
                return;
            }
            if (!Survey.deleteSurvey(li.SubItems[0].Text, currentAssign.getMaLop(), int.Parse(li.SubItems[2].Text), int.Parse(li.SubItems[3].Text)))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá khảo sát thất bại!");
                return;
            }
            loadSubjectClass();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedIndices.Count != 0)
            {
                btnDelete.Enabled = true;
                gbSurvey.Enabled = true;
                ListViewItem li = lvStudent.Items[lvStudent.SelectedIndices[0]];
                Survey survey = Survey.getSurvey(li.SubItems[0].Text, currentAssign.getMaLop(), int.Parse(li.SubItems[2].Text), int.Parse(li.SubItems[3].Text));
                if (survey == null)
                {
                    return;
                }
                Student student = (Student)Person.getInfo("ID", survey.getMaSV());
                lblNameStudent.Text = student.getFullName().getFullName();
                object img = Account.getField("AnhDaiDien", "ID", student.getID());
                if (img != null)
                {
                    ptrAvt.Image = Avatar.ConvertBytesToImage((byte[])img);
                }
                else
                {
                    ptrAvt.Image = Image.FromFile("Assets/Imgs/No Image.png");
                }
                int[] content = survey.getContent();
                foreach (Control pn in gbSurvey.Controls)
                {
                    if (pn is Panel)
                    {
                        int index = int.Parse(pn.Tag.ToString()) - 1;
                        foreach (Control rdo in pn.Controls)
                        {
                            if (rdo is RadioButton)
                            {
                                int value = int.Parse(rdo.Tag.ToString());
                                if (value == content[index])
                                {
                                    RadioButton radio = (RadioButton)rdo;
                                    radio.Checked = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                btnDelete.Enabled = false;
                clearSurvey();
            }
        }
        void clearSurvey()
        {
            gbSurvey.Enabled = false;
            ptrAvt.Image = Image.FromFile("Assets/Imgs/No Image.png");
            lblNameStudent.Text = "Họ và tên";
            foreach (Control pn in gbSurvey.Controls)
            {
                if (pn is Panel)
                {
                    foreach (Control rdo in pn.Controls)
                    {
                        if (rdo is RadioButton)
                        {
                            int value = int.Parse(rdo.Tag.ToString());
                            if (value == 1)
                            {
                                RadioButton radio = (RadioButton)rdo;
                                radio.Checked = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        void loadSubjectClass()
        {
            lvStudent.Items.Clear();
            List<InfoAssignTeacher> infoAssignTeachers;
            if (cbbMaGV.SelectedIndex == 0)
            {
                infoAssignTeachers = InfoAssignTeacher.getAllAssign();
                btnDeleteAllSurveyGV.Enabled = false;
            }
            else
            {
                btnDeleteAllSurveyGV.Enabled = true;
                infoAssignTeachers = teaches[cbbMaGV.SelectedIndex - 1].getInfoAssign();
            }
            fpnSubjectClass.Controls.Clear();
            for (int i = 0; i < infoAssignTeachers.Count; i++)
            {
                fpnSubjectClass.Controls.Add(getGroupSurvey(infoAssignTeachers[i]));
            }
            clearSurvey();
        }

        private void cbbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSurvey.Enabled = false;
            btnDeleteAllSurveyGV.Enabled = true;
            loadSubjectClass();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn muốn xoá toàn bộ khảo sát!") != DialogResult.Yes)
            {
                return;
            }
            if (!Survey.deleteAllSurvey())
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá toàn bộ khảo sát thất bại!");
            }
            else
            {
                loadSubjectClass();
            }
        }

        private void btnDeleteAllSurveyGV_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn muốn xoá toàn bộ khảo sát của giảng viên + " + cbbMaGV.Text + "!") != DialogResult.Yes)
            {
                return;
            }
            if (cbbMaGV.SelectedIndex == 0)
            {
                if (!Survey.deleteAllSurvey(currentAssign.getMaGV()))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá toàn bộ khảo sát của giảng viên " + currentAssign.getMaGV() + " thất bại!");
                }
                else
                {
                    loadSubjectClass();
                }
            }
            else
            {
                if (!Survey.deleteAllSurvey(cbbMaGV.Text))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá toàn bộ khảo sát của giảng viên " + cbbMaGV.Text + " thất bại!");
                }
                else
                {
                    loadSubjectClass();
                }
            }
        }
    }
}
