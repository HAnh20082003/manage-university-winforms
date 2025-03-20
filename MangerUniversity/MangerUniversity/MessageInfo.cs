using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    class MessageInfo
    {
        public static DialogResult makeMessage(string type, string title, string content)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OK;
            MessageBoxIcon messIcon = MessageBoxIcon.None;
            if (type == "Error")
            {
                messButton = MessageBoxButtons.OK;
                messIcon = MessageBoxIcon.Error;
            }
            else if (type == "Warning")
            {
                messButton = MessageBoxButtons.OK;
                messIcon = MessageBoxIcon.Warning;
            }
            else if (type == "Question")
            {
                messButton = MessageBoxButtons.YesNo;
                messIcon = MessageBoxIcon.Question;
            }
            else if (type == "Information")
            {
                messButton = MessageBoxButtons.OK;
                messIcon = MessageBoxIcon.Information;
            }
            return MessageBox.Show(content, title, messButton, messIcon);
        }
    }
}
