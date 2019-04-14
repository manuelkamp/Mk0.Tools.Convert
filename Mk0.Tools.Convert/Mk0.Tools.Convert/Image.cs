using System.IO;

namespace Mk0.Tools.Convert
{
    public static class Image
    {
        public static byte[] ToByte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
