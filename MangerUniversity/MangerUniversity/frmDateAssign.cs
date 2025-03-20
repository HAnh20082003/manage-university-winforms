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
    public partial class frmDateAssign : Form
    {
        public frmDateAssign(int maLop)
        {
            InitializeComponent();
            lblMaLop.Text = "Mã lớp: " + maLop;
            InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(maLop);
            lblNameSubject.Text = "Tên môn học: " + infoAssignTeacher.getNameSubject();
            lblMaGV.Text = "Mã GV: " + infoAssignTeacher.getMaGV();
            List<InfoAssignRoom> infoAssignRooms = InfoAssignRoom.getInfo(maLop);
            for (int i =0; i < infoAssignRooms.Count;i ++)
            {
                Label lbl = new Label()
                {
                    Text = "Tên phòng: " + infoAssignRooms[i].getNameRoom() + ", " +infoAssignRooms[i].getCalender(),
                    AutoSize = false,
                    Size = new Size(fpnDate.Width - 10, 30),
                    BorderStyle = BorderStyle.FixedSingle,
                    ForeColor = Color.Navy,
                    BackColor = Color.Khaki,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Times New Roman", 12),
                };
                fpnDate.Controls.Add(lbl);
            }
        }
    }
}
