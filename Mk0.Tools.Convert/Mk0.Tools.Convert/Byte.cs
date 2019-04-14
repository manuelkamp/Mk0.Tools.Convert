using System.IO;

namespace Mk0.Tools.Convert
{
    public static class Byte
    {
        public static System.Drawing.Image ToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}
