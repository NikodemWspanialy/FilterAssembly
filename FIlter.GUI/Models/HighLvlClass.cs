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

        private uint ThreadNumber;
        List<Thread> threads;
        private byte[] bytes;
        public HighLvlClass(ref byte[] obraz, uint tn)
        {
            bytes = obraz;
            ThreadNumber = tn;
            threads = new List<Thread>();
        }
        public void Execute()
        {
            if (ThreadNumber == 1)
            {
                HighLevelFilter filter = new HighLevelFilter(ref bytes);
                filter.filter();
            }
            long ave = bytes.Length / ThreadNumber;
            long current = 0, end = bytes.Length;
            for (int i = 0; i < ThreadNumber; ++i)
            {
                if (i + 1 == ThreadNumber)
                {
                    HighLevelFilter some = new HighLevelFilter(ref bytes, current, end);
                    threads.Add(new Thread(new ThreadStart(some.filter)));
                    threads[i].Start();

                }
                else
                {
                    HighLevelFilter hlf = new HighLevelFilter(ref bytes, current, current + ave);
                    threads.Add(new Thread(new ThreadStart(hlf.filter)));
                    threads[i].Start();
                    current += ave;
                }

            }
        }
    }
}
