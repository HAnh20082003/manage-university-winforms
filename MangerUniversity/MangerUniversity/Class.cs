using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Class
    {
        private string name;
        private string maGV;
        private string nameMajor;
        private int maxCount;
        public Class(string name, string maGV, int maxCount, string nameMajor)
        {
            this.name = name;
            this.maGV = maGV;
            this.maxCount = maxCount;
            this.nameMajor = nameMajor;
        }
        
        public static bool addClass(string nameClass, string maGV, int maxCount, string nameMajor)
        {
            try
            {
                SQL.Excute_Non_Value("Insert into Lop values (@Ten, @MaGV, @MaxCount, @TenNganh)", new List<string>() { "Ten", "MaGV", "@MaxCount", "TenNganh" }, new List<object>() { nameClass, maGV, maxCount, nameMajor });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateClass(string nameClass, string maGV, int maxCount, string nameMajor)
        {
            try
            {
                SQL.Excute_Non_Value("Update Lop Set Ten = @NewTen, MaCoVan = @NewMaGV, SiSoToiDa = @NewMaxCount, TenNganh = @NewTenNganh where Ten = @OldTen", new List<string>() { "NewTen", "NewMaGV", "@NewMaxCount", "NewTenNganh", "OldTen" }, new List<object>() { nameClass, maGV, maxCount, nameMajor, name });
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public static bool deleteClass(string nameClass)
        {
            try
            {
                SQL.Excute_Non_Value("Delete Lop where Ten = @TenLop", new List<string>() { "TenLop" }, new List<object>() { nameClass });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isExistsClass(string nameClass)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from Lop where Ten = @NewName", new List<string>() { "NewName", }, new List<object>() { nameClass }) != 0;
            }
            catch
            {
                return false;
            }
        }
        public string getTenKhoa()
        {
            try
            {
                return (string)SQL.Excute_A_Value("Select Khoa.Ten from Khoa,Nganh  where Khoa.Ten = Nganh.TenKhoa and Nganh.Ten = @TenNganh", new List<string>() { "TenNganh" }, new List<object>() { nameMajor });
            }
            catch
            {
                return null;
            }
        }
        public static List<Class> getAllClass()
        {
            List<Class> lst = new List<Class>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Lop", null, null);
                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    lst.Add(new Class((string)dt.Rows[i][0], (string)dt.Rows[i][1], (int)dt.Rows[i][2], (string)dt.Rows[i][3]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public static Class getInfo(string nameClass)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Lop where Ten = @TenLop", new List<string>() { "TenLop" }, new List<object>() { nameClass });
                return new Class(nameClass, (string)dt.Rows[0][1], (int)dt.Rows[0][2], (string)dt.Rows[0][3]);
            }
            catch
            {
                return null;
            }
        }

        public bool updateClass(string newName, string newIDTeacher, int newMaxCount)
        {
            try
            {
                SQL.Excute_Non_Value("Update Lop Set Ten = @NewName, MaCoVan = @NewMaGV, SiSoToiDa = @NewSiSoToiDa where Ten = @OldName", new List<string>() { "NewName", "newMaGV", "NewSiSoToiDa", "OldName" }, new List<object>() { newName, newIDTeacher, newMaxCount, name });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Student> getStudents()
        {
            return InfoAssignStudent.getStudents(name);
        }

        public static Class getClassByField(string field, object value)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Lop where " + field + " = @Value", new List<string>() { "Value" }, new List<object>() { value });
                return new Class((string)dt.Rows[0][0], (string)dt.Rows[0][1], (int)dt.Rows[0][2], (string)dt.Rows[0][3]);
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
                return SQL.Excute_A_Value("Select " + field + " from Lop where " + fieldSource + " = @value", new List<string>() { "value" }, new List<object>() { value });
            }
            catch
            {
                return null;
            }
        }
        public string getName()
        {
            return name;
        }

        public string getMaGV()
        {
            return maGV;
        }

        public int getMaxCount()
        {
            return maxCount;
        }

        public string getNameMajor()
        {
            return nameMajor;
        }
    }
}
