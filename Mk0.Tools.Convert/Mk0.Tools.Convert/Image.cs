using System.IO;

namespace Mk0.Tools.Convert
{
    public static class ImageConvert
    {
        public static byte[] ToByte(this System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
