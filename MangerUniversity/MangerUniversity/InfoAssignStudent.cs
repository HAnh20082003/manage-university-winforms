using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class InfoAssignStudent
    {
        private string maSV;
        private string nameClass;
        public InfoAssignStudent(string maSV, string nameClass)
        {
            this.maSV = maSV;
            this.nameClass = nameClass;
        }
        public string getMaSV()
        {
            return maSV;
        }

        public string getNameClass()
        {
            return nameClass;
        }

        public static bool isExistsAssignStudent(string maSV)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from PhanBoSinhVien where MaSV = @masv", new List<string>() { "masv", "tenlop" }, new List<object>() { maSV }) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool addAssignStudent(string maSV, string nameClass)
        {
            try
            {
                SQL.Excute_Non_Value("Insert into PhanBoSinhVien (MaSV, TenLop) values (@MaSV, @TenLop)", new List<string>() { "MaSV", "TenLop" }, new List<object>() { maSV, nameClass });
                return true;
            }
            catch (Exception e)
            {
                MessageInfo.makeMessage("Error", "", e.Message);
                return false;
            }
        }

        public static bool kickStudent(string ID)
        {
            try 
            {
                SQL.Excute_Non_Value("Delete PhanBoSinhVien where MaSV = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Student> getStudents(string nameClass)
        {
            List<Student> lst = new List<Student>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from PhanBoSinhVien where TenLop = @TenLop", new List<string>() { "TenLop" }, new List<object>() { nameClass });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string maSV = (string)dt.Rows[i][0];
                    lst.Add((Student)Person.getInfo("ID", maSV));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
    }
}
