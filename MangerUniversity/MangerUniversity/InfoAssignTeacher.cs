using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class InfoAssignTeacher
    {
        private string maGV;
        private string nameSubject;
        private int maLop;
        private int maxCount;
        public InfoAssignTeacher(int maLop, string nameSubject, string maGV, int maxCount)
        {
            this.maLop = maLop;
            this.maGV = maGV;
            this.nameSubject = nameSubject;
            this.maxCount = maxCount;
        }
        public InfoAssignTeacher(string nameSubject, string maGV, int maxCount)
        {
            this.maGV = maGV;
            this.nameSubject = nameSubject;
            this.maxCount = maxCount;
        }

        public static InfoAssignTeacher getInfo(int maLop)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from PhanCongGiangDay where MaLop = @MaLop", new List<string>() { "MaLop" }, new List<object>() { maLop });
                return new InfoAssignTeacher((int)dt.Rows[0][0], (string)dt.Rows[0][1], (string)dt.Rows[0][2], (int)dt.Rows[0][3]);
            }
            catch
            {
                return null;
            }
        }
        public bool addAssign()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into PhanCongGiangDay(MaLop,TenMH,MaGV,SiSoToiDa) values (-1,@TenMH, @MaGV, @SiSoToiDa)", new List<string>() { "TenMH", "MaGV", "SiSoToiDa" }, new List<object>() { nameSubject, maGV, maxCount });
                maLop = (int)SQL.Excute_A_Value("Select count(*) from PhanCongGiangDay where TenMH = @TenMH and MaGV = @MaGV", new List<string>() { "TenMH", "MaGV" }, new List<object>() { nameSubject, maGV });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteAssign()
        {
            try
            {
                SQL.Excute_Non_Value("Delete PhanCongGiangDay where TenMH = @TenMH and MaGV = @MaGV and MaLop = @MaLop", new List<string>() { "TenMH", "MaGV", "MaLop" }, new List<object>() { nameSubject, maGV, maLop });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is InfoAssignTeacher)
            {
                InfoAssignTeacher info = (InfoAssignTeacher)obj;
                return info.getMaGV() == maGV && info.getNameSubject() == getNameSubject() && info.getMaLop() == getMaLop() && info.getMaxCount() == getMaxCount();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static List<InfoAssignTeacher> getInfoAssignByMajor(List<Major> majors)
        {
            List<InfoAssignTeacher> lst = getAllAssign();
            for (int i =0; i < lst.Count; i++)
            {
                bool isOk = false;
                for (int j = 0; j < majors.Count; j++)
                {
                    if (majors[j].SubjectInMajor(lst[i].getNameSubject()))
                    {
                        isOk = true;
                        break;
                    }
                }
                if (!isOk)
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            return lst;
        }

        public static List<InfoAssignTeacher> getAllAssign()
        {
            List<InfoAssignTeacher> lst = new List<InfoAssignTeacher>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from PhanCongGiangDay", null, null);
                for (int i= 0;i <dt.Rows.Count; i++)
                {
                    lst.Add(new InfoAssignTeacher((int)dt.Rows[i][0], (string)dt.Rows[i][1], (string)dt.Rows[i][2], (int)dt.Rows[i][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            List<InfoAssignSubject> lst = InfoAssignSubject.getAllAssignSubject();
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].getMaLop() == maLop)
                {
                    Student student = (Student)Person.getInfo("ID", lst[i].getMaSV());
                    if (student.getHocKi() == lst[i].getHocKi() && student.getYear() == lst[i].getYear())
                    {
                        students.Add(student);
                    }
                }
            }
            return students;
        }
        public List<Survey> getAllSurveys()
        {
            List<Survey> lst = Survey.getAllSurvey();
            for (int i =0; i < lst.Count; i++)
            {
                if (lst[i].getMaLop() != maLop)
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            return lst;
        }

        public int getMaxCount()
        {
            return maxCount;
        }
        public string getMaGV()
        {
            return maGV;
        }
        public string getNameSubject()
        {
            return nameSubject;
        }
        public int getMaLop()
        {
            return maLop;
        }
    }
}
