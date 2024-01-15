using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace Filter.GUI.Services
{
    internal class ImageConverter
    {
        public static byte[] ConvertToByteArray(Bitmap bitmap)
        {
            var array = new byte[bitmap.Height * bitmap.Width * 3];
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {

                    byte r = bitmap.GetPixel(j, i).R;
                    byte g = bitmap.GetPixel(j, i).G;
                    byte b = bitmap.GetPixel(j, i).B;
                    array[i * bitmap.Width * 3 + j * 3] = r;
                    array[i * bitmap.Width * 3 + j * 3 + 1] = g;
                    array[i * bitmap.Width * 3 + j * 3 + 2] = b;


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
            Bitmap bitmap = new Bitmap(RowNumber, (image.Length / 3) / RowNumber);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color color = Color.FromArgb(image[i * RowNumber * 3 + j * 3], image[i * RowNumber * 3 + j * 3 + 1],
                        image[i * RowNumber * 3 + j * 3 + 2]);
                    bitmap.SetPixel(j, i, color);
                }
            }
            return bitmap;
        }
        public static string SaveToFIle(Bitmap bitmap, string path, int t = 0)
        {
            if (path.Contains(".jpg"))
            {
            string decsription = "_Ths" + t.ToString() + "_Date" + DateTime.Now.ToString() + ".jpg";
            decsription = decsription.Replace(" ", "_");
            decsription = decsription.Replace(":", "_");
            string newPath = path.Replace(".jpg", decsription);
            bitmap.Save(newPath);
            return newPath;
            }
            else if (path.Contains(".bmp"))
            {
                string decsription = "_Ths" + t.ToString() + "_Date" + DateTime.Now.ToString() + ".bmp";
                decsription = decsription.Replace(" ", "_");
                decsription = decsription.Replace(":", "_");
                string newPath = path.Replace(".bmp", decsription);
                bitmap.Save(newPath);
                return newPath;
            }
            else { return path; }
        }
    }
}
