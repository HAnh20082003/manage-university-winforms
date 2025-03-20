using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Teacher : Person
    {
        private string tenKhoa;
        public Teacher(string ID, string phone, string fullName, string address, string email, Date birth) : base(ID, phone, fullName, address, email, birth)
        {

        }
        public Teacher(string ID, string phone, string fullName, string address, string email, Date birth, string tenKhoa) : base(ID, phone, fullName, address, email, birth)
        {
            this.tenKhoa = tenKhoa;
        }
        
        public string getTenKhoa()
        {
            return tenKhoa;
        }
        public void updateTenKhoa(object tenKhoa)
        {
            if (tenKhoa == null)
            {
                this.tenKhoa = null;
            }
            else
            {
                this.tenKhoa = (string)tenKhoa;
            }
        }
        public static List<Teacher> getTeacherSorted(string fieldSort, bool isInscrease = true)
        {
            List<Teacher> teachers = new List<Teacher>();
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
                DataTable dt = SQL.Excute_Values("Select * from GiangVien order by " + fieldSort + strSortBy, null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Teacher teacher = (Teacher)getInfo("ID", (string)dt.Rows[i][0]);
                    teachers.Add(teacher);
                }
                return teachers;
            }
            catch
            {
                return null;
            }
        }

        public static object getFieldTeacherByID(string field, string ID)
        {
            if (ID == null)
            {
                return null;
            }
            try
            {
                object value = SQL.Excute_A_Value("Select " + field + " from GiangVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return value == DBNull.Value ? null : value;
            }
            catch
            {
                return null;
            }
        }
        public static bool isExistTeacherID(string ID)
        {
            if (ID == null)
            {
                return false;
            }
            return (int)SQL.Excute_A_Value("Select count(*) from GiangVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID }) != 0;
        }

        public bool insertTeacher()
        {
            if (insertPerson())
            {
                try
                {
                    if (string.IsNullOrEmpty(getTenKhoa()))
                    {
                        SQL.Excute_Non_Value("Insert into GiangVien(ID) values (@ID)", new List<string>() { "ID" }, new List<object>() { getID() });
                    }
                    else
                    {
                        SQL.Excute_Non_Value("Insert into GiangVien values (@ID, @TenKhoa)", new List<string>() { "ID", "TenKhoa" }, new List<object>() { getID(), getTenKhoa() });
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public bool updateTeacher(string newID = null)
        {
            string oldID = getID();
            if (updatePerson(newID))
            {
                try
                {
                    SQL.Excute_Non_Value("Update GiangVien Set TenKhoa = @TenKhoa where ID = @ID", new List<string>() { "TenKhoa", "ID" }, new List<object>() { getTenKhoa(), oldID });
                    if (newID != null)
                    {
                        SQL.Excute_Non_Value("Update GiangVien Set ID = @NewID where ID = @OldID", new List<string>() { "NewID", "OldID" }, new List<object>() { newID, oldID });
                        updateID(newID);
                    } 
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool deleteTeacher(string ID)
        {
            try
            {
                SQL.Excute_Non_Value("Delete GiangVien where ID = @ID", new List<string>() { "ID" }, new List<object>() { ID });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Class getClass()
        {
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from Lop where MaCoVan = @MaGV", new List<string>() { "MaGV" }, new List<object>() { getID() });
                return new Class((string)dt.Rows[0][0], getID(), (int)dt.Rows[0][2], (string)dt.Rows[0][3]);
            }
            catch
            {
                return null;
            }
        }

        public static List<InfoAssignRoom> getAllAssignRoom(string MaGV)
        {
            List<InfoAssignRoom> infoAssignRooms = InfoAssignRoom.getAllInfoAssign();
            for (int i =0; i < infoAssignRooms.Count; i++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignRooms[i].getMaLop());
                if (infoAssignTeacher.getMaGV() != MaGV)
                {
                    infoAssignRooms.RemoveAt(i);
                    i--;
                }
            }
            return infoAssignRooms;
        }

        public List<InfoAssignTeacher> getInfoAssign()
        {
            List<InfoAssignTeacher> infoAssigns = InfoAssignTeacher.getAllAssign();
            for (int i =0; i < infoAssigns.Count; i++)
            {
                if (infoAssigns[i].getMaGV() != getID())
                {
                    infoAssigns.RemoveAt(i);
                    i--;
                }
            }
            return infoAssigns;
        }

        public List<Subject> getSubjectTeach()
        {
            List<Subject> sub = new List<Subject>();
            List<InfoAssignTeacher> info = InfoAssignTeacher.getAllAssign();
            for (int i= 0;i < info.Count; i++)
            {
                if (info[i].getMaGV() != getID())
                {
                    continue;
                }
                sub.Add(Subject.getInfo("Ten", info[i].getNameSubject()));
            }
            return sub;
        }

        public List<Student> getMyMainClass()
        {
            Class myMain = Class.getClassByField("MaCoVan", getID());
            if (myMain == null)
            {
                return null;
            }
            return myMain.getStudents();
        }
        public static List<Teacher> getAllTeacher()
        {
            List<Teacher> lst = new List<Teacher>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from GiangVien", null, null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string ID = (string)dt.Rows[i][0];
                    Teacher teacher = (Teacher)getInfo("ID", ID);
                    lst.Add(teacher);
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public static List<Survey> getAllSurvey(string maGV)
        {
            List<Survey> surveys = Survey.getAllSurvey();
            for (int i =0; i < surveys.Count; i++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(surveys[i].getMaLop());
                if (infoAssignTeacher.getMaGV() != maGV)
                {
                    surveys.RemoveAt(i);
                    i--;
                }
            }
            return surveys;
        }

        public static bool isAssignClass(string ID)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from Lop where MaCoVan = @ID", new List<string>() { "ID", }, new List<object>() { ID }) != 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
