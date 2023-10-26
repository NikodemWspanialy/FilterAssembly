using Filter.GUI.Enum;
using Filter.GUI.Models;
using Filter.GUI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.GUI.Mechanizm
{

    internal class MainMechanizm
    {
        private uint threds;
        private Lenguage lenguage = Lenguage.CS;
        private byte[] Image;
        private int WidthNumber;
        private string PathToImage = string.Empty;
        IClass filter;

        public bool SetThreds(uint arg)
        {
            try
            {
                threds = arg;
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool SetLenguage(Lenguage lenguage)
        {
            switch (lenguage)
            {
                case Lenguage.CS:
                    lenguage = Lenguage.CS;
                    return true;
                    break;
                case Lenguage.ASM:
                    lenguage = Lenguage.ASM;
                    return true;
                    break;
                default: return false;
            }
            return false;
        }

        public bool SetImage(string file)
        {
            try
            {

                PathToImage = file;
                Bitmap oldBitmap = FIlter.GUI.Services.ImageConverter.GetBitMap(PathToImage);
                WidthNumber = oldBitmap.Width;
                Image = FIlter.GUI.Services.ImageConverter.ConvertToByteArray(oldBitmap);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public void run()
        {
            switch (lenguage)
            {
                case Lenguage.CS:

                    //HighLevel.HighLevelFilter.filter(ref Image);
                    filter = new HighLvlClass(ref Image, threds);
                    break;
                case Lenguage.ASM:

                    break;
                default:
                    return;
            }
            filter.Execute();
            Bitmap newBitmap = FIlter.GUI.Services.ImageConverter.ConvertToBitmap(Image, WidthNumber);
            FIlter.GUI.Services.ImageConverter.SaveToFIle(newBitmap, PathToImage, (int)threds);
        }
    }
}
