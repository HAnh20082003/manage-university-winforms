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
    public partial class frmManageClassroom : Form
    {
        List<Classroom> rooms;
        Classroom currentRoom;
        InfoAssignRoom currentAssign;
        public frmManageClassroom()
        {
            InitializeComponent();
            txtCountMax.KeyPress += General.number_KeyPress;
            txtTietStart.KeyPress += General.number_KeyPress;
            txtTietEnd.KeyPress += General.number_KeyPress;
            createRooms();
        }

        GroupBox getGroupSubjectAssign(InfoAssignRoom infoAssignRoom)
        {
            GroupBox gb = new GroupBox()
            {
                Text = "Tên phòng: " + infoAssignRoom.getNameRoom(),
                Size = new Size(fpnClassAssign.Width - 5, 160),
                Cursor = Cursors.Hand,
                Tag = infoAssignRoom,
                BackColor = Color.LavenderBlush,
                Font = new Font("Times New Roman",9,FontStyle.Bold),
            };

            int xstart = 10, yStart = 30;

            Label lblSTT = new Label()
            {
                Text = "Mã lớp: " + infoAssignRoom.getMaLop(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblSTT);
            yStart += 27;
            InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignRoom.getMaLop());
            Subject subject = Subject.getInfo("Ten", infoAssignTeacher.getNameSubject());

            

            Label lblNameSubject = new Label()
            {
                Text = "Tên môn: " + subject.getName().ToString(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblNameSubject);
            yStart += 27;

            Label lblMaGV = new Label()
            {
                Text = "Mã GV: " + infoAssignTeacher.getMaGV(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblMaGV);
            yStart += 27;

            Label lblDateStart = new Label()
            {
                Text = infoAssignRoom.getStrDayOfWeek() + ", Từ ngày: " + infoAssignRoom.getDateStart().getDateNotDayOfWeek('/') + " - " + infoAssignRoom.getDateEnd().getDateNotDayOfWeek('/'),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblDateStart);
            yStart += 27;

            Label lblTiet = new Label()
            {
                Text = "Tiết bắt đầu từ: " + infoAssignRoom.getTietStart() + " - " + infoAssignRoom.getTietEnd(),
                ForeColor = Color.Teal,
                Location = new Point(xstart, yStart),
                AutoSize = true,
            };
            gb.Controls.Add(lblTiet);
            gb.Click += selectSubjectAssign;
            return gb;
        }

        private void selectSubjectAssign(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)sender;
            InfoAssignRoom infoAssignRoom = (InfoAssignRoom)gb.Tag;
            InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignRoom.getMaLop());
            Subject sub = Subject.getInfo("Ten", infoAssignTeacher.getNameSubject());
            loadSubject();
            dtpDateStart.Value = infoAssignRoom.getDateStart().getDate();
            dtpDateEnd.Value = infoAssignRoom.getDateEnd().getDate();
            txtTietStart.Text = infoAssignRoom.getTietStart().ToString();
            txtTietEnd.Text = infoAssignRoom.getTietEnd().ToString();
            checkDayOfWeek(infoAssignRoom.getStrDayOfWeek());
            currentAssign = infoAssignRoom;
            gbSubject.Enabled = true;
            lvClassSubject.Enabled = true;
            for (int i = 0; i < lvClassSubject.Items.Count; i++)
            {

                if (sub.getName() == lvClassSubject.Items[i].SubItems[2].Text && infoAssignRoom.getMaLop() == int.Parse(lvClassSubject.Items[i].SubItems[0].Text) && infoAssignTeacher.getMaGV() == lvClassSubject.Items[i].SubItems[1].Text)
                {
                    lvClassSubject.Items[i].Checked = true;
                    break;
                }
            }
            btnAssignSubject.Enabled = false;
            btnCancelSubject.Enabled = true;
            btnSave.Enabled = true;
            gbSubject.Text = "Chỉnh sửa thông tin đăng ký";
        }

        void createRooms()
        {
            rooms = Classroom.getAllRooms();
            loadRooms();
        }
        void resetInputSubject()
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now;
            txtTietStart.Clear();
            txtTietEnd.Clear();
        }
        void loadRooms()
        {
            cbbAssignRoom.Items.Clear();
            btnAssignSubject.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            gbInfo.Text = "Thông tin phòng";
            fpnClassAssign.Controls.Clear();
            
            int xStart = 30, yStart = 20;
            int widthRoom = 150;
            int heightRoom = 80;
            int far = 20;
            pnClassRoom.Controls.Clear();
            for (int i = 0; i < rooms.Count; i++)
            {
                GroupBox gb = new GroupBox()
                {
                    Text = rooms[i].getName(),
                    ForeColor = Color.Purple,
                    Size = new Size(widthRoom, heightRoom),
                    Location = new Point(xStart, yStart),
                    Tag = new Classroom(rooms[i].getName(), rooms[i].getMaxCount()),
                    Cursor = Cursors.Hand,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold),
                    BackColor = Color.OldLace,
                };
                int x = 10, y = 20;
                Label lblMaxCount = new Label()
                {
                    Name = "lblMaxCount",
                    Location = new Point(x, y),
                    AutoSize = true,
                };
                lblMaxCount.Text = "Sức chứa: " + rooms[i].getMaxCount();
                gb.Controls.Add(lblMaxCount);
                xStart += widthRoom + far;
                if (xStart + widthRoom + far >= pnClassRoom.Width)
                {
                    xStart = 30;
                    yStart += heightRoom + far;
                }
                gb.Click += selectRoom;
                pnClassRoom.Controls.Add(gb);
            }
        }

        private void cbbAssignRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAssignRoom.SelectedIndex == -1)
            {
                cbbAssignRoom.SelectedIndex = 0;
                return;
            }
            if (cbbAssignRoom.SelectedIndex == 0)
            {
                loadSubjectAssignRoom();
            }
            else
            {
                gbSubject.Text = "Đăng ký phòng " + currentRoom.getName();
                currentAssign = null;
                fpnClassAssign.Controls.Clear();
                btnSearch.Enabled = true;
                btnAssignSubject.Enabled = false;
                btnSave.Enabled = false;
                btnCancelSubject.Enabled = false;
                string item = cbbAssignRoom.Items[cbbAssignRoom.SelectedIndex].ToString();
                int maLop = int.Parse(item.Substring(item.LastIndexOf(' ')));
                List<InfoAssignRoom> assignRooms = Classroom.getAssignRoom(currentRoom.getName());
                for (int i = 0; i < assignRooms.Count; i++)
                {
                    if (assignRooms[i].getMaLop() == maLop)
                    {
                        fpnClassAssign.Controls.Add(getGroupSubjectAssign(assignRooms[i]));
                    }
                }
            }
        }

        private void selectRoom(object sender, EventArgs e)
        {
            cbbAssignRoom.Enabled = true;
            currentRoom = (Classroom)((Control)sender).Tag;
            txtName.Text = currentRoom.getName();
            txtCountMax.Text = currentRoom.getMaxCount().ToString();
            gbInfo.Enabled = true;
            lvClassSubject.Enabled = true;
            gbSubject.Enabled = true;
            btnDelete.Enabled = true;
            gbInfo.Text = "Chỉnh sửa thông tin phòng " + currentRoom.getName();
            cbbAssignRoom.Items.Clear();
            cbbAssignRoom.Items.Add("Toàn bộ đăng ký");
            List<InfoAssignRoom> assignRooms = Classroom.getAssignRoom(currentRoom.getName());
            for (int i = 0; i < assignRooms.Count; i++)
            {
                bool isOk = true;
                for (int j = 0; j < cbbAssignRoom.Items.Count; j++)
                {
                    if (cbbAssignRoom.Items[j].ToString() == "Mã lớp " + assignRooms[i].getMaLop())
                    {
                        isOk = false;
                        break;
                    }
                }
                if (isOk)
                {
                    cbbAssignRoom.Items.Add("Mã lớp " + assignRooms[i].getMaLop());
                }
            }
            cbbAssignRoom.SelectedIndex = 0;
            loadSubject();
            if (string.IsNullOrEmpty(txtTietStart.Text) || string.IsNullOrEmpty(txtTietEnd.Text))
            {
                btnAssignSubject.Enabled = false;
                btnSave.Enabled = false;
                btnCancelSubject.Enabled = false;
            }
            else
            {   
                btnAssignSubject.Enabled = true;
                btnSave.Enabled = false;
                btnCancelSubject.Enabled = false;
            }
        }
        void loadSubjectAssignRoom()
        {
            currentAssign = null;
            fpnClassAssign.Controls.Clear();
            List<InfoAssignRoom> assignRooms = Classroom.getAssignRoom(currentRoom.getName());
            for (int i = 0; i < assignRooms.Count; i++)
            {
                fpnClassAssign.Controls.Add(getGroupSubjectAssign(assignRooms[i]));
            }
            gbSubject.Text = "Đăng ký phòng " + currentRoom.getName();
        }

        void loadSubject()
        {
            lvClassSubject.Items.Clear(); 
            List<InfoAssignTeacher> infos = InfoAssignTeacher.getAllAssign();
            for (int i = 0; i < infos.Count; i++)
            {
                ListViewItem li = new ListViewItem()
                {
                    Text = infos[i].getMaLop().ToString(),
                };
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = infos[i].getMaGV() });
                li.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = infos[i].getNameSubject() });
                lvClassSubject.Items.Add(li);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCountMax.Clear();
            gbInfo.Enabled = true;
            currentAssign = null;
            currentRoom = null;
            gbInfo.Text = "Thêm phòng học";
            btnDelete.Enabled = false;
            cbbAssignRoom.Enabled = false;
            loadRooms();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbInfo.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đủ thông tin phòng!");
                        c.Focus();
                        return;
                    }
                }
            }
            if (currentRoom == null)
            {
                Classroom room = new Classroom(txtName.Text, int.Parse(txtCountMax.Text));
                if (room.addNewRoom())
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Thêm phòng thành công!");
                    FilterRooms();
                }
            }
            else
            {
                List<Subject> subs = currentRoom.getSubject();
                for (int i = 0; i < subs.Count; i++)
                {
                    List<Teacher> teachers = subs[i].getTeacherTeach();
                    for (int j = 0; j < teachers.Count; j++)
                    {
                        List<InfoAssignTeacher> infoAssigns = InfoAssignTeacher.getAllAssign();
                        for (int k = 0; k < infoAssigns.Count; k++)
                        {
                            List<Student> students = InfoAssignSubject.getStudentsAssignSubject(infoAssigns[k].getMaLop());
                            if (students.Count > int.Parse(txtCountMax.Text))
                            {
                                MessageInfo.makeMessage("Error", "Rất tiếc", "Sửa sỉ số tối đa của phòng thất bại!");
                                currentRoom.updateRoom(txtName.Text, currentRoom.getMaxCount());
                                txtCountMax.Text = currentRoom.getMaxCount().ToString();
                                return;
                            }
                        }
                    }
                }
                if (currentRoom.updateRoom(txtName.Text, int.Parse(txtCountMax.Text)))
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Đã sửa thành công!");
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Thêm phòng thất bại!");
                }
                FilterRooms();
            }
        }
        private void btnCancelSubject_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc chắn muốn huỷ đăng ký phòng?") != DialogResult.Yes)
            {
                return;
            }
            try
            {
                if (currentAssign.deleteAssignRoom())
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Huỷ đăng ký phòng thành công!");
                    loadSubject();
                    loadSubjectAssignRoom();
                    btnAssignSubject.Enabled = true;
                    btnCancelSubject.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Huỷ đăng ký phòng thất bại!");
                }
            }
            catch
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Huỷ đăng ký phòng thất bại!");
            }
        }

        string findDayOfWeek()
        {
            foreach (Control control in pnDayOfWeek.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked)
                    {
                        return control.Text;
                    }
                }
            }
            return null;
        }
        void checkDayOfWeek(string dayOfWeek)
        {
            foreach (Control control in pnDayOfWeek.Controls)
            {
                if (control is RadioButton)
                {
                    if (control.Text == dayOfWeek)
                    {
                        ((RadioButton)control).Checked = true;
                    }
                }
            }
        }

        private void btnAssignSubject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTietStart.Text) || string.IsNullOrEmpty(txtTietEnd.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đủ thông tin!");
                return;
            }
            if (lvClassSubject.CheckedIndices.Count == 0)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn lớp để đăng ký phòng!");
                return;
            }
            try
            {
                Date dateStart = new Date(dtpDateStart.Value);
                Date dateEnd = new Date(dtpDateEnd.Value);
                if (Date.compareDate(dateStart, dateEnd) == 1)
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                    return;
                }
                int tietStart = int.Parse(txtTietStart.Text);
                int tietEnd = int.Parse(txtTietEnd.Text);
                if (tietStart > tietEnd)
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tiết bắt đầu không được lớn nhớ tiết kết thúc!");
                    return;
                }
                string dayOfWeek = findDayOfWeek();

                ListViewItem li = lvClassSubject.Items[lvClassSubject.CheckedIndices[0]];
                int maLop = int.Parse(li.SubItems[0].Text);
                List<InfoAssignRoom> infoRoomsByMaLop = Classroom.getAssignRoom(maLop);
                for (int i = 0; i < infoRoomsByMaLop.Count; i++)
                {
                    if (General.isDateAInB(dateStart, dateEnd, tietStart, tietEnd, dayOfWeek, infoRoomsByMaLop[i].getDateStart(), infoRoomsByMaLop[i].getDateEnd(), infoRoomsByMaLop[i].getTietStart(), infoRoomsByMaLop[i].getTietEnd(), infoRoomsByMaLop[i].getStrDayOfWeek()))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Mã lớp " + maLop + " đã đăng ký: " + infoRoomsByMaLop[i].getCalender() + "!");
                        return;
                    }
                }
                List<InfoAssignRoom> infoRoomsByNameRoom = Classroom.getAssignRoom(currentRoom.getName());
                for (int i = 0; i < infoRoomsByNameRoom.Count; i++)
                {
                    if (General.isDateAInB(dateStart, dateEnd, tietStart, tietEnd, dayOfWeek, infoRoomsByNameRoom[i].getDateStart(), infoRoomsByNameRoom[i].getDateEnd(), infoRoomsByNameRoom[i].getTietStart(), infoRoomsByNameRoom[i].getTietEnd(), infoRoomsByNameRoom[i].getStrDayOfWeek()))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Phòng đã được đăng ký: " + infoRoomsByNameRoom[i].getCalender() + "!");
                        return;
                    }
                }
                int STT = int.Parse(li.SubItems[0].Text);
                InfoAssignRoom info = new InfoAssignRoom(currentRoom.getName(), STT, dateStart, dateEnd, tietStart, tietEnd, dayOfWeek);
                if (info.addAssignRoom())
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Đăng ký phòng thành công!");
                    loadSubject();
                    loadSubjectAssignRoom();
                }
                else
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký phòng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký phòng thất bại! " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentRoom != null)
            {
                if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc chắn muốn xoá phòng " + currentRoom.getName() +"?") != DialogResult.Yes)
                {
                    return;
                }
                currentRoom.deleteRoom();
                currentRoom = null;
                btnDelete.Enabled = false;
                cbbAssignRoom.Enabled = false;
                FilterRooms();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvClassSubject.CheckedIndices.Count == 0)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn môn để chỉnh sửa!");
                return;
            }
            ListViewItem li = lvClassSubject.Items[lvClassSubject.CheckedIndices[0]];
            int STT = int.Parse(li.SubItems[0].Text);
            string dayOfWeek = findDayOfWeek();
            InfoAssignRoom info = new InfoAssignRoom(currentRoom.getName(), STT, new Date(dtpDateStart.Value), new Date(dtpDateEnd.Value), int.Parse(txtTietStart.Text), int.Parse(txtTietEnd.Text), dayOfWeek);
            if (currentAssign.updateAssignRoom(info))
            {
                loadSubjectAssignRoom();
                currentAssign = info;
            }
            else
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Chỉnh sửa thông tin lớp thất bại!");
            }
        }

        private void lvSubjects_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvClassSubject.CheckedIndices.Count == 0 && currentAssign == null)
            {
                return;
            }
            if (e.Item.Checked == false)
            {
                return;
            }
            if (lvClassSubject.CheckedIndices.Count >= 1)
            {
                for (int i = 0; i < lvClassSubject.CheckedIndices.Count; i++)
                {
                    if (lvClassSubject.Items[lvClassSubject.CheckedIndices[i]] != e.Item)
                    {
                        lvClassSubject.Items[lvClassSubject.CheckedIndices[i]].Checked = false;
                    }
                }
            }
            gbSubject.Enabled = true;
            if (currentAssign == null)
            {
                btnAssignSubject.Enabled = true;
                btnSave.Enabled = false;
                btnCancelSubject.Enabled = false;
                gbSubject.Text = "Đăng ký phòng " + currentRoom.getName();
            }
            else
            {                
                btnCancelSubject.Enabled = true;
                btnSave.Enabled = true;
                btnAssignSubject.Enabled = false;
                gbSubject.Text = "Chỉnh sửa thông tin đăng ký phòng " + currentRoom.getName();
            }
            
        }


        void FilterRooms()
        {
            rooms = Classroom.getAllRooms();
            Date dateStart = new Date(dtpDateStart.Value);
            Date dateEnd = new Date(dtpDateEnd.Value);
            if (string.IsNullOrEmpty(txtTietStart.Text) || string.IsNullOrEmpty(txtTietEnd.Text))
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        if (rooms[i].getName() != txtSearch.Text)
                        {
                            rooms.RemoveAt(i);
                            i--;
                        }
                    }
                }
                loadRooms();
                return;
            }
            string dayOfWeek = findDayOfWeek();
            int tietStart = int.Parse(txtTietStart.Text);
            int tietEnd = int.Parse(txtTietEnd.Text);
            for (int i = 0; i < rooms.Count; i++)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    if (rooms[i].getName() != txtSearch.Text)
                    {
                        rooms.RemoveAt(i);
                        i--;
                        continue;
                    }
                }
                List<InfoAssignRoom> infoRooms = Classroom.getAssignRoom(rooms[i].getName());
                for (int j = 0; j < infoRooms.Count; j++)
                {
                    if (General.isDateAInB(infoRooms[j].getDateStart(), infoRooms[j].getDateEnd(), infoRooms[j].getTietStart(), infoRooms[j].getTietEnd(), infoRooms[j].getStrDayOfWeek() , dateStart, dateEnd, tietStart, tietEnd, dayOfWeek))
                    {
                        rooms.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            loadRooms();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterRooms();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInputSubject();
            btnAssignSubject.Enabled = false;
            btnSave.Enabled = false;
            btnCancelSubject.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Clear();
            txtCountMax.Clear();
            createRooms();
            currentRoom = null;
            fpnClassAssign.Controls.Clear();
            lvClassSubject.Items.Clear();
            cbbAssignRoom.Enabled = false;
        }

    }
}
