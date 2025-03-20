using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Student : Person
    {
        private int hocKi;
        private int year;
        private string nameMajor;

        public Student(string ID, string phone, string fullName, string address, string email, Date birth) : base(ID, phone, fullName, address, email, birth)
        {

        }
        public Student(string ID, string phone, string fullName, string address, string email, Date birth, int hocKi, int year, string nameMajor) : base(ID, phone, fullName, address,  email, birth)
        {
            this.hocKi = hocKi;
            this.year = year;
            this.nameMajor = nameMajor;
        }
        public static List<Student> getStudentSorted(string fieldSort, bool isInscrease = true)
        {
            List<Student> students = new List<Student>();
            string strSortBy;
            if (!isInscrease)
            {
                strSortBy = " desc";
            }
            else
            {
                strSortBy = " asc";
            }
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from SinhVien order by " + fieldSort + strSortBy, null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Student student = (Student)getInfo("ID", (string)dt.Rows[i][0]);
                    students.Add(student);
                }
                return students;
            }
            catch
            {
                return null;
            }
        }
        public static object getFieldStudentByID(string field, string ID)
        {
            if (ID == null)
            {
                return null;
            }
            try
            {
                object value = SQL.Excute_A_Value("Select " + field + " from SinhVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return value == DBNull.Value ? null : value;
            }
            catch
            {
                return null;
            }
        }
        public static bool isExistStudentID(string ID)
        {
            if (ID == null)
            {
                return false;
            }
            return (int)SQL.Excute_A_Value("Select count(*) from SinhVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID }) != 0;
        }
        public bool insertStudent()
        {
            if (insertPerson())
            {
                try
                {
                    SQL.Excute_Non_Value("Insert into SinhVien values (@ID, @HocKi, @Nam, @TenNganh)", new List<string>() { "ID", "HocKi", "Nam", "TenNganh" }, new List<object>() { getID(), getHocKi(), getYear(), getNameMajor() });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public bool updateStudent(string newID = null)
        {
            string oldID = getID();
            if (updatePerson(newID))
            {
                try
                {
                    SQL.Excute_Non_Value("Update SinhVien Set HocKi = @HocKi, Nam = @Nam, TenNganh = @TenNganh where ID = @OldID", new List<string>() { "HocKi", "Nam", "TenNganh", "OldID" }, new List<object>() { getHocKi(), getYear(), getNameMajor(), oldID });
                    if (newID != null)
                    {
                        SQL.Excute_Non_Value("Update SinhVien Set ID = @NewID where ID = @OldID", new List<string>() { "NewID", "OldID" }, new List<object>() { newID, oldID });
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageInfo.makeMessage("Error", "", ex.ToString());
                    return false;
                }
            }
            return false;
        }
        public static bool deleteStudent(string ID)
        {
            try
            {
                SQL.Excute_Non_Value("Delete SinhVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getNameMajor()
        {
            return nameMajor;
        }
        public int getHocKi()
        {
            return hocKi;
        }
        public int getYear()
        {
            return year;
        }
        public int getTongSoTCDat()
        {
            return (int)SQL.Excute_A_Value("Select Count(*) from GhiDiem where MaSV = @ID and KTDK*TiLeKTDK/100 + KTHP*(100 - TiLeKTDK)/100 >= 5", new List<string>() { "ID" }, new List<object>() { getID() });
        }
        public int getSoTCDatByHocKi(int nam, int hocKi)
        {
            return (int)SQL.Excute_A_Value("Select Count(*) from GhiDiem, DangKyMon where GhiDiem.MaSV = @ID and GhiDiem.MaSV = DangKyMon.MaSV and HocKi = @HocKi and @Nam = @Nam and (KTDK + KTHP) / 2 >= 5 ", new List<string>() { "ID", "HocKi", "Nam" }, new List<object>() { getID(), hocKi, nam });
        }
        public int getSoTCDatByNam(int nam)
        {
            return (int)SQL.Excute_A_Value("Select Count(*) from GhiDiem, DangKyMon where GhiDiem.MaSV = @ID and GhiDiem.MaSV = DangKyMon.MaSV and @Nam = @Nam and (KTDK + KTHP) / 2 >= 5 ", new List<string>() { "ID", "Nam" }, new List<object>() { getID(), nam });
        }
        public void updateNameMajor(object nameMajor)
        {
            if (nameMajor == null)
            {
                this.nameMajor = null;
            }
            else
            {
                this.nameMajor = (string)nameMajor;
            }
        }
        public void updateYear(object year)
        {
            if (year == null)
            {
                this.year = 1;
            }
            else
            {
                this.year = (int)year;
            }
        }

        public string getStatus()
        {
            Major major = Major.getInfo(nameMajor);
            if (getTongSoTCDat() >= major.getTongTC())
            {
                return "Hoàn thành";
            }
            return "Chưa hoàn thành";
        }

        public static bool checkHadClass(Student student)
        {
            List<Class> classs = Class.getAllClass();
            for (int i =0; i < classs.Count; i++)
            {
                List<Student> students = classs[i].getStudents();
                for (int j = 0; j < students.Count; j++)
                {
                    if (student.getID() == students[j].getID())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static List<Student> getAllStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from SinhVien", null, null);
                for (int i = 0;i < dt.Rows.Count; i++)
                {
                    Student student = (Student) getInfo("ID", (string)dt.Rows[i][0]);
                    students.Add(student);
                }
                return students;
            }
            catch
            {
                return null;
            }
        }
        public List<InfoAssignSubject> getInfoAssignSubject()
        {
            List<InfoAssignSubject> lstInfoAssigns = InfoAssignSubject.getAllAssignSubject();
            try
            {
                for (int i = 0; i < lstInfoAssigns.Count; i++)
                {
                    if (lstInfoAssigns[i].getMaSV() != getID())
                    {
                        lstInfoAssigns.RemoveAt(i);
                        i--;
                    }
                }
                return lstInfoAssigns;
            }
            catch
            {
                return null;
            }
        }
    }
}
