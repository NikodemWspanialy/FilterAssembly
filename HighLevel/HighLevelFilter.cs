namespace HighLevel
{
    public class HighLevelFilter
    {
        public static void filter(ref byte[] image, int startPoint, int endPoint)
        {
            for (int i = startPoint; i < endPoint; i = i * 3)
            {
                int r = image[i];
                int g = image[i + 1];
                int b = image[i + 2];
                double srednia = (r + b + g) / 3;
                int sredniaint = (int)Math.Round(srednia);
                image[i + 0] = (byte)sredniaint;
                image[i + 1] = (byte)sredniaint;
                image[i + 2] = (byte)sredniaint;
            }

        }
        public static void filter(ref byte[] image)
        {
            for (int i = 0; i < image.Length; i += 3)
            {
                int r = image[i];
                int g = image[i + 1];
                int b = image[i + 2];
                double srednia = (r + b + g) / 3;
                int sredniaint = (int)Math.Round(srednia);
                image[i + 0] = (byte)sredniaint;
                image[i + 1] = (byte)sredniaint;
                image[i + 2] = (byte)sredniaint;
            }
        }
    }
}