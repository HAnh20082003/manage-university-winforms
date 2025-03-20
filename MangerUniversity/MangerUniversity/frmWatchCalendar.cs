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
    public partial class frmWatchCalendar : Form
    {
        private Teacher teacher;
        private Student student;
        private List<HistoryAssignRoom> historyInfoAssignRooms;
        private List<InfoAssignRoom> infoAssignRooms;
        private  Date startDate = null, endDate = null;
        private Label[,] cells;
        int widthCell = 150;
        int heightCell = 37;
        public frmWatchCalendar(string nameAcct)
        {
            InitializeComponent();
            string ID = (string) Account.getField("ID", "TenTK", nameAcct);
            loadCellCalendar();
            if (Student.isExistStudentID(ID))
            {
                student = (Student)Person.getInfo("ID", ID);
                cbbYear.Items.Clear();
                for (int i = 1; i <= student.getYear();i++)
                {
                    cbbYear.Items.Add("Năm " + i);
                }
                cbbYear.SelectedIndex = student.getYear() - 1;
            }
            else
            {
                Text = "Xem lịch dạy học";
                lblTitle.Text = "XEM LỊCH DẠY HỌC";
                lblTitle.Left = cbbDate.Left + cbbDate.Width / 2 - lblTitle.Width / 2;
                teacher = (Teacher)Person.getInfo("ID", ID);
                loadDate();
                Controls.Remove(cbbHocKi);
                Controls.Remove(cbbYear);
            }
        }

        void loadDate()
        {
            startDate = endDate = null;
            infoAssignRooms = new List<InfoAssignRoom>();
            if (student != null)
            {
                List<InfoAssignSubject> infoAssignSubjects = student.getInfoAssignSubject();
                for (int i = 0; i < infoAssignSubjects.Count; i++)
                {
                    if (infoAssignSubjects[i].getHocKi() != cbbHocKi.SelectedIndex + 1 || infoAssignSubjects[i].getYear() != cbbYear.SelectedIndex + 1)
                    {
                        infoAssignSubjects.RemoveAt(i);
                        i--;
                        continue;
                    }
                    if (cbbYear.SelectedIndex + 1 == student.getYear() && cbbHocKi.SelectedIndex + 1 == student.getHocKi())
                    {
                        List<InfoAssignRoom> tmpInfoAssignRooms = InfoAssignRoom.getInfo(infoAssignSubjects[i].getMaLop());
                        for (int j = 0; j < tmpInfoAssignRooms.Count; j++)
                        {
                            if (startDate == null)
                            {
                                startDate = tmpInfoAssignRooms[j].getDateStart();
                            }
                            else if (Date.compareDate(tmpInfoAssignRooms[j].getDateStart(), startDate) == -1)
                            {
                                startDate = tmpInfoAssignRooms[j].getDateStart();
                            }
                            if (endDate == null)
                            {
                                endDate = tmpInfoAssignRooms[j].getDateEnd();
                            }
                            else if (Date.compareDate(tmpInfoAssignRooms[j].getDateEnd(), endDate) == 1)
                            {
                                endDate = tmpInfoAssignRooms[j].getDateEnd();
                            }
                            infoAssignRooms.Add(tmpInfoAssignRooms[j]);
                        }
                    }
                    else
                    {
                        historyInfoAssignRooms = HistoryAssignRoom.getInfo(student.getID(), cbbHocKi.SelectedIndex + 1, cbbYear.SelectedIndex + 1);
                        for (int j = 0; j < historyInfoAssignRooms.Count; j++)
                        {
                            if (historyInfoAssignRooms[j].getInfoAssignRoom().getMaLop() != infoAssignSubjects[i].getMaLop())
                            {
                                historyInfoAssignRooms.RemoveAt(j);
                                j--;
                                continue;
                            }
                            Date dateStart = historyInfoAssignRooms[j].getInfoAssignRoom().getDateStart();
                            Date dateEnd = historyInfoAssignRooms[j].getInfoAssignRoom().getDateStart();
                            if (startDate == null)
                            {
                                startDate = dateStart;
                            }
                            else if (Date.compareDate(dateStart, startDate) == -1)
                            {
                                startDate = dateStart;
                            }
                            if (endDate == null)
                            {
                                endDate = dateEnd;
                            }
                            else if (Date.compareDate(dateEnd, endDate) == 1)
                            {
                                endDate = dateEnd;
                            }
                        }
                    }
                }
            }
            else
            {
                List<InfoAssignTeacher> infoAssignTeachers = teacher.getInfoAssign();
                for (int i = 0; i < infoAssignTeachers.Count; i++)
                {
                    List<InfoAssignRoom> tmpInfoAssignRooms = InfoAssignRoom.getInfo(infoAssignTeachers[i].getMaLop());
                    for (int j = 0; j < tmpInfoAssignRooms.Count; j++)
                    {
                        if (startDate == null)
                        {
                            startDate = tmpInfoAssignRooms[j].getDateStart();
                        }
                        else if (Date.compareDate(tmpInfoAssignRooms[j].getDateStart(), startDate) == -1)
                        {
                            startDate = tmpInfoAssignRooms[j].getDateStart();
                        }
                        if (endDate == null)
                        {
                            endDate = tmpInfoAssignRooms[j].getDateEnd();
                        }
                        else if (Date.compareDate(tmpInfoAssignRooms[j].getDateEnd(), endDate) == 1)
                        {
                            endDate = tmpInfoAssignRooms[j].getDateEnd();
                        }
                        infoAssignRooms.Add(tmpInfoAssignRooms[j]);
                    }
                }
            }
            cbbDate.Items.Clear();
            if (startDate != null)
            {
                while(startDate.getDayOfWeek() != DayOfWeek.Monday)
                {
                    startDate = Date.getPrevDate(startDate);
                }
                while (endDate.getDayOfWeek() != DayOfWeek.Sunday)
                {
                    endDate = Date.getNextDate(endDate);
                }
                Date date = new Date(startDate.getStrDayOfWeek(), startDate.getDay(), startDate.getMonth(), startDate.getYear());
                while (Date.compareDate(date, endDate) == -1)
                {
                    string itemDate = date.getDateNotDayOfWeek('/');
                    for (int i = 0; i < 6; i++)
                    {
                        date = Date.getNextDate(date);
                    }
                    itemDate += " đến " +date.getDateNotDayOfWeek('/');
                    cbbDate.Items.Add(itemDate);
                    date = Date.getNextDate(date);
                }
                cbbDate.SelectedIndex = 0;
            }
            if (cbbDate.Items.Count == 0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = false;
            }
        }

        void loadCellCalendar()
        {
            pnCalendar.Controls.Clear();
            int x = 0;
            int y = 0;
            cells = new Label[14, 7];
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    cells[i, j] = new Label()
                    {
                        AutoSize = false,
                        Size = new Size(widthCell, heightCell),
                        Location = new Point(x, y),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = x + " " + y,
                        BackColor= Color.White,
                    };
                    pnCalendar.Controls.Add(cells[i, j]);
                    x += widthCell;
                }
                x = 0;
                y += heightCell;
            }
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHocKi.Items.Clear();
            if (cbbYear.SelectedIndex + 1 == student.getYear())
            {
                for (int i = 1; i <= student.getHocKi(); i++)
                {
                    cbbHocKi.Items.Add("Học kì " + i);
                }
                cbbHocKi.SelectedIndex = student.getHocKi() - 1;
            }
            else
            {
                for (int i = 1; i <= 2; i++)
                {
                    cbbHocKi.Items.Add("Học kì " + i);
                }
                cbbHocKi.SelectedIndex = 0;
            }
        }

        private void cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDate();
        }

        Label getLabel(string text)
        {
            return new Label()
            {
                Text = text,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                ForeColor = Color.Indigo,
                AutoSize = false,
                Size = new Size(widthCell - 10, 30),
            };
        }

        void  enableButton()
        {
            if (cbbDate.SelectedIndex == 0)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
            if (cbbDate.SelectedIndex == cbbDate.Items.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            cbbDate.SelectedIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cbbDate.SelectedIndex++;
        }

        FlowLayoutPanel getBox(int width, int height, int xStart, int yStart)
        {
            return new FlowLayoutPanel()
            {
                Size = new Size(width, height),
                Location = new Point(xStart, yStart),
                AutoScroll = true,
                BackColor = Color.Pink,
                BorderStyle = BorderStyle.FixedSingle,
            };
        }

        private void cbbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDate.SelectedIndex == -1)
            {
                return;
            }
            enableButton();
            loadCellCalendar();
            string strDateStart = cbbDate.Text.Substring(0, cbbDate.Text.IndexOf(' '));
            Date dateStart = new Date(strDateStart, '/');
            if (student != null)
            {
                int l = 0;
                while (dateStart.getStrDayOfWeek() != "Chủ Nhật")
                {
                    if (cbbYear.SelectedIndex + 1 == student.getYear() && cbbHocKi.SelectedIndex + 1 == student.getHocKi())
                    {
                        for (int j = 0; j < infoAssignRooms.Count; j++)
                        {
                            if (dateStart.getStrDayOfWeek() == infoAssignRooms[j].getStrDayOfWeek())
                            {
                                if (Date.compareDate(infoAssignRooms[j].getDateStart(), dateStart) <= 0 && Date.compareDate(infoAssignRooms[j].getDateEnd(), dateStart) >= 0)
                                {
                                    int width = widthCell;
                                    int height = 0;
                                    for (int k = infoAssignRooms[j].getTietStart(); k <= infoAssignRooms[j].getTietEnd(); k++)
                                    {
                                        height += heightCell;
                                        pnCalendar.Controls.Remove(cells[k - 1, l]);
                                    }
                                    string[] split = cells[infoAssignRooms[j].getTietStart() - 1, l].Tag.ToString().Split(' ');
                                    int yStart = int.Parse(split[1]);
                                    int xStart = int.Parse(split[0]);
                                    FlowLayoutPanel fpn = getBox(width, height, xStart, yStart);
                                    InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignRooms[j].getMaLop());
                                    fpn.Controls.Add(new Label() { Text = infoAssignTeacher.getNameSubject(), Size = new Size(widthCell - 10, 50), Font = new Font("Times New Roman", 10, FontStyle.Bold), ForeColor = Color.Navy });
                                    fpn.Controls.Add(getLabel("Mã lớp: " + infoAssignRooms[j].getMaLop()));
                                    fpn.Controls.Add(getLabel(infoAssignRooms[j].getNameRoom()));
                                    fpn.Controls.Add(getLabel("Mã GV: " + infoAssignTeacher.getMaGV()));
                                    pnCalendar.Controls.Add(fpn);
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < historyInfoAssignRooms.Count; j++)
                        {
                            if (dateStart.getStrDayOfWeek() == historyInfoAssignRooms[j].getInfoAssignRoom().getStrDayOfWeek())
                            {
                                if (Date.compareDate(historyInfoAssignRooms[j].getInfoAssignRoom().getDateStart(), dateStart) <= 0 && Date.compareDate(historyInfoAssignRooms[j].getInfoAssignRoom().getDateEnd(), dateStart) >= 0)
                                {
                                    int width = widthCell;
                                    int height = 0;
                                    for (int k = historyInfoAssignRooms[j].getInfoAssignRoom().getTietStart(); k <= historyInfoAssignRooms[j].getInfoAssignRoom().getTietEnd(); k++)
                                    {
                                        height += heightCell;
                                        pnCalendar.Controls.Remove(cells[k - 1, l]);
                                    }
                                    string[] split = cells[historyInfoAssignRooms[j].getInfoAssignRoom().getTietStart() - 1, l].Tag.ToString().Split(' ');
                                    int yStart = int.Parse(split[1]);
                                    int xStart = int.Parse(split[0]);
                                    FlowLayoutPanel fpn = getBox(width, height, xStart, yStart);
                                    fpn.Controls.Add(new Label() { Text = historyInfoAssignRooms[j].getNameSubject(), Size = new Size(widthCell - 10, 40), Font = new Font("Times New Roman", 10, FontStyle.Bold), ForeColor = Color.Navy });
                                    fpn.Controls.Add(getLabel("Mã lớp: " + historyInfoAssignRooms[j].getInfoAssignRoom().getMaLop()));
                                    fpn.Controls.Add(getLabel(historyInfoAssignRooms[j].getInfoAssignRoom().getNameRoom()));
                                    fpn.Controls.Add(getLabel("Mã GV: " + historyInfoAssignRooms[j].getMaGV()));
                                    pnCalendar.Controls.Add(fpn);
                                }
                            }
                        }
                    }
                    dateStart = Date.getNextDate(dateStart);
                    l++;
                }
            }
            else
            {
                int l = 0;
                while (dateStart.getStrDayOfWeek() != "Chủ Nhật")
                {
                    for (int j = 0; j < infoAssignRooms.Count; j++)
                    {
                        if (dateStart.getStrDayOfWeek() == infoAssignRooms[j].getStrDayOfWeek())
                        {
                            if (Date.compareDate(infoAssignRooms[j].getDateStart(), dateStart) <= 0 && Date.compareDate(infoAssignRooms[j].getDateEnd(), dateStart) >= 0)
                            {
                                int width = widthCell;
                                int height = 0;
                                for (int k = infoAssignRooms[j].getTietStart(); k <= infoAssignRooms[j].getTietEnd(); k++)
                                {
                                    height += heightCell;
                                    pnCalendar.Controls.Remove(cells[k - 1, l]);
                                }
                                string[] split = cells[infoAssignRooms[j].getTietStart() - 1, l].Tag.ToString().Split(' ');
                                int yStart = int.Parse(split[1]);
                                int xStart = int.Parse(split[0]);
                                FlowLayoutPanel fpn = getBox(width, height, xStart, yStart);
                                InfoAssignTeacher info = InfoAssignTeacher.getInfo(infoAssignRooms[j].getMaLop());
                                fpn.Controls.Add(new Label() { Text = info.getNameSubject(), Size = new Size(widthCell - 10, 50), Font = new Font("Times New Roman", 10, FontStyle.Bold), ForeColor = Color.Navy });
                                fpn.Controls.Add(getLabel("Mã lớp: " + infoAssignRooms[j].getMaLop()));
                                fpn.Controls.Add(getLabel(infoAssignRooms[j].getNameRoom()));
                                fpn.Controls.Add(getLabel("Mã GV: " + info.getMaGV()));
                                pnCalendar.Controls.Add(fpn);
                            }
                        }
                    }
                    dateStart = Date.getNextDate(dateStart);
                    l++;
                }
            }
        }
    }
}
