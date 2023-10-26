using FIlter.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.GUI.Models
{
    internal class HighLvlClass : IClass
    {

        private int startPoint;
        private int endPoint;
        private byte[,] bytes;
        public HighLvlClass(byte[,] obraz, int sp, int ep)
        {
            bytes = obraz;
            startPoint = sp;
            endPoint = ep;
        }
        public void Execute()
        {
        //    HighLevel.HighLevelFilter.filter();
        }
    }
}
