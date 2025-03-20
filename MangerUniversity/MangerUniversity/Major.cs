using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Major
    {
        private string name;
        private string tenKhoa;
        private int countYear;
        public Major(string name, string tenKhoa, int countYear)
        {
            this.name = name;
            this.tenKhoa = tenKhoa;
            this.countYear = countYear;
        }

        public List<Student> getStudents()
        {
            List<Student> students = Student.getAllStudents();
            for (int i = 0;i <students.Count; i++)
            {
                if (students[i].getNameMajor() != name)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }
            return students;
        }

        public static bool isExistsMajor(string nameMajor)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from Nganh where Ten = @NewName", new List<string>() { "NewName", }, new List<object>() { nameMajor }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool addMajor(string nameMajor, string nameKhoa, int countYear)
        {
            try
            {
                SQL.Excute_Non_Value("Insert into Nganh values (@Ten, @TenKhoa, @SoNam)", new List<string>() { "Ten", "TenKhoa", "SoNam" }, new List<object>() { nameMajor, nameKhoa, countYear });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateMajor(string nameMajor, int countYear, string tenKhoa)
        {
            try
            {
                SQL.Excute_Non_Value("Update Nganh Set Ten = @NewTenNganh, SoNam = @NewSoNam, TenKhoa = @NewTenKhoa where Ten = @OldTenNganh" , new List<string>() { "NewTenNganh", "NewSoNam", "NewTenKhoa", "OldTenNganh" }, new List<object>() { nameMajor, countYear, tenKhoa, name});
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteNganh(string nameMajor)
        {
            try
            {
                SQL.Excute_Non_Value("Delete Nganh where Ten = @TenNganh", new List<string>() { "TenNganh" }, new List<object>() { nameMajor });
                return true;
            }
            catch (Exception ex)
            {
                MessageInfo.makeMessage("Error", "", ex.Message);
                return false;
            }
        }
        public static Major getInfo(string nameMajor)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Nganh where Ten = @Ten", new List<string>() { "Ten" }, new List<object>() { nameMajor });
                return new Major((string)dt.Rows[0][0], (string)dt.Rows[0][1], (int)dt.Rows[0][2]);
            }
            catch
            {
                return null;
            }
        }

        public List<Subject> getMySubjects()
        {
            List<Subject> subs = Subject.getAllSubject();
            for (int i = 0; i < subs.Count; i++)
            {
                List<Major> majors = subs[i].getMajor();
                bool Have = false;
                for (int j = 0; j < majors.Count; j++)
                {
                    if (majors[j].getName() == name)
                    {
                        Have = true;
                        break;
                    }
                }
                if (!Have)
                {
                    subs.RemoveAt(i);
                    i--;
                }
            }
            return subs;
        }

        public List<Class> getMyClass()
        {
            List<Class> classs = Class.getAllClass();
            for (int i =0; i <classs.Count; i++)
            {
                if (classs[i].getNameMajor() != name)
                {
                    classs.RemoveAt(i);
                    i--;
                } 
            }
            return classs;
        }
        public static List<Major> getAllMajor()
        {
            DataTable dt = SQL.Excute_Values("Select * from Nganh", null, null);
            List<Major> lst = new List<Major>();
            for (int i =0; i< dt.Rows.Count; i++)
            {
                object tmpTenKhoa = dt.Rows[i][1];
                string tenKhoa = tmpTenKhoa == DBNull.Value ? null : (string)tmpTenKhoa;
                lst.Add(new Major((string)dt.Rows[i][0], tenKhoa, (int)dt.Rows[i][2]));
            }
            return lst;
        }

        public bool SubjectInMajor(string nameSubject)
        {
            try
            {
                return (int) SQL.Excute_A_Value("Select Count(*) from MonHocThuocNganh where TenMH = @TenMH and TenNganh = @TenNganh", new List<string>() { "TenMH", "TenNganh" }, new List<object>() { nameSubject, name }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static object getField(string field, string fieldSource, object value)
        {
            try
            {
                return SQL.Excute_A_Value("Select " + field + " from Nganh where " + fieldSource + " = @value", new List<string>() { "value" }, new List<object>() { value });
            }
            catch
            {
                return null;
            }
        }

        public int getTongTC()
        {
            int count = 0;
            List<Subject> subjects = Subject.getAllSubject();
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].getMust())
                {
                    List<Major> majors = subjects[i].getMajor();
                    for (int j = 0; j < majors.Count; j++)
                    {
                        if (majors[j].getName() == name)
                        {
                            count += subjects[i].getSoTC();
                            break;
                        }
                    }
                }
            }
            return count;
        }

        public string getName()
        {
            return name;
        }

        public string getTenKhoa()
        {
            return tenKhoa;
        }

        public int getCountYear()
        {
            return countYear;
        }
    }
}
