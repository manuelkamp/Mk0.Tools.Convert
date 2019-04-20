using System.Drawing;
using System.IO;

namespace Mk0.Tools.Convert
{
    public static class ByteConvert
    {
        public static Image ToImage(this byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
