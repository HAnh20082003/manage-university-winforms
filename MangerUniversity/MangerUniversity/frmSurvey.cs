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
    public partial class frmSurvey : Form
    {
        List<InfoAssignSubject> lstInfoAssigns;
        Student student;
        InfoAssignSubject currentInfoAssignSubject;
        public frmSurvey(string nameAcct)
        {
            InitializeComponent();
            string MaSV = (string)Account.getField("ID", "TenTK", nameAcct);
            student = (Student) Person.getInfo("ID", MaSV);
            cbbYear.Items.Clear();
            cbbYear.Items.Clear();
            for (int i = 1; i <= student.getYear(); i++)
            {
                cbbYear.Items.Add("Năm " + i);
            }
            cbbYear.SelectedIndex = cbbYear.Items.Count - 1;
        }
        GroupBox getGroupSubject(InfoAssignSubject infoAssignSubject)
        {
            MarkSubject mark = MarkSubject.getInfo(infoAssignSubject.getMaLop(), student.getID(), infoAssignSubject.getHocKi(), infoAssignSubject.getYear());
            GroupBox gb = new GroupBox()
            {
                Size = new Size(580, 200),
                Cursor = Cursors.Hand,
                Tag = infoAssignSubject,
                BackColor = Color.LavenderBlush,
            };

            int xstart = 5, yStart = 10;
            Label lblMaLop = new Label()
            {
                Text = "Mã lớp: " + infoAssignSubject.getMaLop(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaLop);
            yStart += 27;

            InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignSubject.getMaLop());
            Label lblNameSub = new Label()
            {
                Text = "Tên môn: " + infoAssignTeacher.getNameSubject(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameSub);
            yStart += 27;
            Label lblMaGV = new Label()
            {
                Text = "Mã lớp: " + infoAssignTeacher.getMaGV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaGV);

            yStart += 27;
            Label lblHocKi = new Label()
            {
                Text = "Học kì: " + infoAssignSubject.getHocKi(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblHocKi);

            yStart += 27;
            Label lblNam = new Label()
            {
                Text = "Năm: " + infoAssignSubject.getYear(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNam);

            string diemTB = "Chưa có";

            if (mark != null)
            {
                diemTB = mark.caculateDTB().ToString();
            }

            yStart += 27;
            Label lblDiemTB = new Label()
            {
                Text = "Điểm TB: " + diemTB,
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblDiemTB);
            gb.Click += selectAssignSubject;
            return gb;
        }

        void clearSurvey()
        {
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

        private void selectAssignSubject(object sender, EventArgs e)
        {
            currentInfoAssignSubject = (InfoAssignSubject)((Control)sender).Tag;
            MarkSubject mark = MarkSubject.getInfo(currentInfoAssignSubject.getMaLop(), student.getID(), currentInfoAssignSubject.getHocKi(), currentInfoAssignSubject.getYear());
            if (mark == null || cbbYear.SelectedIndex + 1 != student.getYear() || cbbHocKi.SelectedIndex + 1 != student.getHocKi())
            {
                gbSurvey.Enabled = false;
                clearSurvey();
                return;
            }
            clearSurvey();
            gbSurvey.Enabled = true;
            Survey survey = Survey.getSurvey(student.getID(), currentInfoAssignSubject.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
            if (survey == null)
            {
                return;
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

        void loadInfoAssignSubject()
        {
            fpnInfoAssignSubjects.Controls.Clear();
            for (int i = 0; i < lstInfoAssigns.Count; i++)
            {
                fpnInfoAssignSubjects.Controls.Add(getGroupSubject(lstInfoAssigns[i]));
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentInfoAssignSubject == null)
            {
                return;
            }
            int[] content = new int[5];
            foreach (Control pn in gbSurvey.Controls)
            {
                if (pn is Panel)
                {
                    int index = int.Parse(pn.Tag.ToString()) - 1;
                    foreach (Control rdo in pn.Controls)
                    {
                        if (rdo is RadioButton)
                        {
                            RadioButton radio = (RadioButton)rdo;
                            if (radio.Checked)
                            {
                                content[index] = int.Parse(rdo.Tag.ToString());
                                break;
                            }
                        }
                    }
                }
            }
            Survey survey = Survey.getSurvey(student.getID(), currentInfoAssignSubject.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
            if (survey == null)
            {
                survey = new Survey(student.getID(), currentInfoAssignSubject.getMaLop(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1, content);
                if (survey.insertSurvey())
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Đã gửi khảo sát!");
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Gửi khảo sát thất bại!");
                }
            }
            else
            {
                if (survey.updateSurvey(content))
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Cập nhật khảo sát thành công!");
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Cập nhật khảo sát thất bại!");
                }
            }
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
                cbbHocKi.Items.Add("Học kì " + i);
            }
            cbbHocKi.SelectedIndex = cbbHocKi.Items.Count - 1;
            gbSurvey.Enabled = false;
            clearSurvey();
        }
        private void cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbYear.SelectedIndex == -1)
            {
                return;
            }
            lstInfoAssigns = student.getInfoAssignSubject();
            cbbMaGV.Items.Clear();
            cbbMaGV.Items.Add("Hiển thị toàn bộ");
            for (int i = 0; i < lstInfoAssigns.Count; i++)
            {
                if (cbbYear.SelectedIndex + 1 != lstInfoAssigns[i].getYear())
                {
                    continue;
                }
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(lstInfoAssigns[i].getMaLop());
                cbbMaGV.Items.Add(infoAssignTeacher.getMaGV());
            }
            cbbMaGV.SelectedIndex = 0;
            gbSurvey.Enabled = false;
            clearSurvey();
        }

        private void cbbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInfoAssigns = student.getInfoAssignSubject();
            for (int i = 0; i < lstInfoAssigns.Count; i++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(lstInfoAssigns[i].getMaLop());
                if (cbbYear.SelectedIndex + 1 != lstInfoAssigns[i].getYear() || cbbMaGV.SelectedIndex != 0 && infoAssignTeacher.getMaGV() != cbbMaGV.Text)
                {
                    lstInfoAssigns.RemoveAt(i);
                    i--;
                }
            }
            gbSurvey.Enabled = false;
            clearSurvey();
            loadInfoAssignSubject();
        }
    }
}
