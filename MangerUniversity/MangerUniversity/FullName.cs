using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangerUniversity
{
    class FullName
    {
        private string firstName;
        private string middleName;
        private string lastName;
        public FullName(string fullName)
        {
            string[] tmp = fullName.Split(' ');
            firstName = tmp[0];
            lastName = tmp[tmp.Length - 1];
            middleName = "";
            for (int i = 1; i < tmp.Length - 1; i ++)
            {
                middleName += tmp[i];
                if (i < tmp.Length - 2)
                {
                    middleName += " ";
                }
            }
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getMiddleName()
        {
            return middleName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getMiddleAndLast()
        {
            return middleName + " " + lastName;
        }
        public string getFullName()
        {
            return firstName + " " + getMiddleAndLast();
        }
        public static int compareName(string A, string B) //1 -> A > B, 0 -> A = B, -1 -> A < B
        {
            FullName nameA = new FullName(A);
            FullName nameB = new FullName(B);
            
            if (nameA.getLastName()[0] < nameB.getLastName()[0])
            {
                return -1;
            }
            int lengthA = nameA.getLastName().Length;
            int lengthB = nameB.getLastName().Length;
            int length = lengthA > lengthB ? lengthB : lengthA;
            for (int i = 0; i < length;i++)
            {
                if (nameA.getLastName()[i] > nameB.getLastName()[i])
                {
                    return 1;
                }
                if (nameA.getLastName()[i] < nameB.getLastName()[i])
                {
                    return -1;
                }
            }
            if (lengthA > lengthB)
            {
                return 1;
            }
            if (lengthA < lengthB)
            {
                return -1;
            }

            lengthA = nameA.getMiddleName().Length;
            lengthB = nameB.getMiddleName().Length;
            length = lengthA > lengthB ? lengthB : lengthA;
            for (int i = 0; i < length; i++)
            {
                if (nameA.getMiddleName()[i] > nameB.getMiddleName()[i])
                {
                    return 1;
                }
                if (nameA.getMiddleName()[i] < nameB.getMiddleName()[i])
                {
                    return -1;
                }
            }
            if (lengthA > lengthB)
            {
                return 1;
            }
            if (lengthA < lengthB)
            {
                return -1;
            }

            lengthA = nameA.getFirstName().Length;
            lengthB = nameB.getFirstName().Length;
            length = lengthA > lengthB ? lengthB : lengthA;
            for (int i = 0; i < length; i++)
            {
                if (nameA.getFirstName()[i] > nameB.getFirstName()[i])
                {
                    return 1;
                }
                if (nameA.getFirstName()[i] < nameB.getFirstName()[i])
                {
                    return -1;
                }
            }
            if (lengthA > lengthB)
            {
                return 1;
            }
            if (lengthA < lengthB)
            {
                return -1;
            }
            return 0;
        }

    }
}
