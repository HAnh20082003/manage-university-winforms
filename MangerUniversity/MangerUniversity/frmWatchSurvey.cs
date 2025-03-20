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
    public partial class frmWatchSurvey : Form
    {
        List<InfoAssignTeacher> infoAssignTeachers;
        Teacher teacher;
        public frmWatchSurvey(string nameAcct)
        {
            InitializeComponent();
            string ID = (string)Account.getField("ID", "TenTK", nameAcct);
            teacher = (Teacher)Person.getInfo("ID", ID);
            infoAssignTeachers = teacher.getInfoAssign();
            cbbNameSubject.Items.Clear();
            cbbNameSubject.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i < infoAssignTeachers.Count; i++)
            {
                bool isOk = true;
                for (int j = 0; j < cbbNameSubject.Items.Count; j++)
                {
                    if (cbbNameSubject.Items[j].ToString() == infoAssignTeachers[i].getNameSubject())
                    {
                        isOk = false;
                    }
                }
                if (isOk)
                {
                    cbbNameSubject.Items.Add(infoAssignTeachers[i].getNameSubject());
                }
            }
            cbbNameSubject.SelectedIndex = 0;
        }
        public frmWatchSurvey()
        {
            InitializeComponent();
        }

        private void cbbNameSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaLop.Items.Clear();
            cbbMaLop.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i < infoAssignTeachers.Count; i++)
            {
                if (cbbNameSubject.SelectedIndex != 0 && infoAssignTeachers[i].getNameSubject() != cbbNameSubject.Text)
                {
                    infoAssignTeachers.RemoveAt(i);
                    i--;
                    continue;
                }
                cbbMaLop.Items.Add(infoAssignTeachers[i].getMaLop());
            }
            cbbMaLop.SelectedIndex = 0;
        }

        void clearSurvey()
        {
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

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSurvey.SelectedIndex = -1;
            cbbSurvey.SelectedIndex = 0;
        }
        private void cbbSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSurvey.SelectedIndex == -1)
            {
                return;
            }
            fpnSurvey.Controls.Clear();
            List<Survey> lstSurvey = Teacher.getAllSurvey(teacher.getID());
            for (int i = 0; i < lstSurvey.Count; i++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(lstSurvey[i].getMaLop());
                if (cbbNameSubject.SelectedIndex != 0 && infoAssignTeacher.getNameSubject() != cbbNameSubject.Text)
                {
                    continue;
                }
                if (cbbMaLop.SelectedIndex != 0 && lstSurvey[i].getMaLop().ToString() != cbbMaLop.Text)
                {
                    continue;
                }
                Student student = (Student)Person.getInfo("ID", lstSurvey[i].getMaSV());
                if (cbbSurvey.SelectedIndex == 0)
                {
                    if (lstSurvey[i].getHocKi() != student.getHocKi() || lstSurvey[i].getYear() != student.getYear())
                    {
                        continue;
                    }
                }
                else
                {
                    if (lstSurvey[i].getHocKi() == student.getHocKi() && lstSurvey[i].getYear() == student.getYear())
                    {
                        continue;
                    }
                }
                fpnSurvey.Controls.Add(getGroupSurvey(lstSurvey[i]));
            }
            clearSurvey();
        }

        GroupBox getGroupSurvey(Survey survey)
        {
            InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(survey.getMaLop());
            GroupBox gb = new GroupBox()
            {
                Size = new Size(500, 150),
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Tag = survey,
                BackColor = Color.LavenderBlush,
            };

            int xstart = 5, yStart = 10;
            Label lblMaLop = new Label()
            {
                Text = "Mã lớp: " + survey.getMaLop(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaLop); 

            yStart += 27;
            Label lblNameSubject = new Label()
            {
                Text = "Tên môn: " + infoAssignTeacher.getNameSubject(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameSubject);

            yStart += 27;
            Label lblMaSV = new Label()
            {
                Text = "Mã SV: " + survey.getMaSV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaSV);

            yStart += 27;
            Label lblHocKi = new Label()
            {
                Text = "Học kì: " + survey.getHocKi(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblHocKi);

            yStart += 27;
            Label lblYear = new Label()
            {
                Text = "Năm: " + survey.getYear(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblYear);
            gb.Click += selectSurvey;
            return gb;
        }

        private void selectSurvey(object sender, EventArgs e)
        {
            Survey survey = (Survey)((Control)sender).Tag;
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

    }
}
