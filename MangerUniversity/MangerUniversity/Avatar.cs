using System.Drawing;
using System.IO;

namespace MangerUniversity
{
    class Avatar
    {
        public static byte[] ConvertImageToBytes(Image img, string tail)
        {
            MemoryStream ms = new MemoryStream();
            if (img != null)
            {
                if (tail == ".gif")
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                else if (tail == ".png")
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                else
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }

        //Chuyển mảng bytes về lại ảnh
        public static Image ConvertBytesToImage(byte[] img_byte)
        {
            MemoryStream ms = new MemoryStream(img_byte);
            try
            {
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }
    }
}
