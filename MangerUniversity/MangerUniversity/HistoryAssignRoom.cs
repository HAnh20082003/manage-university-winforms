using System;
using System.Collections.Generic;
using System.Data;

namespace MangerUniversity
{
    class HistoryAssignRoom
    {
        private string maSV, nameSubject, maGV;
        private int hocKi, year;
        private InfoAssignRoom infoAssignRoom;

        public HistoryAssignRoom(string maSV, int hocKi, int year, string nameSubject, string maGV, InfoAssignRoom infoAssignRoom)
        {
            this.maSV = maSV;
            this.hocKi = hocKi;
            this.year = year;
            this.nameSubject = nameSubject;
            this.maGV = maGV;
            this.infoAssignRoom = infoAssignRoom;
        }

        public static List<HistoryAssignRoom> getInfo(string maSV, int hocKi, int year)
        {
            List<HistoryAssignRoom> lst = new List<HistoryAssignRoom>();
            try
            {
                DataTable dt = SQL.Excute_Values("Select * from LichSuDangKyPhongCu where MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam", new List<string>() { "MaSV", "HocKi", "Nam" }, new List<object>() { maSV, hocKi, year });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HistoryAssignRoom historyAssignRoom = new HistoryAssignRoom(maSV, hocKi, year, (string)dt.Rows[i][3], (string)dt.Rows[i][4], new InfoAssignRoom((string)dt.Rows[i][5], (int)dt.Rows[i][6], new Date((DateTime)dt.Rows[i][7]), new Date((DateTime)dt.Rows[i][8]), (int)dt.Rows[i][9], (int)dt.Rows[i][10], (string)dt.Rows[i][11]));
                    lst.Add(historyAssignRoom);
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        public InfoAssignRoom getInfoAssignRoom()
        {
            return infoAssignRoom;
        }
        public string getMaSV()
        {
            return maSV;
        }
        public string getMaGV()
        {
            return maGV;
        }
        public string getNameSubject()
        {
            return nameSubject;
        }
        public int getHocKi()
        {
            return hocKi;
        }
        public int getYear()
        {
            return year;
        }
    }
}
