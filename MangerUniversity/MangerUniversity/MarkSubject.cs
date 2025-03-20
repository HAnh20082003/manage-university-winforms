using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class MarkSubject
    {
        private string maSV;
        private int maLop;
        private double KTDK;
        private double KTHP;
        private int percentKTDK;
        private int hocKi;
        private int year;
        public MarkSubject(string maSV, int maLop, double KTDK, double KTHP, int percentKTDK, int hocKi, int year)
        {
            this.maSV = maSV;
            this.maLop = maLop;
            this.KTDK = KTDK;
            this.KTHP = KTHP;
            this.percentKTDK = percentKTDK;
            this.hocKi = hocKi;
            this.year = year;
        }

        public bool insertMark()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into GhiDiem values (@masv, @malop, @ktdk, @kthp, @tileKTDK, @hocki, @year)", new List<string>() { "masv", "malop", "ktdk", "kthp", "tileKTDK", "hocki", "year" }, new List<object>() { maSV, maLop, KTDK, KTHP, percentKTDK, hocKi, year });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateMarkSubject(double KTDK, double KTHP, int percentKTDK)
        {
            try
            {
                SQL.Excute_Non_Value("Update GhiDiem Set KTDK = @NewKTDK, KTHP = @NewKTHP, TiLeKTDK = @NewPercentKTDK where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam", new List<string>() { "NewKTDK", "NewKTHP", "NewPercentKTDK", "MaLop", "MaSV", "HocKi", "Nam" }, new List<object>() { KTDK, KTHP, percentKTDK, maLop, maSV, hocKi, year });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteMarkSubject(string maSV, int maLop, int hocKi, int year)
        {
            try
            {
                SQL.Excute_Non_Value("Delete GhiDiem where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaLop", "MaSV", "HocKi", "Nam" }, new List<object>() { maLop, maSV, hocKi, year });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isExistsMarkSubject(string maSV, int maLop, int hocKi, int year)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from GhiDiem where MaSV = @MaSV and MaLop = @MaLop and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "MaLop", "HocKi","Nam" }, new List<object>() { maSV, maLop, hocKi, year }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool isFail(string maSV, int maLop, int hocKi, int year)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from GhiDiem where MaSV = @MaSV and MaLop = @MaLop and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "MaLop", "HocKi", "Nam" }, new List<object>() { maSV, maLop, hocKi, year });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MarkSubject mark = new MarkSubject((string)dt.Rows[i][0], (int)dt.Rows[i][1], (double)dt.Rows[i][2], (double)dt.Rows[i][3], (int)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);
                    double DTB = mark.caculateDTB();
                    if (DTB >= 5)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public static int getPercentKTDK(int maLop, string maSV, int hocki, int year)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select TiLeKTDK from GhiDiem where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaLop", "MaSV", "HocKi", "Nam" }, new List<object>() { maLop, maSV, hocki, year });
            }
            catch
            {
                return -1;
            }
        }

        public static MarkSubject getInfo(int maLop, string maSV, int hocKi, int year)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from GhiDiem where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaLop", "MaSV", "HocKi", "Nam" }, new List<object>() { maLop, maSV, hocKi, year });
                return new MarkSubject(maSV, maLop, (double)dt.Rows[0][2], (double)dt.Rows[0][3], (int)dt.Rows[0][4], (int)dt.Rows[0][5], (int)dt.Rows[0][6]);
            }
            catch
            {
                return null;
            }
        }

        public static object getField(string field, string fieldSource, object value)
        {
            try
            {
                return SQL.Excute_A_Value("Select " + field + " from GhiDiem where " + fieldSource + " = @Value", new List<string>() { "Value" }, new List<object>() { value });
            }
            catch
            {
                return null;
            }
        }

        public static List<MarkSubject> getAllPoint()
        {
            List<MarkSubject> lst = new List<MarkSubject>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from GhiDiem", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new MarkSubject((string)dt.Rows[i][0], (int)dt.Rows[i][1], (double)dt.Rows[i][2], (double)dt.Rows[i][3], (int)dt.Rows[0][4], (int)dt.Rows[0][5], (int)dt.Rows[0][6]));
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
        public double getKTDK()
        {
            return KTDK;
        }
        public double getKTHP()
        {
            return KTHP;
        }
        public int getPercentKTDK()
        {
            return percentKTDK;
        }
        public int getHocKi()
        {
            return hocKi;
        }

        public int getYear()
        {
            return year;
        }
        public double caculateDTB()
        {
            return KTDK * percentKTDK/100 + KTHP * (100 - percentKTDK)/100;
        }
    }
}
