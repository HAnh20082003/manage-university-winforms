using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Subject
    {
        private string name;
        private bool must;
        private int soTC;
        private int soTiet;
        private double money;
        private int hocki;
        private int year;
        public Subject(string name, bool must, int soTC, int soTiet, double money, int hocki, int year)
        {
            this.name = name;
            this.must = must;
            this.soTC = soTC;
            this.soTiet = soTiet;
            this.money = money;
            this.hocki = hocki;
            this.year = year;
        }

        public string getName()
        {
            return name;
        }

        public static List<Subject> getSubjectInMajor(string nameMajor)
        {
            List<Subject> subs = getAllSubject();
            for (int i = 0; i < subs.Count; i++)
            {
                bool isOk = false;
                List<Major> majors = subs[i].getMajor();
                for (int j = 0; j < majors.Count; j++)
                {
                    if (nameMajor == majors[j].getName())
                    {
                        isOk = true;
                        break;
                    }
                }
                if (!isOk)
                {
                    subs.RemoveAt(i);
                    i--;
                }
            }
            return subs;
        }
        public List<Teacher> getTeacherTeach()
        {
            List<Teacher> teachers = new List<Teacher>();
            List<InfoAssignTeacher> infoAssign = InfoAssignTeacher.getAllAssign();
            for (int i =0; i < infoAssign.Count; i++)
            {
                if (infoAssign[i].getNameSubject() != name)
                {
                    continue;
                }
                teachers.Add((Teacher)Person.getInfo("ID", infoAssign[i].getMaGV()));
            }
            return teachers;
        }
        public List<Major> getMajor()
        {
            List<Major> lst = Major.getAllMajor();
            try
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    string nameMajor = lst[i].getName();
                    if ((int)SQL.Excute_A_Value("Select count(*) from MonHocThuocNganh where TenMH = @TenMH and TenNganh = @TenNganh", new List<string>() { "TenMH", "TenNganh" }, new List<object>() { name, nameMajor }) == 0)
                    {
                        lst.RemoveAt(i);
                        i--;
                    }
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public static List<InfoAssignTeacher> getAssignTeachers (string nameSubject)
        {
            List<InfoAssignTeacher> infoAssignTeachers = InfoAssignTeacher.getAllAssign();
            for (int i  = 0;i < infoAssignTeachers.Count; i++)
            {
                if (infoAssignTeachers[i].getNameSubject() != nameSubject)
                {
                    infoAssignTeachers.RemoveAt(i);
                    i--;
                }
            }
            return infoAssignTeachers;
        }
        public bool getMust()
        {
            return must;
        }
        public int getSoTC()
        {
            return soTC;
        }
        public int getSoTiet()
        {
            return soTiet;
        }
        public double getMoney()
        {
            return money;
        }
        public int getHocKi()
        {
            return hocki;
        }
        public int getYear()
        {
            return year;
        }

        public static Subject getInfo (string field, object value)
        {
            DataTable dt = SQL.Excute_Values("Select * from MonHoc where " + field + " = @value", new List<string>() { "value" }, new List<object>() { value });
            int i = 0;
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Subject subject = new Subject((string)dt.Rows[i][0], (bool)dt.Rows[i][1], (int)dt.Rows[i][2], (int)dt.Rows[i][3], (double)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);
            return subject;
        }
        public static List<Subject> getAllSubject()
        {
            DataTable dt = SQL.Excute_Values("Select * from MonHoc", null, null);
            List<Subject> lst = new List<Subject>();
            for (int i = 0; i < dt.Rows.Count;i++)
            {
                lst.Add(new Subject((string)dt.Rows[i][0], (bool)dt.Rows[i][1], (int)dt.Rows[i][2], (int)dt.Rows[i][3], (double)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]));
            }
            return lst;
        }

        public static object getField(string field, string fieldSource, object value)
        {
            try
            {
                return SQL.Excute_A_Value("Select " + field + " from MonHoc where " + fieldSource + " = @value", new List<string>() { "value" }, new List<object>() { value });
            }
            catch
            {
                return null;
            }
        }

        public bool addSubject(List<Major> lstMajors = null)
        {
            try
            {
                if ((int)SQL.Excute_A_Value("Select count(*) from MonHoc where Ten = @TenMH", new List<string>() { "TenMH" }, new List<object> { name }) == 0)
                {
                    SQL.Excute_Non_Value("Insert into MonHoc values (@Ten, @BatBuoc, @SoTC, @SoTiet, @Phi, @HocKi, @Year)", new List<string>() { "Ten", "BatBuoc", "SoTC", "SoTiet", "Phi", "HocKi", "Year" }, new List<object>() { name, must, soTC, soTiet, money, hocki, year });
                }
                for (int i = 0; i < lstMajors.Count; i++)
                {
                    SQL.Excute_Non_Value("Insert into MonHocThuocNganh values (@TenMH, @TenNganh)", new List<string>() { "TenMH", "TenNganh" }, new List<object>() { name, lstMajors[i].getName() });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateSubject(Subject sub, List<string> lstMajors)
        {
            try
            {
                SQL.Excute_Non_Value("Update MonHoc Set BatBuoc = @BatBuoc, SoTC = @SoTC, SoTiet = @SoTiet, Phi = @Phi, HocKi = @HocKi, Nam = @Nam where Ten = @Ten", new List<string>() { "BatBuoc", "SoTC", "SoTiet", "Phi", "HocKi", "Nam", "Ten" }, new List<object>() { sub.getMust(), sub.getSoTC(), sub.getSoTiet(), sub.getMoney(), sub.getHocKi(), sub.getYear(), name });
                SQL.Excute_Non_Value("Delete MonHocThuocNganh where TenMH = @TenMH", new List<string>() { "TenMH" }, new List<object>() { name });
                for (int i = 0; i < lstMajors.Count; i ++)
                {
                    SQL.Excute_Non_Value("Insert into MonHocThuocNganh values (@TenMH, @TenNganh)", new List<string>() { "TenMH", "TenNganh" }, new List<object>() { name, lstMajors[i] });
                }
                SQL.Excute_Non_Value("Update MonHoc Set Ten = @NewName where Ten = @OldName", new List<string>() { "NewName", "OldName" }, new List<object>() { sub.getName(), name });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateSubject(Subject sub, List<Major> lstMajors)
        {
            try
            {
                SQL.Excute_Non_Value("Update MonHoc Set BatBuoc = @BatBuoc, SoTC = @SoTC, SoTiet = @SoTiet, Phi = @Phi, HocKi = @HocKi, Nam = @Nam where Ten = @Ten", new List<string>() { "BatBuoc", "SoTC", "SoTiet", "Phi", "HocKi", "Nam", "Ten" }, new List<object>() { sub.getMust(), sub.getSoTC(), sub.getSoTiet(), sub.getMoney(), sub.getHocKi(), sub.getYear(), name });
                SQL.Excute_Non_Value("Delete MonHocThuocNganh where TenMH = @TenMH", new List<string>() { "TenMH" }, new List<object>() { name });
                for (int i = 0; i < lstMajors.Count; i++)
                {
                    SQL.Excute_Non_Value("Insert into MonHocThuocNganh values (@TenMH, @TenNganh)", new List<string>() { "TenMH", "TenNganh" }, new List<object>() { name, lstMajors[i].getName() });
                }
                SQL.Excute_Non_Value("Update MonHoc Set Ten = @NewName where Ten = @OldName", new List<string>() { "NewName", "OldName" }, new List<object>() { sub.getName(), name });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteSubject()
        {
            try
            {
                SQL.Excute_Non_Value("Delete MonHoc where Ten = @Ten", new List<string>() { "Ten" }, new List<object>() { name});
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Subject getCoppy()
        {
            return new Subject(name, must, soTC, soTiet, money, hocki, year);
        }
    }
}
