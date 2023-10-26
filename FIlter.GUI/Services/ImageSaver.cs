using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.GUI.Services
{
    public class ImageSaver
    {
        static public void SaveToFIle(Bitmap bitmap, string path)
        {
            string newPath = path.Replace(".jpg", "_BlackAndWhite.jpg");
            bitmap.Save(newPath);
        }
    }
}
