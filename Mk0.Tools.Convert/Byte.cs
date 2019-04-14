using System.IO;

namespace Mk0.Tools.Convert
{
    public static class ByteConvert
    {
        public static System.Drawing.Image ToImage(this byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}
