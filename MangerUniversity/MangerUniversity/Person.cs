using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Person
    {
        private FullName fullName;
        private string phone;
        private string email;
        private string ID;
        private Date birth;
        private string address;
        public Person(string ID, string phone, string fullName, string address, string email, Date birth)
        {
            this.fullName = new FullName(fullName);
            this.phone = phone;
            this.email = email;
            this.ID = ID;
            this.birth = birth;
            this.address = address;
        }

        public static Student changeToStudent(Person info, int hocki = 1, int year = 1, string nameMajor = null)
        {
            return new Student(info.getID(), info.getPhone(), info.getFullName().getFullName(), info.getAddress(), info.getEmail(), info.getBirth(), hocki, year, nameMajor);
        }
        public static Teacher changeToTeacher(Person info, string tenKhoa = null)
        {
            return new Teacher(info.getID(), info.getPhone(), info.getFullName().getFullName(), info.getAddress(), info.getEmail(), info.getBirth(), tenKhoa);
        }

        public static Person getInfo(string field, object value)
        {
            try
            {

                DataTable data = SQL.Excute_Values("Select * from Nguoi where " + field + " = @field", new List<string>() { "field" }, new List<object>() { value });

                string ID = (string)data.Rows[0][0];
                string phone = (string)data.Rows[0][1];
                string fullName = (string)data.Rows[0][2];
                object address = data.Rows[0][3];
                string email = (string)data.Rows[0][4];
                Date birth = new Date((DateTime)data.Rows[0][5]);
                if (Teacher.isExistTeacherID(ID))
                {
                    string tenKhoa = (string)Teacher.getFieldTeacherByID("TenKhoa", ID);
                    return new Teacher(ID, phone, fullName, address == DBNull.Value ? null : (string)address, email, birth, tenKhoa);
                }
                if (Student.isExistStudentID(ID))
                {
                    int hocKi = (int)Student.getFieldStudentByID("HocKi", ID);
                    string nameMajor = (string)Student.getFieldStudentByID("TenNganh", ID);
                    int year = (int)Student.getFieldStudentByID("Nam", ID);

                    return new Student(ID, phone, fullName, address == DBNull.Value ? null : (string)address, email, birth, hocKi, year, nameMajor);
                }
                return new Person(ID, phone, fullName, address == DBNull.Value ? null : (string)address, email, birth);
            }
            catch (Exception e)
            {
                MessageInfo.makeMessage("Error", "", e.Message);
                return null;
            }
        }
        public static List<Person> getAllPerson()
        {
            List<Person> person = new List<Person>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Nguoi", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    person.Add(new Person((string)dt.Rows[i][0], (string)dt.Rows[i][1], (string)dt.Rows[i][2], (string)dt.Rows[i][3], (string)dt.Rows[i][4], new Date((DateTime)dt.Rows[i][5])));
                }
                return person;
            }
            catch
            {
                return null;
            }
        }
        public static List<Person> getPeopleExceptAdmin()
        {
            List<Person> person = new List<Person>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Nguoi where EXISTS (SELECT * FROM GiangVien WHERE GiangVien.ID = Nguoi.ID) OR EXISTS (SELECT * FROM SinhVien WHERE SinhVien.ID = Nguoi.ID)", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    person.Add(new Person((string)dt.Rows[i][0], (string)dt.Rows[i][1], (string)dt.Rows[i][2], (string)dt.Rows[i][3], (string)dt.Rows[i][4], new Date((DateTime)dt.Rows[i][5])));
                }
                return person;
            }
            catch
            {
                return null;
            }
        }
        public static List<Person> getPersonSorted(string fieldSort, bool isInscrease = true)
        {
            List<Person> person = new List<Person>();
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
                DataTable dt = SQL.Excute_Values("Select * from Nguoi where EXISTS (SELECT * FROM GiangVien WHERE GiangVien.ID = Nguoi.ID) OR EXISTS (SELECT * FROM SinhVien WHERE SinhVien.ID = Nguoi.ID) order by " + fieldSort + strSortBy, null, null);
                for (int i = 0;i < dt.Rows.Count;i++)
                {
                    person.Add(new Person((string)dt.Rows[i][0], (string)dt.Rows[i][1], (string)dt.Rows[i][2], (string)dt.Rows[i][3], (string)dt.Rows[i][4], new Date((DateTime)dt.Rows[i][5])));
                }
                return person;
            }
            catch
            {
                return null;
            }
        }
        public static bool isPhoneValid(string phone)
        {
            if (phone.Length != 10)
            {
                return false;
            }
            if (phone[0] != '0')
            {
                return false;
            }
            return true;
        }
        public static bool isEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            if (!email.Contains("@gmail.com"))
            {
                return false;
            }
            int index_a_cong = email.IndexOf('@');
            string tail = email.Substring(index_a_cong);
            if (tail != "@gmail.com")
            {
                return false;
            }
            return true;
        }
        public FullName getFullName()
        {
            return fullName;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }
        public string getID()
        {
            return ID;
        }
        public Date getBirth()
        {
            return birth;
        }
        public string getAddress()
        {
            return address;
        }
        public void updateFullName(FullName fullName)
        {
            this.fullName = fullName;
        }
        public void updateFullName(string fullName)
        {
            this.fullName = new FullName(fullName);
        }
        public void updatePhone(string phone)
        {
            this.phone = phone;
        }
        public void updateEmail(string email)
        {
            this.email = email;
        }
        public void updateBirth(Date birth)
        {
            this.birth = birth;
        }
        public void updateBirth(DateTime birth)
        {
            this.birth = new Date(birth);
        }
        public void updateBirth(string birth)
        {
            this.birth = new Date(birth, '-');
        }
        public void updateBirth(int day, int month, int year)
        {
            string dayOfWeek = Date.getStrDayOfWeek(day, month,year);
            birth = new Date(dayOfWeek, day, month, year);
        }
        public void updateAddress(string address)
        {
            this.address = address;
        }
        public void updateID(string ID)
        {
            this.ID = ID;
        }

        public static object getFieldPerson(string field, string fieldSource, object value )
        {
            try
            {
                object result = SQL.Excute_A_Value("Select " + field + " from Nguoi where " + fieldSource + " = @value", new List<string>() { "value" }, new List<object>() { value });
                return result == DBNull.Value ? null : result;
            }
            catch
            {
                return null;
            }
        }

        public static bool isExistPersonID(string ID)
        {
            if (ID == null)
            {
                return false;
            }
            return (int)SQL.Excute_A_Value("Select count(*) from Nguoi where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID }) != 0;
        }
        public bool insertPerson()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into Nguoi (ID, SDT, Ten, DiaChi, Email, NgaySinh) values (@ID, @SDT, @Ten, @DiaChi, @Email, @NgaySinh)", new List<string>() { "ID", "SDT", "Ten", "DiaChi", "Email", "NgaySinh" }, new List<object>() { ID, phone, fullName.getFullName(), address, email, birth.getDate() });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatePerson(string newID = null)
        {
            try
            {
                SQL.Excute_Non_Value("Update Nguoi Set SDT = @SDT where ID = @ID", new List<string>() { "SDT", "ID" }, new List<object>() { getPhone(), getID() });
                SQL.Excute_Non_Value("Update Nguoi Set Ten = @Ten where ID = @ID", new List<string>() { "Ten", "ID" }, new List<object>() { getFullName().getFullName(), getID() });
                SQL.Excute_Non_Value("Update Nguoi Set DiaChi = @DiaChi where ID = @ID", new List<string>() { "DiaChi", "ID" }, new List<object>() { getAddress(), getID() });
                SQL.Excute_Non_Value("Update Nguoi Set Email = @Email where ID = @ID", new List<string>() { "Email", "ID" }, new List<object>() { getEmail(), getID() });
                SQL.Excute_Non_Value("Update Nguoi Set NgaySinh = @NgaySinh where ID = @ID", new List<string>() { "NgaySinh", "ID" }, new List<object>() { getBirth().getDate(), getID() });
                if (newID != null)
                {
                    SQL.Excute_Non_Value("Update Nguoi Set ID = @ID Where ID = @OldID", new List<string>() { "ID", "OldID" }, new List<object>() { newID, getID() });
                    ID = newID;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deletePerson(string ID)
        {
            try
            {
                SQL.Excute_Non_Value("Delete Nguoi where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
