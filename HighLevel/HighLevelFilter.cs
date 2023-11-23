using static System.Net.Mime.MediaTypeNames;

namespace HighLevel
{
    public class HighLevelFilter
    {
        public static void filter(ref byte[] image, long startPoint, long endPoint, ref byte[] returnImage)
        {

            if (endPoint != 0)
            {

                for (long i = startPoint; i < endPoint; i = i + 3)
                {
                    try
                    {

                        int r = image[i];
                        int g = image[i + 1];
                        int b = image[i + 2];
                        double srednia = (r + b + g) / 3;
                        int sredniaint = (int)Math.Round(srednia);
                        returnImage[i + 0] = (byte)sredniaint;
                        returnImage[i + 1] = (byte)sredniaint;
                        returnImage[i + 2] = (byte)sredniaint;
                    }
                    catch (Exception e)
                    {
                        //co tu rpboc 
                        Console.WriteLine("cos jest nie tak nie doszedlem do tego czemu");
                    }
                }
            }
            else
            {
                for (int i = 0; i < image.Length; i += 3)
                {
                    int r = image[i];
                    int g = image[i + 1];
                    int b = image[i + 2];
                    double srednia = (r + b + g) / 3;
                    int sredniaint = (int)Math.Round(srednia);
                    returnImage[i + 0] = (byte)sredniaint;
                    returnImage[i + 1] = (byte)sredniaint;
                    returnImage[i + 2] = (byte)sredniaint;
                }

            }

        }

    }
}