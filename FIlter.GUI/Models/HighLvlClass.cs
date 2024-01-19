using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharp;
using FIlter.GUI;
using Filter.GUI.Models.Interfaces;

namespace Filter.GUI.Models
{
    internal class HighLvlClass : IClass
    {
        private float[] bytes;
        private float[] returnBytes;
        private long startPoint;
        private long endPoint;
        public HighLvlClass(ref float[] obraz, long sp, long ep, ref float[] returnImage)
        {
            bytes = obraz;
            startPoint = sp;
            endPoint = ep;
            returnBytes = returnImage;
        }
        public void Execute()
        {
            CSharp.Filter.filter(ref bytes, startPoint, endPoint, ref returnBytes);
        }
    }
}