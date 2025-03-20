using System.Drawing;
using System.Windows.Forms;

namespace MangerUniversity
{
    class BoxButton
    {

        public static Button getButton(string name, string nameImage, string text, int width, int height, int X, int Y)
        {
            Button btn = new Button()
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                BackColor = Color.Lavender,
                Image = Image.FromFile("Assets/Imgs/" + nameImage + ".png"),
                ImageAlign = ContentAlignment.MiddleLeft,
                Name = name,
                Location = new Point(X, Y),
                Size = new Size(width, height),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
            };
            General.addTittle(btn, text);
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.MediumTurquoise;
            btn.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue; 

            return btn;
        }
    }
}
