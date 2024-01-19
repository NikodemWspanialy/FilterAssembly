using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Filter
    {
        public static void filter(ref float[] image, long startPoint, long endPoint, ref float[] returnImage)
        {
            float[] dzielnik = new float[] { 0.33f, 0.33f, 0.33f, 1.0f };
            if (endPoint != 0)
            {

                for (long i = startPoint; i < endPoint; i = i + 4)
                {
                    try
                    {

                        float r = image[i];
                        float g = image[i + 1];
                        float b = image[i + 2];
                        float a = image[i + 3];
                        r = r * dzielnik[0];
                        g = g * dzielnik[1];
                        b = b * dzielnik[2];
                        a = a * dzielnik[3];
                        float srednia = r + b + g + a;
                        returnImage[i + 0] = (byte)srednia;
                        returnImage[i + 1] = (byte)srednia;
                        returnImage[i + 2] = (byte)srednia;
                        returnImage[i + 3] = (byte)srednia;
                    }
                    catch (Exception e)
                    {
                        //co tu rpboc 
                        Console.WriteLine("if program hit this place something gone wrong");
                    }
                }
            }
            else
            {
                return;

            }

        }
    }
}
