using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class InfoAssignSubject
    {
        private int maLop;
        private string maSV;
        private int hocki;
        private int year;
        public InfoAssignSubject(string maSV, int maLop, int hocki, int year)
        {
            this.maSV = maSV;
            this.maLop = maLop;
            this.hocki = hocki;
            this.year = year;
        }

        public static bool isExistsAssignSubject(string maSV, int maLop, int hocKi, int year)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from DangKyMon where MaSV = @MaSV and MaLop = @MaLop and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "MaLop", "HocKi", "Nam" }, new List<object>() { maSV, maLop, hocKi, year }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool isSameDateAssignSubject(string maSV, int maLop)
        {
            List<InfoAssignRoom> infoAssignRooms = InfoAssignRoom.getInfo(maLop);
            List<InfoAssignSubject> infoAssignSubjects = getInfoAssignSubject(maSV);
            for (int i =0; i < infoAssignSubjects.Count; i++)
            {
                List<InfoAssignRoom> assignRooms = InfoAssignRoom.getInfo(infoAssignSubjects[i].getMaLop());
                foreach (InfoAssignRoom infoAssignRoomA in assignRooms)
                {
                    foreach (InfoAssignRoom infoAssignRoomB in infoAssignRooms)
                    {
                        if (General.isDateAInB(infoAssignRoomA.getDateStart(), infoAssignRoomA.getDateEnd(), infoAssignRoomA.getTietStart(), infoAssignRoomA.getTietEnd(), infoAssignRoomA.getStrDayOfWeek(), infoAssignRoomB.getDateStart(), infoAssignRoomB.getDateEnd(), infoAssignRoomB.getTietStart(), infoAssignRoomB.getTietEnd(), infoAssignRoomB.getStrDayOfWeek()))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        public bool addAssignSubject()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into DangKyMon(MaSV, MaLop, HocKi, Nam) values (@MaSV, @MaLop, @HocKi, @Nam)", new List<string>() { "MaSV", "MaLop", "@HocKi", "@Nam" }, new List<object>() { maSV, maLop, hocki, year });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteAssignSubject()
        {
            try
            {
                SQL.Excute_Non_Value("Delete DangKyMon where MaSV = @MaSV and MaLop = @Malop and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "Malop", "HocKi", "Nam" }, new List<object>() { maSV, maLop, hocki, year });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static InfoAssignSubject getInfo(string maSV, int maLop, int hocKi,int year)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyMon where MaSV = @MaSV and MaLop = @MaLop and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "MaLop", "HocKi", "Nam" }, new List<object>() { maSV, maLop, hocKi, year });
                return new InfoAssignSubject(maSV, maLop, (int)dt.Rows[0][2], (int)dt.Rows[0][3]);
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignSubject> getAssign(string maSV, int maLop)
        {
            List<InfoAssignSubject> lst = new List<InfoAssignSubject>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyMon where MaSV = @MaSV and MaLop = @MaLop", new List<string>() { "MaSV", "MaLop" }, new List<object>() { maSV, maLop });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignSubject(maSV, (int)dt.Rows[0][1], (int)dt.Rows[0][2], (int)dt.Rows[0][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignSubject> getAssignSameSubject(string maSV, string nameSubject)
        {
            List<InfoAssignSubject> lst = new List<InfoAssignSubject>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyMon where MaSV = @MaSV and Exists(Select * from PhanCongGiangDay where PhanCongGiangDay.MaLop = DangKyMon.MaLop and TenMH = @TenMH)", new List<string>() { "MaSV", "TenMH" }, new List<object>() { maSV, nameSubject});
                for (int i = 0;  i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignSubject(maSV, (int)dt.Rows[0][1], (int)dt.Rows[0][2], (int)dt.Rows[0][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignSubject> getInfoAssignSubject(string maSV)
        {
            List<InfoAssignSubject> lst = new List<InfoAssignSubject>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyMon where MaSV = @MaSV", new List<string>() { "MaSV" }, new List<object>() { maSV });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignSubject(maSV, (int)dt.Rows[0][1], (int)dt.Rows[0][2], (int)dt.Rows[0][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public static List<Student> getStudentsAssignSubject(int maLop)
        {
            List<Student> students = new List<Student>();
            List<InfoAssignSubject> assignSubjects = getAllAssignSubject();

            for (int i = 0; i < assignSubjects.Count; i++)
            {
                if (assignSubjects[i].getMaLop() == maLop)
                {
                    students.Add((Student)Person.getInfo("ID", assignSubjects[i].getMaSV()));
                }
            }
            return students;
        }
        public static List<Survey> getSurveysAssignSubject(int maLop)
        {
            List<Survey> surveys = new List<Survey>();
            List<InfoAssignSubject> assignSubjects = getAllAssignSubject();

            for (int i = 0; i < assignSubjects.Count; i++)
            {
                if (assignSubjects[i].getMaLop() == maLop)
                {
                    Student student = (Student)Person.getInfo("ID", assignSubjects[i].getMaSV());
                    Survey survey = Survey.getSurvey(student.getID(), assignSubjects[i].getMaLop(), student.getHocKi(), student.getYear());
                    if (survey != null)
                    {
                        surveys.Add(survey);
                    }
                }
            }
            return surveys;
        }

        public static List<InfoAssignSubject> getAllAssignSubject()
        {
            List<InfoAssignSubject> lst = new List<InfoAssignSubject>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from DangKyMon", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignSubject((string)dt.Rows[i][0], (int)dt.Rows[i][1], (int)dt.Rows[0][2], (int)dt.Rows[0][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public string getMaSV()
        {
            return maSV;
        }
        public int getMaLop()
        {
            return maLop;
        }
        public int getHocKi()
        {
            return hocki;
        }
        public int getYear()
        {
            return year;
        }
    }
}
