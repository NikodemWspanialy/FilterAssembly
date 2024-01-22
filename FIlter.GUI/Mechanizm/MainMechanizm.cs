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
using System.Diagnostics;

namespace Filter.GUI.Mechanizm
{

    internal class MainMechanizm
    {
        private uint threds;
        private readonly Lenguage lenguage;
        private float[] Image;
        private float[] returnImage;
        //potrzebne do konwerski powrotnej
        private int WidthNumber;
        //path to image
        private string PathToImage = string.Empty;
        public string? newImagePath { get; set; }
        //part 2
        List<IClass> funcs = new List<IClass>();
        List<Task> threads = new List<Task>();
        /// <summary>
        /// ctor 
        /// </summary>
        /// <param name="lenguage"> setting language</param>
        public MainMechanizm(Lenguage lenguage)
        {
            this.lenguage = lenguage;
        }
        /// <summary>
        /// setter for threads
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public bool SetThreds(uint arg)
        {
            try
            {
                threds = arg;
                return true;
            }
            catch (Exception ex) { return false; }
        }
        /// <summary>
        /// setter for image path, bitmap
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool SetImage(string file)
        {
            try
            {

                PathToImage = file;
                Bitmap oldBitmap = Filter.GUI.Services.ImageConverter.GetBitMap(PathToImage);
                WidthNumber = oldBitmap.Width;
                Image = Filter.GUI.Services.ImageConverter.ConvertToFloatArray(oldBitmap);
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        /// <summary>
        /// generating threads and starting them 
        /// </summary>
        /// <returns>time in ticks</returns>
        public Int64 run()
        {
            returnImage = new float[Image.Length];
            var stopwatch = new Stopwatch();
            stopwatch.Restart();
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

            foreach (var f in funcs) { threads.Add(new Task(() => f.Execute())); }

            {
                Parallel.ForEach(threads, (task) => task.Start());
                Task.WaitAll(threads.ToArray());
            }
            stopwatch.Stop();
            var ticks = stopwatch.ElapsedTicks;

            Bitmap newBitmap = Services.ImageConverter.ConvertToBitmap(returnImage, WidthNumber);
            newImagePath = Services.ImageConverter.SaveToFIle(newBitmap, PathToImage, (int)threds);

            return ticks;
        }
    }
}
