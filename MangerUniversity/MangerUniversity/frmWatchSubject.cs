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
    public partial class frmWatchSubject : Form
    {
        List<Subject> subjects;
        Major currentMajor;
        int currentYear;
        public frmWatchSubject(string nameAcct)
        {
            InitializeComponent();
            string ID = (string)Account.getField("ID", "TenTK", nameAcct);
            if (Teacher.isExistTeacherID(ID))
            {
                Teacher teacher = (Teacher)Person.getInfo("ID", ID);
                Text = "Xem các môn học thuộc khoa " + teacher.getTenKhoa();
                gbMajor.Text = "Danh sách ngành thuộc khoa " + teacher.getTenKhoa();
                loadMajor(teacher);
            }
            else
            {
                Student student = (Student)Person.getInfo("ID", ID);
                Text = "Xem các môn học thuộc ngành " + student.getNameMajor();
                gbMajor.Text = "Ngành học của sinh viên";
                currentMajor = Major.getInfo(student.getNameMajor());
                Label lblNameMajor = new Label()
                {
                    Text = currentMajor.getName(),
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Size = new Size(375, 40),
                    ForeColor = Color.Navy,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.DarkSeaGreen,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                fpnMajor.Controls.Add(lblNameMajor);
                currentYear = 1;
                loadSubjects(1, true);
                if (cbbYear.Items.Count != 0)
                {
                    cbbYear.SelectedIndex = 0;
                }
                else
                {
                    currentYear = 0;
                }
            }
        }

        void loadMajor(Teacher teacher)
        {
            Khoa khoa = new Khoa(teacher.getTenKhoa());
            List<Major> majors = khoa.getMyMajor();
            for (int i = 0; i < majors.Count; i++)
            {
                Label lblNameMajor = new Label()
                {
                    Text = majors[i].getName(),
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    Size = new Size(375, 40),
                    ForeColor = Color.Navy,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor =Color.DarkSeaGreen,
                };
                lblNameMajor.Click += selectMajor;
                fpnMajor.Controls.Add(lblNameMajor);
            }
        }

        private void selectMajor(object sender, EventArgs e)
        {
            currentMajor = Major.getInfo(((Control)sender).Text);
            currentYear = 1;
            loadSubjects(1, true);
            if (cbbYear.Items.Count != 0)
            {
                cbbYear.SelectedIndex = 0;
            }
            else
            {
                currentYear = 0;
            }
        }


        void loadSubjects(int year, bool createCbb = false)
        {
            fpnSubject.Controls.Clear();
            subjects = currentMajor.getMySubjects();
            if (createCbb)
            {
                int max = 0;
                for (int i =0; i < subjects.Count; i++)
                {
                    if (subjects[i].getYear() > max)
                    {
                        max = subjects[i].getYear();
                    }
                }
                cbbYear.Items.Clear();
                for (int i = 1; i <= max; i++)
                {
                    cbbYear.Items.Add("Năm " + i);
                }
            }
            for (int i =0; i < subjects.Count; i++)
            {
                if (subjects[i].getYear() != year)
                {
                    subjects.RemoveAt(i);
                }
            }
            List<GroupBox> gbHocKi = new List<GroupBox>();
            List<FlowLayoutPanel> fpnHocKi = new List<FlowLayoutPanel>();
            for (int i = 0; i < subjects.Count; i++)
            {
                int index = subjects[i].getHocKi() - 1;
                if (gbHocKi.Count <= index)
                {
                    GroupBox gb = new GroupBox()
                    {
                        Text = "Học kì " + (index + 1),
                        Size = new Size(540, 200),
                        BackColor = Color.White,
                        Font= new Font("Times New Roman", 10, FontStyle.Bold),
                        ForeColor = Color.Crimson,
                    };
                    FlowLayoutPanel fpn = new FlowLayoutPanel()
                    {
                        Location = new Point(10, 30),
                        Size = new Size(520, 150),
                        AutoScroll = true,
                    };
                    gb.Controls.Add(fpn);
                    fpnSubject.Controls.Add(gb);
                    fpnHocKi.Add(fpn);
                    gbHocKi.Add(gb);
                }
                fpnHocKi[index].Controls.Add(new Label() { Text = subjects[i].getName(),BackColor =Color.Yellow, Font = new Font("Times New Roman", 12, FontStyle.Bold), ForeColor = Color.Navy, TextAlign = ContentAlignment.MiddleLeft, BorderStyle = BorderStyle.FixedSingle, Size = new Size(fpnHocKi[index].Width - 20, 40) });
            }
        }
        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (currentYear == cbbYear.SelectedIndex + 1)
            {
                return;
            }
            currentYear = cbbYear.SelectedIndex + 1;
            loadSubjects(cbbYear.SelectedIndex + 1);
        }
    }
}
