using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class Classroom
    {
        private string name;
        private int maxCount;
        public Classroom(string name, int maxCount)
        {
            this.name = name;
            this.maxCount = maxCount;
        }

        public static bool isExistsNameRoom(string nameRoom)
        {
            try
            {
                return (int)SQL.Excute_A_Value("Select count(*) from PhongHoc where Ten = @ten", new List<string>() { "ten" }, new List<object>() { nameRoom }) != 0;
            }
            catch
            {
                return true;
            }
        }
        public string getName()
        {
            return name;
        }
        public int getMaxCount()
        {
            return maxCount;
        }

        public static List<InfoAssignRoom> getAssignRoom(string nameRoom)
        {
            try
            {
                List<InfoAssignRoom> lst = InfoAssignRoom.getAllInfoAssign();
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].getNameRoom() != nameRoom)
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
        public static List<InfoAssignRoom> getAssignRoom(int maLop)
        {
            try
            {
                List<InfoAssignRoom> lst = InfoAssignRoom.getAllInfoAssign();
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].getMaLop() != maLop)
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

        public List<Subject> getSubject()
        {
            List<Subject> subs = new List<Subject>();
            List<InfoAssignRoom> infoAssignRooms = InfoAssignRoom.getInfo(name);
            if (infoAssignRooms == null)
            {
                return null;
            }
            for (int i = 0; i < infoAssignRooms.Count;i++)
            {
                InfoAssignTeacher infoAssignTeacher = InfoAssignTeacher.getInfo(infoAssignRooms[i].getMaLop());
                subs.Add(Subject.getInfo("Ten", infoAssignTeacher.getNameSubject()));
            }
            return subs;
        }

        public void updateInfo(string name, int maxCount)
        {
            this.name = name;
            this.maxCount = maxCount;
        }

        public static List<Classroom> getAllRooms()
        {
            DataTable dt = SQL.Excute_Values("Select * from PhongHoc", null, null);
            List<Classroom> lst = new List<Classroom>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(new Classroom((string)dt.Rows[i][0], (int)dt.Rows[i][1]));
            }
            return lst;
        }

        public bool addNewRoom()
        {
            try
            {
                SQL.Excute_Non_Value("Insert into PhongHoc values (@Ten, @SiSoToiDa)", new List<string>() { "Ten", "SiSoToiDa" }, new List<object>() { name, maxCount });
                return true;
            }
            catch
            {
                MessageInfo.makeMessage("Error", "Rất tiếc", "Thêm phòng học thất bại!! Mã PH đã tồn tại");
                return false;
            }
        }

        public bool updateRoom(string newName, int newMaxCount)
        {
            try
            {
                SQL.Excute_Non_Value("Update PhongHoc Set Ten = @newName where Ten = @oldName", new List<string>() { "newName", "oldName" }, new List<object>() { newName, name });
                SQL.Excute_Non_Value("Update PhongHoc Set SiSoToiDa = @newMaxCount where Ten = @Name", new List<string>() { "newMaxCount", "Name" }, new List<object>() { newMaxCount, newName });
                name = newName;
                maxCount = newMaxCount;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteRoom()
        {
            try
            {
                SQL.Excute_Non_Value("Delete PhongHoc where Ten = @Ten", new List<string>() { "Ten" }, new List<object>() { name });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
