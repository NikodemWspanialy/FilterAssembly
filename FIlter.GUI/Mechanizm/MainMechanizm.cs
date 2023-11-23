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
using Filter.GUI.Services;

namespace Filter.GUI.Mechanizm
{

    internal class MainMechanizm
    {
        private uint threds;
        private readonly Lenguage lenguage;
        private byte[] Image;
        private byte[] returnImage;
        //potrzebne do konwerski powrotnej
        private int WidthNumber;
        //path to image
        private string PathToImage = string.Empty;
        //part 2
        List<IClass> funcs = new List<IClass>();
        List<Thread> threads = new List<Thread>();
        public MainMechanizm(Lenguage lenguage)
        {
            this.lenguage = lenguage;
        }
        public bool SetThreds(uint arg)
        {
            try
            {
                threds = arg;
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool SetImage(string file)
        {
            try
            {

                PathToImage = file;
                Bitmap oldBitmap = Filter.GUI.Services.ImageConverter.GetBitMap(PathToImage);
                WidthNumber = oldBitmap.Width;
                Image = Filter.GUI.Services.ImageConverter.ConvertToByteArray(oldBitmap);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public TimeSpan run()
        {
            returnImage = new byte[Image.Length];
            switch (lenguage)
            {
                case Lenguage.CS:
                    funcs = ListInitiator.InitFuncsList(Lenguage.CS, threds, ref Image, ref returnImage);
                    break;
                case Lenguage.ASM:
                    funcs = ListInitiator.InitFuncsList(Lenguage.ASM, threds, ref Image, ref returnImage);
                    break;
                default:
                    break;
            }
            DateTime timeBefore = DateTime.Now;
            foreach (var f in funcs) { threads.Add(new Thread(new ThreadStart(f.Execute))); }
            foreach (var t in threads) { t.Start(); }
            foreach (var t in 
                threads)
            {
                t.Join();
                //tu mozna progress bara wywolywac :DD
            }
            DateTime timeAfter = DateTime.Now;
            Bitmap newBitmap = Services.ImageConverter.ConvertToBitmap(returnImage, WidthNumber);
            Services.ImageConverter.SaveToFIle(newBitmap, PathToImage, (int)threds);
            return timeAfter.Subtract(timeBefore);
        }
    }
}
