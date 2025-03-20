using System;

namespace MangerUniversity
{
    class Date
    {
        private string dayOfWeek;
        private int day, month, year;
        public static bool isDateValid(string dayOfWeek, int day,int month, int year)
        {
            bool isOk = false;
            for (int i = 2; i <= 7; i++)
            {
                if (dayOfWeek == "Thứ " + i)
                {
                    isOk = true;
                    break;
                }
            }
            if (!isOk && dayOfWeek != "Chủ Nhật")
            {
                return false;
            }
            if (day <= 0 || month <= 0 || month > 12 || year <= 0)
            {
                return false;
            }
            if (month == 2)
            {
                if (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0)) //năm nhuận
                {
                    return day <= 29;
                }
                return day <= 28;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return day <= 31;
            }
            return day <= 30;
        }

        public static string getStrDayOfWeek(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);
            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                return "Thứ 2";
            }
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                return "Thứ 3";
            }
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                return "Thứ 4";
            }
            if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                return "Thứ 5";
            }
            if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                return "Thứ 6";
            }
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                return "Thứ 7";
            }
            return "Chủ Nhật";
        }
        public static DayOfWeek getDayOfWeek(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);
            return dt.DayOfWeek;
        }
        public static bool isDateValid(string date, char space)
        {
            string[] tmp = date.Split(space);
            if (tmp.Length != 3)
            {
                return false;
            }
            try
            {
                int day = int.Parse(tmp[0]); 
                int month = int.Parse(tmp[1]);
                int year = int.Parse(tmp[2]);
                string dayOfWeek = getStrDayOfWeek(day, month, year);
                return isDateValid(dayOfWeek, day, month, year);
            }
            catch
            {
                return false;
            }
        }
        public Date(string dayOfWeek, int day,int month, int year)
        {
            this.dayOfWeek = dayOfWeek;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date(string date, char space)
        {
            string[] tmp = date.Split(space);
            if (tmp.Length != 3)
            {
                return;
            }
            try
            {
                int day = int.Parse(tmp[0]);
                int month = int.Parse(tmp[1]);
                int year = int.Parse(tmp[2]);
                string dayOfWeek = getStrDayOfWeek(day, month, year);
                this.day = day;
                this.month = month;
                this.year = year;
                this.dayOfWeek = dayOfWeek;
            }
            catch (Exception e)
            {
                MessageInfo.makeMessage("Error", "", e.ToString());
            }
        }
        public Date(DateTime date)
        {
            day = date.Day;
            month = date.Month;
            year = date.Year;
            dayOfWeek = getStrDayOfWeek(date.Day, date.Month, date.Year);
        }


        private string getStrDecimalNumber(int number, int size)
        {
            string decimalNumber = number.ToString();
            while(decimalNumber.Length < size)
            {
                decimalNumber = "0" + decimalNumber;
            }
            return decimalNumber;
        }

        public DateTime getDate()
        {
            return new DateTime(year, month, day);
        }
        public string getDateNotDayOfWeek(char symbol)
        {
            return getStrDecimalNumber(day, 2) + symbol + getStrDecimalNumber(month, 2) + symbol + getStrDecimalNumber(year, 4);
        }

        public string getStrDate(char symbol)
        {
            return dayOfWeek + ", " + getDateNotDayOfWeek(symbol);
        }


        public int getDay()
        {
            return day;
        }
        
        public int getMonth()
        {
            return month;
        }

        public int getYear()
        {
            return year;
        }
        public string getStrDayOfWeek()
        {
            return dayOfWeek;
        }
        public DayOfWeek getDayOfWeek()
        {
            return getDayOfWeek(day, month, year);
        }

        public string getStrDay()
        {
            return getStrDecimalNumber(day, 2);
        }
        public string getStrMonth()
        {
            return getStrDecimalNumber(month, 2);
        }
        public string getStrYear()
        {
            return getStrDecimalNumber(year, 4);
        }
        public override bool Equals(object obj)
        {
            if (obj is Date)
            {
                Date tmp = (Date)obj;
                return tmp.getDay() == getDay() && tmp.getMonth() == getMonth() && tmp.getYear() == getYear();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static int compareDate(Date A, Date B)
        {
            if (A.getYear() > B.getYear())
            {
                return 1;
            }
            if (A.getYear() < B.getYear())
            {
                return -1;
            }
            if (A.getMonth() > B.getMonth())
            {
                return 1;
            }
            if (A.getMonth() < B.getMonth())
            {
                return -1;
            }
            if (A.getDay() > B.getDay())
            {
                return 1;
            }
            if (A.getDay() < B.getDay())
            {
                return -1;
            }
            return 0;
        }

        public static Date getNextDate(Date date)
        {
            int newDay = date.getDay(), newMonth = date.getMonth(), newYear = date.getYear();
            if (newMonth == 2)
            {
                if (newYear % 4 == 0 || (newYear % 100 == 0 && newYear % 400 == 0)) //năm nhuận
                {
                    if (newDay < 29)
                    {
                        newDay++;
                    }
                    else
                    {
                        newDay = 1;
                        if (newMonth < 12)
                        {
                            newMonth++;
                        }
                        else
                        {
                            newMonth = 1;
                            newYear++;
                        }
                    }
                }
            }
            else if (newMonth == 1 || newMonth == 3 || newMonth == 5 || newMonth == 7 || newMonth == 8 || newMonth == 10 || newMonth == 12)
            {
                if (newDay < 31)
                {
                    newDay++;
                }
                else
                {
                    newDay = 1;
                    if (newMonth < 12)
                    {
                        newMonth++;
                    }
                    else
                    {
                        newMonth = 1;
                        newYear++;
                    }
                }
            }
            else
            {
                if (newDay < 30)
                {
                    newDay++;
                }
                else
                {
                    newDay = 1;
                    if (newMonth < 12)
                    {
                        newMonth++;
                    }
                    else
                    {
                        newMonth = 1;
                        newYear++;
                    }
                }
            }
            string dayOfWeek = getStrDayOfWeek(newDay, newMonth, newYear);
            return new Date(dayOfWeek, newDay, newMonth, newYear);
        }
        public static Date getPrevDate(Date date)
        {
            int newDay = date.getDay(), newMonth = date.getMonth(), newYear = date.getYear();
            if (newDay > 1)
            {
                newDay--;
            }
            else
            {
                if (newMonth > 1)
                {
                    newMonth--;
                    if (newMonth == 2)
                    {
                        if (newYear % 4 == 0 || (newYear % 100 == 0 && newYear % 400 == 0)) //năm nhuận
                        {
                            newDay = 29;
                        }
                    }
                    else if (newMonth == 1 || newMonth == 3 || newMonth == 5 || newMonth == 7 || newMonth == 8 || newMonth == 10 || newMonth == 12)
                    {
                        newDay = 31;
                    }
                    else
                    {
                        newDay = 30;
                    }
                }
                else
                {
                    newYear--;
                    newMonth = 12;
                    newDay = 31;
                }
            }
            string dayOfWeek = getStrDayOfWeek(newDay, newMonth, newYear);
            return new Date(dayOfWeek, newDay, newMonth, newYear);
        }
    }
}
