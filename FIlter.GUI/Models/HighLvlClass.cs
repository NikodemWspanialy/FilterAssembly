using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HighLevel;
using FIlter.GUI;
using Filter.GUI.Models.Interfaces;

namespace Filter.GUI.Models
{
    internal class HighLvlClass : IClass
    {
        private byte[] bytes;
        private byte[] returnBytes;
        private long startPoint;
        private long endPoint;   
        public HighLvlClass(ref byte[] obraz, long sp, long ep, ref byte[] returnImage)
        {
            bytes = obraz;
            startPoint= sp;
            endPoint= ep;
            returnBytes = returnImage;
        }
        public void Execute()
        {
            HighLevel.HighLevelFilter.filter(ref bytes, startPoint,endPoint, ref returnBytes);
        }
    }
}
