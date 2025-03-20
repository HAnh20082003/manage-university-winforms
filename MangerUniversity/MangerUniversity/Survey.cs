using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Survey
    {
        private string maSV;
        private int maLop;
        private int year;
        private int hocKi;
        private int[] content;
        public Survey(string maSV, int maLop, int hocKi, int year, int[] content)
        {
            this.maSV = maSV;
            this.maLop = maLop;
            this.year = year;
            this.hocKi = hocKi;
            this.content = content;
        }

        public bool insertSurvey()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into KhaoSat (MaSV, MaLop, HocKi, Nam, NoiDung) values (@masv, @malop, @hocki, @nam, @content)", new List<string>() { "masv", "malop", "hocki", "nam", "content" }, new List<object>() { maSV, maLop, hocKi, year, ConvertToStrContent(content) });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateSurvey(int [] newContent)
        {
            try
            {
                SQL.Excute_Non_Value("Update KhaoSat Set NoiDung = @content where MaSV = @masv and MaLop = @malop and HocKi = @hocki and Nam = @Nam", new List<string>() { "content", "masv", "malop", "HocKi", "Nam" }, new List<object>() { ConvertToStrContent(newContent), maSV, maLop, hocKi, year });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteSurvey(string maSV, int maLop, int year, int hocKi)
        {
            try
            {
                SQL.Excute_Non_Value("Delete KhaoSat where MaSV = @MaSV and MaLop = @MaLop and Nam = @Nam and HocKi = @HocKi", new List<string>() { "MaSV", "MaLop", "Nam", "HocKi" }, new List<object>() { maSV, maLop, year, hocKi });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteAllSurvey()
        {
            try
            {
                SQL.Excute_Non_Value("Delete KhaoSat", null, null);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteAllSurvey(string maGV)
        {
            Teacher teacher = (Teacher)Person.getInfo("ID", maGV);
            List<InfoAssignTeacher> infoAssign = teacher.getInfoAssign();
            for (int i =0; i < infoAssign.Count; i++)
            {
                try
                {
                    SQL.Excute_Non_Value("Delete KhaoSat where MaLop = @MaLop", new List<string>() { "MaLop" }, new List<object>() { infoAssign[i].getMaLop() });
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public void updateContent(int [] newContent)
        {
            content = newContent;
        }

        public static Survey getSurvey(string maSV, int maLop, int hocKi, int year)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from KhaoSat where MaSV = @MaSV and MaLop = @MaLop and HocKi = @hocki and Nam = @nam", new List<string>() { "MaSV", "MaLop", "hocki","nam" }, new List<object>() { maSV, maLop, hocKi, year });
                string content = (string)dt.Rows[0][4];
                string[] tmp_content = content.Split(' ');
                int[] intContent = new int[tmp_content.Length];
                for (int i =0; i < tmp_content.Length; i++)
                {
                    intContent[i] = int.Parse(tmp_content[i]);
                }
                return new Survey(maSV, maLop, hocKi, year, intContent);
            }
            catch
            {
                return null;
            }
        }
        public static List<Survey> getAllSurvey()
        {
            List<Survey> lst = new List<Survey>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from KhaoSat", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string content = (string)dt.Rows[i][4];
                    string[] tmp_content = content.Split(' ');
                    int[] intContent = new int[tmp_content.Length];
                    for (int j = 0; j < tmp_content.Length; j++)
                    {
                        intContent[j] = int.Parse(tmp_content[j]);
                    }
                    lst.Add(new Survey((string)dt.Rows[i][0], (int)dt.Rows[i][1], (int)dt.Rows[i][2], (int)dt.Rows[i][3], intContent));
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
            return hocKi;
        }
        public int getYear()
        {
            return year;
        }

        public int[] getContent()
        {
            return content;
        }
        public static string ConvertToStrContent(int[] content)
        {
            string result = "";
            for (int i = 0; i < content.Length; i++)
            {
                result += content[i];
                if (i != content.Length - 1)
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}
