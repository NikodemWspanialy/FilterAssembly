using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace FIlter.GUI.Services
{
    internal class ImageConverter
    {
        public static byte[] ConvertToByteArray(Bitmap bitmap)
        {
            int hi = 0, wi = 0;
            var array = new byte[bitmap.Height * bitmap.Width * 3];
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    try
                    {
                        byte a = bitmap.GetPixel(j, i).A;
                        byte r = bitmap.GetPixel(j, i).R;
                        byte g = bitmap.GetPixel(j, i).G;
                        byte b = bitmap.GetPixel(j, i).B;
                        array[i * bitmap.Height + j * 3] = r;
                        array[i *bitmap.Height + j * 3 + 1] = g;
                        array[i *bitmap.Height + j * 3 + 2] = b;

                    }
                    catch (Exception)
                    {
                        hi = i;
                        wi = 4 * j + 3;
                    }
                }
            }
            return array;
        }
        public static Bitmap GetBitMap(string path)
        {
            return new Bitmap(path);
        }
        public static Bitmap ConvertToBitmap(byte[] image, int RowNumber)
        {
            Bitmap bitmap = new Bitmap(RowNumber,(image.Length/3)/RowNumber);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color color = Color.FromArgb(image[i*RowNumber + j * 4], image[i*RowNumber+ 3 + 1],
                        image[i*RowNumber+ j * 3 + 2]);
                    bitmap.SetPixel(j, i, color);
                }
            }
            return bitmap;
        }
    }
}
