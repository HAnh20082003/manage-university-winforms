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
    public partial class frmManageSchool : Form
    {
        Account account;
        public string typeAcct, nameAct;
        Person info;
        public bool quickClose = false;
        public string newPathAvatar = null;

        public frmManageSchool(string typeAcct, string nameAct)
        {
            InitializeComponent();
            this.typeAcct = typeAcct;
            this.nameAct = nameAct;
            account = new Account(nameAct);
            info = Account.getInfoByName(nameAct);
            if (typeAcct == Account.typeQT)
            {
                frmAdmin();
            }
            else if (typeAcct == Account.typeSV)
            {
                frmStudent();
            }
            else
            {
                frmTeacher();
            }
        }

        Label createItem(string name, string text)
        {
            return new Label()
            {
                Name = name,
                Text = text,
                Size = new Size(375, 30),
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                ForeColor = Color.Navy,
            };
        }

        void createInfo(string nameAct)
        {
            Image image = null;
            object tmp = Account.getField("AnhDaiDien", "TenTK", nameAct);
            if (tmp != null)
            {
                image = Avatar.ConvertBytesToImage((byte[])tmp);
            }
            ptrAvt.Image = image;
            ptrAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            dtpBirth.Value = info.getBirth().getDate();
            txtFullName.Text = info.getFullName().getFullName();
            txtPhone.Text = info.getPhone();
            txtEmail.Text = info.getEmail();
            txtAddress.Text = info.getAddress();
            fpnMoreInfo.Controls.Add(createItem("lblID", "Mã ID: " + info.getID()));
            fpnMoreInfo.Controls.Add(createItem("lblNameAcct", "Tên tài khoản: " + account.getName()));
            fpnMoreInfo.Controls.Add(createItem("lblNgayDK", "Ngày đăng ký tài khoản: " + account.getDate().getStrDate('-')));
            if (info is Teacher)
            {
                Teacher teacher = (Teacher)info;
                fpnMoreInfo.Controls.Add(createItem("lblTenKhoa", "Tên khoa: " + teacher.getTenKhoa()));
            }
            else if (info is Student)
            {
                Student student = (Student)info;
                fpnMoreInfo.Controls.Add(createItem("lblNameMajor", "Tên ngành: " + student.getNameMajor()));
                fpnMoreInfo.Controls.Add(createItem("lblHocKi", "Học kì: " + student.getHocKi()));
                fpnMoreInfo.Controls.Add(createItem("lblYear", "Năm: " + student.getYear()));
                fpnMoreInfo.Controls.Add(createItem("lblTongTC", "Số tín chỉ đã đạt: " + student.getTongSoTCDat() + " tín chỉ"));
                fpnMoreInfo.Controls.Add(createItem("lblStatus", "Trạng thái học vấn: " + student.getStatus()));
            }
        }

        
        //Event
        private void selectChangeAvt(object sender, MouseEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Tệp ảnh (*.png, *.jpg, *jpeg)|*.png;*.jpg;*.jpeg",
                Title = "Chọn ảnh đại diện của bạn (tốt nhất là ảnh có chiều dài bằng chiều rộng)",
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                newPathAvatar = openDialog.FileName;
                ptrAvt.Image = Image.FromFile(newPathAvatar);
                ptrAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void selectSaveInfo(object sender, EventArgs e)
        {
            Account account = new Account(nameAct);
            info.updateFullName(txtFullName.Text);
            info.updateBirth(new Date(dtpBirth.Value));
            info.updateAddress(txtAddress.Text);
            if (!Person.isPhoneValid(txtPhone.Text))
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Số điện thoại không hợp lệ!!");
                txtPhone.Text = info.getPhone();
                txtPhone.Focus();
            }
            else
            {
                info.updatePhone(txtPhone.Text);
                if (!Person.isEmailValid(txtEmail.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Email không hợp lệ!!");
                    txtEmail.Text = info.getEmail();
                    txtEmail.Focus();
                }
                else
                {
                    info.updateEmail(txtEmail.Text);
                }
            }
            info.updatePerson();
            if (!string.IsNullOrEmpty(newPathAvatar))
            {
                account.updateAvatar(newPathAvatar);
            }
        }

        private void selectManageAcct(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageAccount frmAcct = new frmManageAccount(info.getID());
            frmAcct.ShowDialog();
            Show();
        }
        private void selectManageKhoa(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageKhoa frm = new frmManageKhoa();
            frm.ShowDialog();
            Show();
        }
        private void selectManageSubject(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageSubject frm = new frmManageSubject();
            frm.ShowDialog();
            Show();
        }

        private void selectAssignmentTeacher(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmAssignmentTeacher frm = new frmAssignmentTeacher();
            frm.ShowDialog();
            Show();
        }

        private void selectManageClassroom(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageClassroom frm = new frmManageClassroom();
            frm.ShowDialog();
            Show();
        }
        private void selectAssignmentStudent(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmAssignmentStudent frm = new frmAssignmentStudent();
            frm.ShowDialog();
            Show();
        }
        private void selectManageSurvey(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageSurvey frm = new frmManageSurvey();
            frm.ShowDialog();
            Show();
        }

        private void selectManageStudent(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmManageStudent frm = new frmManageStudent(nameAct);
            frm.ShowDialog();
            Show();
        }
        
        private void selectWatchSurvey(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide(); 
            frmWatchSurvey frm;
            if (typeAcct == Account.typeGV)
            {
                frm = new frmWatchSurvey(nameAct);
            }
            else
            {
                frm = new frmWatchSurvey();
            }
            frm.ShowDialog();
            Show();
        }
        private void selectWatchCalendar(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmWatchCalendar frm = new frmWatchCalendar(nameAct);
            frm.ShowDialog();
            Show();
        }
        private void selectWatchSubject(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmWatchSubject frm = new frmWatchSubject(nameAct);
            frm.ShowDialog();
            Show();
        }

        private void selectEnrollSubject(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmEnrollSubject frm = new frmEnrollSubject(nameAct);
            frm.ShowDialog();
            Show();
        }

        private void selectSurvey(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Hide();
            frmSurvey frm = new frmSurvey(nameAct);
            frm.ShowDialog();
            Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc chắn muốn đăng xuất không?") != DialogResult.Yes)
            {
                return;
            }
            quickClose = true;
            Hide();
            frmSignIn frm = new frmSignIn();
            frm.ShowDialog();
            Close();
        }

        private void frmManageSchool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quickClose)
            {
                if (MessageInfo.makeMessage("Question", "Thắc mắc", "Bạn có chắc muốn thoát?") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        void frmAdmin()
        {
            BackColor = Color.CadetBlue;
            Text = "Quản lý hoạt động giảng dạy - Quản trị - " + info.getID();
            createInfo(nameAct);
            int xStart = 50, yStart = 20;
            int far = 20;
            Button btnManageAcct = BoxButton.getButton("btnManageAcct", "Account", "Quản lý tài khoản", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageAcct);
            btnManageAcct.MouseClick += selectManageAcct;

            xStart += btnManageAcct.Width + far;
            Button btnManageKhoa = BoxButton.getButton("btnManageKhoa", "Khoa", "Quản lý khoa, ngành", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageKhoa);
            btnManageKhoa.MouseClick += selectManageKhoa;

            xStart += btnManageKhoa.Width + far;
            Button btnManageSubject = BoxButton.getButton("btnManageSubject", "Subject", "Quản lý môn học", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageSubject);
            btnManageSubject.MouseClick += selectManageSubject;

            xStart = 50;
            yStart += btnManageAcct.Height + far;
            Button btnAssignmentTeacher = BoxButton.getButton("btnAssignmentTeacher", "Assignment Teacher", "Phân công giảng viên", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnAssignmentTeacher);
            btnAssignmentTeacher.MouseClick += selectAssignmentTeacher;

            xStart += btnAssignmentTeacher.Width + far;
            Button btnManageClassroom = BoxButton.getButton("btnManageClassroom", "Classroom", "Quản lý phòng học", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageClassroom);
            btnManageClassroom.MouseClick += selectManageClassroom;


            xStart += btnManageClassroom.Width + far;
            Button btnAssignmentStudent = BoxButton.getButton("btnAssignmentStudent", "Student", "Sắp xếp lớp SV", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnAssignmentStudent);
            btnAssignmentStudent.MouseClick += selectAssignmentStudent;

            xStart = 50;
            yStart += btnAssignmentTeacher.Height + far;
            Button btnManageSurvey = BoxButton.getButton("btnManageSurvey", "Survey", "Quản lý khảo sát", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageSurvey);
            btnManageSurvey.MouseClick += selectManageSurvey;
        }

        void frmTeacher()
        {
            BackColor = Color.CadetBlue;
            Text = "Quản lý giảng dạy - Giảng viên - " + info.getID();
            createInfo(nameAct);
            int xStart = 50, yStart = 20;
            int far = 20;

            Button btnWatchCalendar = BoxButton.getButton("btnWatchCalendar", "Calendar", "Xem lịch dạy", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnWatchCalendar);
            btnWatchCalendar.MouseClick += selectWatchCalendar;

            xStart += btnWatchCalendar.Width + far;
            Button btnMangeStudent = BoxButton.getButton("btnMangeStudent", "Student", "Quản lý, chấm điểm SV", 230, 70, xStart, yStart);
            pnOption.Controls.Add(btnMangeStudent);
            btnMangeStudent.MouseClick += selectManageStudent;

            xStart += btnMangeStudent.Width + far;
            Button btnManageKhoa = BoxButton.getButton("btnWatchSubject", "Subject", "Xem danh sách môn", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnManageKhoa);
            btnManageKhoa.MouseClick += selectWatchSubject;

            xStart = 50;
            yStart += btnManageKhoa.Height + far;
            Button btnWatchSurvey = BoxButton.getButton("btnWatchSurvey", "Survey", "Xem các khảo sát", 220, 70, xStart, yStart);
            pnOption.Controls.Add(btnWatchSurvey);
            btnWatchSurvey.MouseClick += selectWatchSurvey;
        }
        void frmStudent()
        {
            BackColor = Color.CadetBlue;
            Text = "Quản lý học tập - Sinh viên - " + info.getID();
            createInfo(nameAct);
            int xStart = 50, yStart = 20;
            int far = 20; 
            Button btnEncrollSubject = BoxButton.getButton("btnEncrollSubject", "Enroll Subject", "Đăng ký môn học", 200, 70, xStart, yStart);
            pnOption.Controls.Add(btnEncrollSubject);
            btnEncrollSubject.MouseClick += selectEnrollSubject;

            xStart += btnEncrollSubject.Width + far;
            Button btnWatchCalendar = BoxButton.getButton("btnWatchCalendar", "Calendar", "Xem TKB", 200, 70, xStart, yStart);
            pnOption.Controls.Add(btnWatchCalendar);
            btnWatchCalendar.MouseClick += selectWatchCalendar;

            xStart += btnWatchCalendar.Width + far;
            Button btnWatchSubject = BoxButton.getButton("btnWatchSubject", "Subject", "Xem môn học", 200, 70, xStart, yStart);
            pnOption.Controls.Add(btnWatchSubject);
            btnWatchSubject.MouseClick += selectWatchSubject;

            xStart = 50;
            yStart += btnWatchSubject.Height + far;
            Button btnWatchSurvey = BoxButton.getButton("btnSurvey", "Survey", "Khảo sát GV", 200, 70, xStart, yStart);
            pnOption.Controls.Add(btnWatchSurvey);
            btnWatchSurvey.MouseClick += selectSurvey;
        }
    }
}
