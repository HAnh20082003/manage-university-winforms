    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class InfoAssignRoom
    {
        private int maLop;
        private string nameRoom;
        private Date dateStart, dateEnd;
        private int tietStart;
        private int tietEnd;
        private string dayOfWeek;
        public InfoAssignRoom(string nameRoom, int maLop, Date dateStart, Date dateEnd, int tietStart, int tietEnd, string dayOfWeek)
        {
            this.maLop = maLop;
            this.nameRoom = nameRoom;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.tietStart = tietStart;
            this.tietEnd = tietEnd;
            this.dayOfWeek = dayOfWeek;
        }

        public string getCalender()
        {
            return dayOfWeek + ", Tiết bắt đầu từ " + tietStart + " - tiết " + tietEnd + ", " + dateStart.getDateNotDayOfWeek('/') + " - " + dateEnd.getDateNotDayOfWeek('/');
        }
        
        public static bool isExistsAssignRoom(int maLop)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count (*) from DangKyPhong where MaLop = @MaLop", new List<string>() { "MaLop" }, new List<object>() { maLop }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static List<InfoAssignRoom> getAllInfoAssign()
        {
            List<InfoAssignRoom> lst = new List<InfoAssignRoom>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyPhong", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignRoom((string)dt.Rows[i][0],(int)dt.Rows[i][1], new Date((DateTime)dt.Rows[i][2]), new Date((DateTime)dt.Rows[i][3]),(int)dt.Rows[i][4], (int)dt.Rows[i][5], (string)dt.Rows[i][6]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public static InfoAssignRoom getInfo(string nameRoom, Date dateStart, Date dateEnd, int tietStart, int tietEnd, string dayOfWeek)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyPhong where TenPH = @TenPH and NgayBatDau = @NgayBatDau and NgayKetThuc = @NgayKetThuc and TietDau = @TietDau and @TietCuoi = @TietCuoi and Thu = @Thu", new List<string>() { "TenPH", "NgayBatDau","NgayKetThuc", "TietDau", "TietCuoi", "Thu" }, new List<object>() { nameRoom, dateStart.getDate(), dateEnd.getDate(), tietStart,tietEnd, dayOfWeek });
                if (dt.Rows.Count != 0)
                {
                    return new InfoAssignRoom(nameRoom, (int)dt.Rows[0][1], dateStart,dateEnd, tietStart, tietStart, dayOfWeek);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignRoom> getInfo(string nameRoom)
        {
            List<InfoAssignRoom> lst = new List<InfoAssignRoom>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyPhong where TenPH = @TenPH", new List<string>() { "TenPH" }, new List<object>() { nameRoom});
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignRoom(nameRoom, (int)dt.Rows[0][1], new Date((DateTime)dt.Rows[0][2]), new Date((DateTime)dt.Rows[0][3]), (int)dt.Rows[0][4], (int)dt.Rows[0][5], (string)dt.Rows[0][6]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignRoom> getInfo(int maLop)
        {
            List<InfoAssignRoom> lst = new List<InfoAssignRoom>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyPhong where MaLop = @MaLop", new List<string>() { "MaLop" }, new List<object>() { maLop });

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignRoom((string)dt.Rows[i][0], maLop, new Date((DateTime)dt.Rows[i][2]), new Date((DateTime)dt.Rows[i][3]), (int)dt.Rows[i][4], (int)dt.Rows[i][5], (string)dt.Rows[i][6]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public int getMaLop()
        {
            return maLop;
        }
        public string getNameRoom()
        {
            return nameRoom;
        }
        public Date getDateStart()
        {
            return dateStart;
        }
        public Date getDateEnd()
        {
            return dateEnd;
        }
        public int getTietStart()
        {
            return tietStart;
        }
        public int getTietEnd()
        {
            return tietEnd;
        }

        public string getStrDayOfWeek()
        {
            return dayOfWeek;
        }
        public DayOfWeek getDayOfWeek()
        {
            if (dayOfWeek == "Thứ 2")
            {
                return DayOfWeek.Monday;
            }
            if (dayOfWeek == "Thứ 3")
            {
                return DayOfWeek.Tuesday;
            }
            if (dayOfWeek == "Thứ 4")
            {
                return DayOfWeek.Wednesday;
            }
            if (dayOfWeek == "Thứ 5")
            {
                return DayOfWeek.Thursday;
            }
            if (dayOfWeek == "Thứ 6")
            {
                return DayOfWeek.Friday;
            }
            if (dayOfWeek == "Thứ 7")
            {
                return DayOfWeek.Saturday;
            }
            return DayOfWeek.Sunday;
        }

        public bool addAssignRoom()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into DangKyPhong (TenPH, MaLop, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu) values (@TenPH, @MaLop, @NgayBatDau, @NgayKetThuc, @TietDau, @TietCuoi, @Thu)", new List<string>() { "TenPH", "MaLop", "NgayBatDau","NgayKetThuc", "TietDau", "TietCuoi", "Thu" }, new List<object>() { nameRoom, maLop, dateStart.getDate(), dateEnd.getDate(), tietStart, tietEnd, dayOfWeek});
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateAssignRoom(InfoAssignRoom infoAssign)
        {
            try
            {
                SQL.Excute_Non_Value("Update DangKyPhong Set NgayBatDau = @NgayBatDauMoi, NgayKetThuc = @NgayKetThucMoi, TietDau = @TietDauMoi, TietCuoi = @TietCuoiMoi, MaLop = @MaLopMoi, Thu = @ThuMoi where TenPH = @TenPH and NgayBatDau = @NgayBatDauCu and NgayKetThuc = @NgayKetThucCu and TietDau = @TietDauCu and TietCuoi = @TietCuoiCu and MaLop = @MaLopCu and Thu = @ThuCu", new List<string>() { "NgayBatDauMoi", "NgayKetThucMoi", "TietDauMoi", "TietCuoiMoi", "MaLopMoi", "ThuMoi", "TenPH", "NgayBatDauCu","NgayKetThucCu", "TietDauCu", "TietCuoiCu", "MaLopCu", "ThuCu" }, new List<object>() {infoAssign.getDateStart().getDate(), infoAssign.getDateEnd().getDate(), infoAssign.getTietStart(), infoAssign.getTietEnd(), infoAssign.getMaLop(), infoAssign.getStrDayOfWeek(), nameRoom, dateStart.getDate(), dateEnd.getDate(), tietStart, tietEnd, maLop, dayOfWeek });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteAssignRoom()
        {
            try
            {
                SQL.Excute_Non_Value("Delete DangKyPhong where TenPH = @TenPH and NgayBatDau = @NgayBatDau and NgayKetThuc = @NgayKetThuc and TietDau = @TietDau and TietCuoi = @TietCuoi and Thu = @Thu", new List<string>() { "TenPH", "NgayBatDau","NgayKetThuc","TietDau","TietCuoi", "Thu" }, new List<object>() { nameRoom, dateStart.getDate(), dateEnd.getDate(), tietStart, tietEnd, dayOfWeek });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
