using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateBox
{
    public class Box
    {
        private string pathImgsOrName;
        private int widthBox = 80, heightBox = 80;
        public int getWidthBox()
        {
            return widthBox;
        }
        public int getHeightBox()
        {
            return heightBox;
        }
        public void updateSizeBox(int newWidth, int newHeight)
        {
            if (newWidth > 0)
            {
                widthBox = newWidth;
            }
            if (newHeight > 0)
            {
                heightBox = newHeight;
            }
        }
        public Box(int widthBox, int heightBox, string pathImgsOrName)
        {
            this.pathImgsOrName = pathImgsOrName;
            if (widthBox > 0)
            {
                this.widthBox = widthBox;
            }
            if (heightBox > 0)
            {
                this.heightBox = heightBox;
            }
        }
        public PictureBox getPictureBox(int locaX, int locaY, object tag = null)
        {
            PictureBox box = new PictureBox()
            {
                Image = Image.FromFile(pathImgsOrName),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(widthBox, heightBox),
                Location = new Point(locaX, locaY),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand,
                Tag = tag,
            };
            return box;
        }
        public Label getLabelBox(int locaX, int locaY, object tag = null)
        {
            Label box = new Label()
            {
                Text = pathImgsOrName,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(widthBox, heightBox),
                Location = new Point(locaX, locaY),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand,
                Tag = tag,
            };
            return box;
        }
    }
}
