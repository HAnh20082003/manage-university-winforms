using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    class General
    {
        private static Color colorHover, colorLeave;

        public static Color ColorHover { get => colorHover; set => colorHover = value; }
        public static Color ColorLeave { get => colorLeave; set => colorLeave = value; }

        public static void addTittle(Control control, string text)
        {
            ToolTip toolTip = new ToolTip()
            {
                InitialDelay = 0,
                IsBalloon = false,
            };
            toolTip.SetToolTip(control, text);
        }
        public static Label getTitle(string name, string text, int X, int Y)
        {
            Label lbl = new Label()
            {
                Location = new Point(X, Y),
                AutoSize = true,
                Name = name,
                Text = text,
                ForeColor = Color.Purple,
                Font = new Font("Times New Roman", 10),
            };
            return lbl;
        }

        public static TextBox getTextBox(string name, int X, int Y)
        {
            TextBox txt = new TextBox()
            {
                Name = name,
                Location = new Point(X, Y),
                Width = 300,
                Font = new Font("Times New Roman", 10),
                ForeColor = Color.Maroon,
            };
            return txt;
        }
        public static void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar > 30))
            {
                e.Handled = true;
                return;
            }

        }
        public static bool isDateAInB(Date dateStartA, Date dateEndA, int tietStartA, int tietEndA, string thuA, Date dateStartB, Date dateEndB, int tietStartB, int tietEndB, string thuB)
        {
            if (thuA != thuB)
            {
                return false;
            }
            bool isSameDate = false;
            if (Date.compareDate(dateStartA, dateStartB) >= 0 && Date.compareDate(dateStartA, dateEndB) <= 0)
            {
                isSameDate = true;
            }

            else if (Date.compareDate(dateEndA, dateStartB) >= 0 && Date.compareDate(dateEndA, dateEndB) <= 0)
            {
                isSameDate = true;
            }

            else if (Date.compareDate(dateStartA, dateStartB) < 0 && Date.compareDate(dateEndA, dateEndB) > 0)
            {
                isSameDate = true;
            }

            if (isSameDate)
            {
                bool isSameTiet = false;
                if (tietStartA >= tietStartB && tietStartA <= tietEndB)
                {
                    isSameTiet = true;
                }
                else if (tietEndA >= tietStartB && tietEndA <= tietEndB)
                {
                    isSameTiet = true;
                }
                else if (tietStartA < tietStartB && tietEndA > tietEndB)
                {
                    isSameTiet = true;
                }
                if (isSameTiet)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
