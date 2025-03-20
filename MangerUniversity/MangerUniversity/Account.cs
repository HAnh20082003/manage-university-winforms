using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Account
    {
        public static string typeGV = "GV";
        public static string typeQT = "QT";
        public static string typeSV = "SV";
        public static int minLengthPassword = 8;

        private string name;
        private string password;
        private string ID;
        private Date date;
        private Image avatar;
        private string tailImg;
        public Account(string name)
        {
            this.name = name;
            DataTable dt = SQL.Excute_Values("select * from DangKyTaiKhoan where TenTK = @TenTK", new List<string>() { "TenTK" }, new List<object>() { name });
            try
            {
                ID = (string)dt.Rows[0][1];
                password = (string)dt.Rows[0][4];
                date = new Date((DateTime)dt.Rows[0][5]);
            }
            catch
            {

            }
            try
            {

                avatar = Avatar.ConvertBytesToImage((byte[])dt.Rows[0][2]);
                tailImg = (string)dt.Rows[0][3];
            }
            catch
            {

            }
        }

        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public Account getCoppy()
        {
            return new Account(name);
        }
        public static List<Account> getAllAccount()
        {
            List<Account> lst = new List<Account>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select TenTK from DangKyTaiKhoan", null, null);
                for (int i =0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Account((string)dt.Rows[i][0]));
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public static bool signUp(string nameAcct, string password, Person info)
        {
            if (isExistsName(nameAcct))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Tên tài khoản đã tồn tại!");
                return false;
            }
            if (Person.isExistPersonID(info.getID()))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Mã ID đã tồn tại!");
                return false;
            }
            if (info is Student)
            {
                Student student = (Student)info;
                if (!student.insertStudent())
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký thất bại!!!");
                    return false;
                }
            }
            else if (info is Teacher)
            {
                Teacher teacher = (Teacher)info;
                if (!teacher.insertTeacher())
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký thất bại!!!");
                    return false;
                }
            }
            else
            {
                if (!info.insertPerson())
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký thất bại!!!");
                    return false;
                }
            }
            try
            {
                SQL.Excute_Non_Value("Insert into DangKyTaiKhoan (TenTK, ID, MatKhau) values (@TenTK, @ID, @MatKhau)", new List<string>() { "TenTK", "ID", "MatKhau" }, new List<object>() { nameAcct, info.getID(), password });
                MessageInfo.makeMessage("Information", "Chúc mừng", "Đăng ký thành công!!!");
                return true;
            }
            catch (Exception e)
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Đăng ký thất bại!!!" + e.ToString());
                return false;
            }
        }


        public bool updateAccount(Person info, string newID = null)
        {
            if (!isPasswordValid(password))
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Mật khẩu không hợp lệ!!!");
                return false;
            }
            if (info is Student)
            {
                Student student = (Student)info;
                if (!student.updateStudent(newID))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Cập nhật thông tin sinh viên thất bại!!!");
                    return false;
                }
            }
            else if (info is Teacher)
            {
                Teacher teacher = (Teacher)info;
                if (!teacher.updateTeacher(newID))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Cập nhật thông tin giảng viên thất bại!!!");
                    return false;
                }
            }
            else
            {
                if (!info.updatePerson(newID))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Cập nhật thất bại!!!");
                    return false;
                }
            }
            try
            {
                SQL.Excute_Non_Value("Update DangKyTaiKhoan Set TenTK = @TenTK, MatKhau = @MK, ID = @ID_Moi where ID = @ID_Cu", new List<string>() { "TenTK", "MK", "ID_Moi", "ID_Cu" }, new List<object>() { getName(), getPassword(), newID, info.getID() });
                return true;
            }
            catch
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Tên tài khoản đã được dùng cho tài khoản khác!!!");
                return false;
            }
        }
        public static Account getInfoByID(string ID)
        {
            try
            {
                DataTable dt = SQL.Excute_Values("SELECT * FROM DangKyTaiKhoan WHERE ID = @Value", new List<string>() { "Value" }, new List<object>() { ID });
                return new Account((string)dt.Rows[0][0]);
            }
            catch
            {
                return null;
            }
        }


        public static Person getInfoByName(string name)
        {
            if (!isExistsName(name))
            {
                return null;
            }

            object ID = getField("ID", "TenTK", name);
            if (ID == null)
            {
                return null;
            }
            string strID = (string)ID;
            Person infoPer = Person.getInfo("ID", ID);
            if (Teacher.isExistTeacherID(strID))
            {
                Teacher teacher = Person.changeToTeacher(infoPer);
                teacher.updateTenKhoa(Teacher.getFieldTeacherByID("TenKhoa", strID));
                return teacher;
            }
            if (Student.isExistStudentID(strID))
            {
                Student student = Person.changeToStudent(infoPer);
                student.updateNameMajor(Student.getFieldStudentByID("TenNganh", strID));
                student.updateYear(Student.getFieldStudentByID("Nam", strID));
                return student;
            }
            return infoPer;
        }

        public static bool isExistsName(string name)
        {
            return (int)SQL.Excute_A_Value("Select Count(*) from DangkyTaiKhoan where TenTK = @Name", new List<string>() { "Name" }, new List<object>() { name }) != 0;
        }
        public static bool isRightPassword(string name, string password)
        {
            return (string)SQL.Excute_A_Value("Select MatKhau from DangkyTaiKhoan where TenTK = @Name", new List<string>() { "Name" }, new List<object>() { name }) == password;
        }

        public string getName ()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public string getID()
        {
            return ID;
        }

        public Date getDate()
        {
            return date;
        }

        public static object getField(string field, string fieldSource, object valueFieldSource)
        {
            try
            {
                object value = SQL.Excute_A_Value("Select " + field + " from DangKyTaiKhoan where " + fieldSource + " = @Field", new List<string>() { "Field" }, new List<object>() { valueFieldSource });
                return value == DBNull.Value ? null : value;
            }
            catch
            {
                return null;
            }
        }
        public void findInfoAccount()
        {
            DataTable data = SQL.Excute_Values("Select * from DangKyTaiKhoan where TenTK = @TenTK", new List<string>() { "TenTK" }, new List<object>() { name });
            object ID = data.Rows[0][1];
            object avatar = data.Rows[0][2];
            object password = data.Rows[0][3];
            object date = data.Rows[0][4];

            this.ID = ID == DBNull.Value ? null : (string) ID;
            this.avatar = avatar == DBNull.Value ? null : Avatar.ConvertBytesToImage((byte[])avatar);
            this.password = password == DBNull.Value ? null : (string)password;
            this.date = date == DBNull.Value ? null : new Date((DateTime)date);
        }
        public static string getPassByName(string nameAcct)
        {
            object pass = SQL.Excute_A_Value("Select MatKhau from DangKyTaiKhoan where TenTK = @TenTK", new List<string>() { "TenTK" }, new List<object>() { nameAcct });
            return pass == DBNull.Value ? null : (string)pass;
        }
        public static bool updateField(string ID, string fieldUpdate, object newValue)
        {
            try
            {
                SQL.Excute_Non_Value("Update DangKyTaiKhoan Set " + fieldUpdate + " = @newValue where ID = @ID", new List<string>() { "newValue", "ID" }, new List<object>() { newValue, ID });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateAvatar(string path)
        {
            try
            {
                string tail = path.Substring(path.Length - 4);
                Image img = Image.FromFile(path);
                SQL.Excute_Non_Value("Update DangKyTaiKhoan Set AnhDaiDien = @AnhDaiDien,DuoiFileAnh = @DuoiFileAnh where TenTK = @TenTK", new List<string>() { "AnhDaiDien", "DuoiFileAnh", "TenTK" }, new List<object>() { Avatar.ConvertImageToBytes(img, tail), tail, name });
                avatar = img;
                tailImg = tail;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateAvatar(Image avatar, string tail)
        {
            try
            {
                SQL.Excute_Non_Value("Update DangKyTaiKhoan Set AnhDaiDien = @AnhDaiDien where TenTK = @TenTK", new List<string>() { "AnhDaiDien", "TenTK" }, new List<object>() { Avatar.ConvertImageToBytes(avatar, tail) });
                this.avatar = avatar;
                tailImg = tail;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isPasswordValid(string password)
        {
            if (password.Length < minLengthPassword)
            {
                return false;
            }
            bool hadNumber = false;
            bool hadLowerAlpha = false;
            bool hadUpperAlpha = false;
            bool hadSpecialChar = false;
            for (int i = 0;i<password.Length;i++)
            {
                if (char.IsNumber(password[i]))
                {
                    hadNumber = true;
                }
                else if (char.IsLetter(password[i]))
                {
                    if (char.IsUpper(password[i]))
                    {
                        hadUpperAlpha = true;
                    }
                    else
                    {
                        hadLowerAlpha = true;
                    }
                }
                else
                {
                    hadSpecialChar = true;
                }
            }
            if (!hadNumber || !hadUpperAlpha || !hadLowerAlpha || !hadSpecialChar || !hadUpperAlpha)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Account)
            {
                Account tmp = (Account)obj;
                return tmp.getName() == getName() && tmp.getPassword() == getPassword() && tmp.getID() == getID() && tmp.getDate().Equals(tmp.getDate());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool deleteAccount(string field, object value)
        {
            try
            {
                SQL.Excute_Non_Value("Delete DangKyTaiKhoan where " + field + " = @Value", new List<string>() { "Value" }, new List<object>() { value });
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
