using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Khoa
    {
        private string name;
        public Khoa(string name)
        {
            this.name = name;
        }

        public List<Student> getStudents()
        {
            List<Student> students = Student.getAllStudents();
            for (int i = 0; i < students.Count; i++)
            {
                if (!studentInKhoa(students[i]))
                {
                    students.RemoveAt(i);
                    i--;
                }
            }
            return students;
        }
        public bool majorInKhoa(string nameMajor)
        {
            List<Major> majorOfKhoa = getMyMajor();
            for (int i = 0; i < majorOfKhoa.Count; i++)
            {
                if (majorOfKhoa[i].getName() == nameMajor)
                {
                    return true;
                }
            }
            return false;
        }

        public bool studentInKhoa(Student student)
        {
            List<Major> majorOfKhoa = getMyMajor();
            for (int i = 0; i  <majorOfKhoa.Count;i++)
            {
                if (majorOfKhoa[i].getName() == student.getNameMajor())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isExistKhoa(string nameKhoa)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from Khoa where Ten = @NewName", new List<string>() { "NewName", }, new List<object>() { nameKhoa }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool addKhoa(string nameKhoa)
        {
            try
            {
                SQL.Excute_Non_Value("Insert into Khoa values (@TenKhoa)", new List<string>() { "TenKhoa" }, new List<object>() { nameKhoa });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateKhoa(string nameKhoa)
        {
            try
            {
                SQL.Excute_Non_Value("Update Khoa Set Ten = @NewTenKhoa where Ten = @TenKhoa", new List<string>() { "NewTenKhoa", "TenKhoa" }, new List<object>() { nameKhoa, name });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteKhoa(string nameKhoa)
        {
            try
            {
                SQL.Excute_Non_Value("Delete Khoa where Ten = @TenKhoa", new List<string>() { "TenKhoa" }, new List<object>() { nameKhoa });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Khoa> getAllKhoa()
        {
            DataTable dt = SQL.Excute_Values("Select * from Khoa", null, null);
            List<Khoa> lst = new List<Khoa>();
            for (int i = 0; i < dt.Rows.Count; i ++)
            {
                lst.Add(new Khoa((string)dt.Rows[i][0]));
            }
            return lst;
        }

        public List<Teacher> getTeachers()
        {
            List<Teacher> lst = Teacher.getAllTeacher();
            for (int i =0; i<lst.Count; i++)
            {
                if (lst[i].getTenKhoa() != name)
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            return lst;
        }

        public List<Subject> getMySubjects()
        {
            List<Subject> subs = new List<Subject>();
            List<Major> majors = getMyMajor();
            for (int i =0; i <majors.Count; i++)
            {
                List<Subject> tmpSubs = majors[i].getMySubjects();
                for (int j =0; j < tmpSubs.Count; j ++)
                {
                    bool ok = true;
                    for (int k = 0; k < subs.Count;k++)
                    {
                        if (subs[k].getName() == tmpSubs[j].getName())
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        subs.Add(tmpSubs[j]);
                    }
                }
            }
            return subs;
        }

        public List<Major> getMyMajor()
        {
            List<Major> majors = Major.getAllMajor();
            for (int i = 0; i < majors.Count; i++)
            {
                if (majors[i].getTenKhoa() != name)
                {
                    majors.RemoveAt(i);
                    i--;
                }
            }
            return majors;
        }
        public string getName()
        {
            return name;
        }
    }
}
