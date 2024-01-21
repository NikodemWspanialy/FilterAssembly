using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Diagnostics.Metrics;

namespace Filter.GUI.Services
{
    internal class ImageConverter
    {
        public static float[] ConvertToByteArray(Bitmap bitmap)
        {
            var array = new float[bitmap.Height * bitmap.Width * 4];
            var counter = 0;
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    array[counter++] = bitmap.GetPixel(j, i).R;
                    array[counter++] = bitmap.GetPixel(j, i).G;
                    array[counter++] = bitmap.GetPixel(j, i).B;
                    array[counter++] = 0;

                }
            }
            return array;
        }
        public static Bitmap GetBitMap(string path)
        {
            return new Bitmap(path);
        }
        public static Bitmap ConvertToBitmap(float[] image, int RowNumber)
        {
            Bitmap bitmap = new Bitmap(RowNumber, (image.Length / 4) / RowNumber);
            var counter = 0;
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color color = Color.FromArgb((byte)image[counter++], (byte)image[counter++],
                        (byte)image[counter++]);
                    ++counter;
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
