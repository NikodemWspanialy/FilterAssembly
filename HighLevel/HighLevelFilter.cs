using static System.Net.Mime.MediaTypeNames;

namespace HighLevel
{
    public class HighLevelFilter
    {
        private byte[] _image;
        private long _startPoint;
        private long _endPoint;

        public HighLevelFilter(ref byte[] image, long startPoint = 0, long endPoint = 0)
        {
            _image = image;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
        public void filter()
        {
            
            if (_endPoint != 0)
            {

                for (long i = _startPoint; i < _endPoint; i = i + 3)
                {
                    try
                    {

                    int r = _image[i];
                    int g = _image[i + 1];
                    int b = _image[i + 2];
                    double srednia = (r + b + g) / 3;
                    int sredniaint = (int)Math.Round(srednia);
                    _image[i + 0] = (byte)sredniaint;
                    _image[i + 1] = (byte)sredniaint;
                    _image[i + 2] = (byte)sredniaint;
                    }
                    catch(Exception e)
                    {
                        //co tu rpboc 
                    }
                }
            }
            else
            {
                for (int i = 0; i < _image.Length; i += 3)
                {
                    int r = _image[i];
                    int g = _image[i + 1];
                    int b = _image[i + 2];
                    double srednia = (r + b + g) / 3;
                    int sredniaint = (int)Math.Round(srednia);
                    _image[i + 0] = (byte)sredniaint;
                    _image[i + 1] = (byte)sredniaint;
                    _image[i + 2] = (byte)sredniaint;
                }

            }

        }
    
    }
}