using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    public partial class frmEnrollSubject : Form
    {
        List<InfoAssignTeacher> subjectClassMain = new List<InfoAssignTeacher>();
        List<InfoAssignTeacher> subjectClassReLearn = new List<InfoAssignTeacher>();
        InfoAssignTeacher currentInfoAssignTeacher;
        Student student; 
        List<InfoAssignSubject> infoAssignedSubjects;
        public frmEnrollSubject(string nameAcct)
        {
            InitializeComponent();
            string ID = (string)Account.getField("ID", "TenTK", nameAcct);
            student = (Student) Person.getInfo("ID", ID);
            
            cbbYear.Items.Clear();
            for (int i = 1; i <= student.getYear(); i++)
            {
                cbbYear.Items.Add("Năm " + i);
            }
            cbbYear.SelectedIndex = cbbYear.Items.Count - 1;
            loadSubject();
            loadRelearn();
            loadSubjectAssigned();
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHocKi.Items.Clear();
            int maxHocki;
            if (cbbYear.SelectedIndex + 1 == student.getYear())
            {
                maxHocki = student.getHocKi();
            }
            else
            {
                maxHocki = 2;
            }
            for (int i = 1; i <= maxHocki; i++)
            {
                cbbHocKi.Items.Add("Học Kì " + i);
            }
            cbbHocKi.SelectedIndex = cbbHocKi.Items.Count - 1;
        }

        private void cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbYear.SelectedIndex == -1)
            {
                return;
            }
            clearInput();
            loadSubjectAssigned();
        }

        void loadRelearn()
        {
            subjectClassReLearn.Clear();
            string nameMajor = student.getNameMajor();
            Major major = Major.getInfo(nameMajor);
            List<Subject> subjects = major.getMySubjects();
            for (int i = 0; i < subjects.Count; i++)
            {
                List<InfoAssignTeacher> infoAssignTeachers = Subject.getAssignTeachers(subjects[i].getName());
                if (subjects[i].getYear() == student.getYear())
                {
                    if(subjects[i].getHocKi() < student.getHocKi())
                    {
                        foreach (InfoAssignTeacher infoAssign in infoAssignTeachers)
                        {
                            if (InfoAssignRoom.isExistsAssignRoom(infoAssign.getMaLop()))
                            {
                                bool isOk = true;

                                List<InfoAssignSubject> infoAssignSubjects = InfoAssignSubject.getAssignSameSubject(student.getID(), infoAssign.getNameSubject());
                                for (int j = 0; j < infoAssignSubjects.Count; j++)
                                {
                                    if (MarkSubject.isExistsMarkSubject(student.getID(), infoAssign.getMaLop(), infoAssignSubjects[j].getHocKi(), infoAssignSubjects[j].getYear()))
                                    {
                                        if (MarkSubject.isFail(student.getID(), infoAssign.getMaLop(), infoAssignSubjects[j].getHocKi(), infoAssignSubjects[j].getYear()))
                                        {
                                            isOk = false;
                                            break;
                                        }
                                    }
                                }
                                if (!isOk)
                                {
                                    subjectClassReLearn.Add(infoAssign);
                                }
                            }
                        }
                    }
                }
                else if (subjects[i].getYear() < student.getYear())
                {
                    foreach (InfoAssignTeacher infoAssign in infoAssignTeachers)
                    {
                        if (InfoAssignRoom.isExistsAssignRoom(infoAssign.getMaLop()))
                        {
                            bool isOk = false;

                            List<InfoAssignSubject> infoAssignSubjects = InfoAssignSubject.getAssignSameSubject(student.getID(), infoAssign.getNameSubject());
                            for (int j = 0; j < infoAssignSubjects.Count; j++)
                            {
                                if (MarkSubject.isExistsMarkSubject(student.getID(), infoAssign.getMaLop(), infoAssignSubjects[j].getHocKi(), infoAssignSubjects[j].getYear()))
                                {
                                    if (!MarkSubject.isFail(student.getID(), infoAssign.getMaLop(), infoAssignSubjects[j].getHocKi(), infoAssignSubjects[j].getYear()))
                                    {
                                        isOk = true;
                                        break;
                                    }
                                }
                            }
                            if (!isOk)
                            {
                                subjectClassReLearn.Add(infoAssign);
                            }
                        }
                    }
                }
            }
            fpnSubjectReLearn.Controls.Clear();
            for (int i = 0; i < subjectClassReLearn.Count; i++)
            {
                GroupBox gb = getGroupClassSubject(subjectClassReLearn[i]);
                gb.Click += selectAssignTeacher;
                fpnSubjectReLearn.Controls.Add(gb);
            }
        }

        void loadSubjectAssigned()
        {
            fpnSubjectAssigned.Controls.Clear();
            infoAssignedSubjects = student.getInfoAssignSubject();
            for (int i = 0; i < infoAssignedSubjects.Count; i++)
            {
                if (infoAssignedSubjects[i].getHocKi() != cbbHocKi.SelectedIndex + 1 || infoAssignedSubjects[i].getYear() != cbbYear.SelectedIndex + 1)
                {
                    infoAssignedSubjects.RemoveAt(i);
                    i--;
                    continue;
                }
                GroupBox gb = getGroupClassSubject(InfoAssignTeacher.getInfo(infoAssignedSubjects[i].getMaLop()));
                gb.Click += selectAssignedTeacher;
                fpnSubjectAssigned.Controls.Add(gb);
            }
        }

        void loadSubject()
        {
            clearInput();
            btnAssignSubject.Enabled = false;
            subjectClassMain.Clear();
            string nameMajor = student.getNameMajor();
            Major major = Major.getInfo(nameMajor);
            List<Subject> subjects = major.getMySubjects();
            for (int i = 0; i < subjects.Count; i++)
            {
                List<InfoAssignTeacher> infoAssignTeachers = Subject.getAssignTeachers(subjects[i].getName());
                if (subjects[i].getHocKi() != student.getHocKi() || subjects[i].getYear() != student.getYear())
                {
                    continue;
                }
                foreach (InfoAssignTeacher infoAssign in infoAssignTeachers)
                {
                    if (InfoAssignRoom.isExistsAssignRoom(infoAssign.getMaLop()))
                    {
                        if (!InfoAssignSubject.isExistsAssignSubject(student.getID(), infoAssign.getMaLop(), student.getHocKi(), student.getYear()))
                        {
                            subjectClassMain.Add(infoAssign);
                        }
                    }
                }
            }
            fpnSubject.Controls.Clear();
            for (int i = 0; i < subjectClassMain.Count; i++)
            {
                GroupBox gb = getGroupClassSubject(subjectClassMain[i]);
                gb.Click += selectAssignTeacher;
                fpnSubject.Controls.Add(gb);
            }
            
        }
        GroupBox getGroupClassSubject(InfoAssignTeacher classSubject)
        {
            GroupBox gb = new GroupBox()
            {
                Text = "Mã lớp: " + classSubject.getMaLop(),
                Size = new Size(483, 210),
                Cursor = Cursors.Hand,
                Tag = classSubject,
                BackColor = Color.LavenderBlush,
            };

            int xstart = 5, yStart = 30;

            Label lblNameSubject = new Label()
            {
                Text = "Tên môn: " + classSubject.getNameSubject(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                Size = new Size(gb.Width - 10, 20),
            };
            gb.Controls.Add(lblNameSubject);
            yStart += 27;

            Label lblMaGV = new Label()
            {
                Text = "Mã GV: " + classSubject.getMaGV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                Size = new Size(gb.Width - 10, 20),
            };
            gb.Controls.Add(lblMaGV);
            yStart += 27;

            Label lblSiSoHienTai = new Label()
            {
                Text = "Sỉ số hiện tại: " + classSubject.getStudents().Count() + "/" + classSubject.getMaxCount(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                Size = new Size(gb.Width - 10, 20),
            };
            gb.Controls.Add(lblSiSoHienTai);

            List< InfoAssignRoom> infoAssignRooms = InfoAssignRoom.getInfo(classSubject.getMaLop());

            yStart += 27;
            Button btnDate = new Button()
            {
                Text = "Xem lịch học",
                Font = new Font("Times New Roman", 10),
                Cursor = Cursors.Hand,
                Tag = classSubject.getMaLop(),
                Location = new Point(xstart, yStart),
                Size = new Size(120, 40),
                ForeColor = Color.Navy,
            };
            gb.Controls.Add(btnDate);
            btnDate.Click += selectDate;
            return gb;
        }

        private void selectDate(object sender, EventArgs e)
        {
            int maLop = (int)((Control)sender).Tag;
            frmDateAssign frm = new frmDateAssign(maLop);
            frm.ShowDialog();
        }

        private void selectAssignTeacher(object sender, EventArgs e)
        {
            InfoAssignTeacher infoAssignTeacher = (InfoAssignTeacher)((Control)sender).Tag;
            if (infoAssignTeacher.getMaxCount() == infoAssignTeacher.getStudents().Count())
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Sỉ số đã đạt tối đa!!");
                return;
            }
            currentInfoAssignTeacher = infoAssignTeacher;
            if (cbbHocKi.SelectedIndex + 1 != student.getHocKi() || cbbYear.SelectedIndex + 1 != student.getYear())
            {
                btnAssignSubject.Enabled = false;
            }
            else
            {
                btnAssignSubject.Enabled = true;
            }
            lblMaLop.Text = "Mã lớp: " + currentInfoAssignTeacher.getMaLop().ToString();
            lblNameSubject.Text = "Tên môn: " + currentInfoAssignTeacher.getNameSubject();
            lblMaGV.Text = "Mã GV: " + currentInfoAssignTeacher.getMaGV();
            lblCurrentCount.Text = "Sỉ số hiện tại: " + InfoAssignSubject.getStudentsAssignSubject(currentInfoAssignTeacher.getMaLop()).Count() + "/" + currentInfoAssignTeacher.getMaxCount();
            btnCancelAssignSubject.Enabled = false;
        }

        private void selectAssignedTeacher(object sender, EventArgs e)
        {
            InfoAssignTeacher infoAssignTeacher = (InfoAssignTeacher)((Control)sender).Tag;
            InfoAssignSubject infoAssignSubject = InfoAssignSubject.getInfo(student.getID(), infoAssignTeacher.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
            if (infoAssignSubject.getYear() != cbbYear.SelectedIndex + 1 || infoAssignSubject.getHocKi() != cbbHocKi.SelectedIndex + 1) 
            {
                return;
            }
            currentInfoAssignTeacher = infoAssignTeacher;
            if (cbbHocKi.SelectedIndex + 1 != student.getHocKi() || cbbYear.SelectedIndex + 1 != student.getYear())
            {
                btnCancelAssignSubject.Enabled = false;
            }
            else
            {
                btnCancelAssignSubject.Enabled = true;
            }
            lblMaLop.Text = "Mã lớp: " + currentInfoAssignTeacher.getMaLop().ToString();
            lblNameSubject.Text = "Tên môn: " + currentInfoAssignTeacher.getNameSubject();
            lblMaGV.Text = "Mã GV: " + currentInfoAssignTeacher.getMaGV();
            lblCurrentCount.Text = "Sỉ số hiện tại: " + InfoAssignSubject.getStudentsAssignSubject(currentInfoAssignTeacher.getMaLop()).Count() + "/" + currentInfoAssignTeacher.getMaxCount();
            btnAssignSubject.Enabled = false;
        }
        void clearInput()
        {
            btnAssignSubject.Enabled = false;
            lblMaLop.Text = "Mã Lớp";
            lblNameSubject.Text = "Tên môn";
            lblMaGV.Text = "Mã GV";
            lblCurrentCount.Text = "Sỉ số hiện tại";
        }

        private void btnAssignSubject_Click(object sender, EventArgs e)
        {
            if (currentInfoAssignTeacher == null)
            {
                return;
            }
            if (InfoAssignSubject.isSameDateAssignSubject(student.getID(), currentInfoAssignTeacher.getMaLop()))
            {
                MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Lịch học bị trùng!");
                return;
            }
            InfoAssignTeacher CurrentInfoAssignTeacher = InfoAssignTeacher.getInfo(currentInfoAssignTeacher.getMaLop());

            List<InfoAssignSubject> infoAssignSubjects = InfoAssignSubject.getAllAssignSubject();
            for (int i = 0; i < infoAssignSubjects.Count; i++)
            {
                if (!InfoAssignSubject.isExistsAssignSubject(student.getID(), infoAssignSubjects[i].getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1))
                {
                    continue;
                }
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignSubjects[i].getMaLop());
                if (infoAssignTeacher.getNameSubject() == CurrentInfoAssignTeacher.getNameSubject())
                {
                    if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn đã đăng ký môn " + currentInfoAssignTeacher.getNameSubject() + ", Bạn có chắc muốn thay thế lớp mới không?") != DialogResult.Yes)
                    {
                        return;
                    }
                    infoAssignSubjects[i].deleteAssignSubject();
                    break;
                }
            }
            InfoAssignSubject info = new InfoAssignSubject(student.getID(), currentInfoAssignTeacher.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
            info.addAssignSubject();
            loadSubject();
            loadRelearn();
            loadSubjectAssigned();
        }

        private void btnCancelAssignSubject_Click(object sender, EventArgs e)
        {
            InfoAssignSubject info = InfoAssignSubject.getInfo(student.getID(), currentInfoAssignTeacher.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
            if (!info.deleteAssignSubject())
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Xoá đăng ký thất bại!");
                return;
            }
            loadSubject();
            loadRelearn();
            loadSubjectAssigned();
            btnCancelAssignSubject.Enabled = false;
        }

        string getTextAlignCenter(string text, int countMaxChar)
        {
            int odd = countMaxChar - text.Length;
            if (odd <= 0)
            {
                return text;
            }
            for (int i = 0; i < odd / 2; i++)
            {
                text = " " + text;
            }
            if (odd % 2 == 0)
            {
                for (int i = 0; i < odd / 2; i++)
                {
                    text = text + " ";
                }
            }
            else
            {
                for (int i = 0; i < odd / 2 + 1; i++)
                {
                    text = text + " ";
                }
            }
            return text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (infoAssignedSubjects.Count == 0)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa đăng ký môn nào để in phiếu!");
                return;
            }

            List<string> lstContent = new List<string>();
            string nameFile = "Phiếu đăng ký môn học HK" + (cbbHocKi.SelectedIndex + 1) + " - Năm " + (cbbYear.SelectedIndex + 1) + " - " + student.getFullName().getFullName() + " - " + student.getID();

            lstContent.Add(getTextAlignCenter(nameFile, 76));
            lstContent.Add("----------------------------------------------------------------------------");
            if (File.Exists(nameFile + ".txt"))
            {
                int i = 1;
                while (File.Exists(nameFile + " (" + i + ").txt"))
                {
                    i++;
                }
                nameFile += " (" + i + ").txt";
            }
            else
            {
                nameFile += ".txt";
            }
            
            lstContent.Add("|   Mã lớp   |                     Tên môn                     |   Mã GV   |");
            lstContent.Add("----------------------------------------------------------------------------");

            for (int j = 0; j < infoAssignedSubjects.Count; j++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignedSubjects[j].getMaLop());
                string line = "|" + getTextAlignCenter(infoAssignTeacher.getMaLop().ToString(), 12) + "|";
                line += getTextAlignCenter(infoAssignTeacher.getNameSubject(), 49) + "|";
                line += getTextAlignCenter(infoAssignTeacher.getMaGV(), 11) + "|";
                lstContent.Add(line);
                lstContent.Add("----------------------------------------------------------------------------");

            }

            File.WriteAllLines(nameFile, lstContent);
            MessageInfo.makeMessage("Information", "Chúc mừng", "In phiếu thành công!");
        }
    }
}
