using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Mk0.Tools.Convert
{
    public static class ImageConvert
    {
        public static byte[] ToByte(this Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }

        public static byte[] ToByte(this Image image, string extension)
        {
            using (var ms = new MemoryStream())
            {
                switch (extension)
                {
                    case ".jpeg":
                    case ".jpg":
                        image.Save(ms, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        image.Save(ms, ImageFormat.Png);
                        break;
                    case ".gif":
                        image.Save(ms, ImageFormat.Gif);
                        break;
                    default:
                        image.Save(ms, ImageFormat.Png);
                        break;
                }
                return ms.ToArray();
            }
        }
    }
}
