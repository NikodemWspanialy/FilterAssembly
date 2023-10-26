using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HighLevel;
using System.Threading;
using System.Security.Cryptography;

namespace FIlter.GUI.Models
{
    internal class AsmClass : IClass
    {
        private uint ThreadNumber;
        List<Thread> threads;
        private byte[] bytes;
        [DllImport("C:\\PRJs\\ASM_PRJs\\FIlter.GuiAndAssembler\\x64\\Debug\\Assembly.dll")]
        private static extern ulong averageRGB(ref byte[] bytes, long RCX, long RDX);

        private int startPoint;
        private int endPoint;
        public AsmClass(int obraz, int sp, int ep)
        {
            startPoint = sp;
            endPoint = ep;
        }
        public void Execute()
        {
            if (ThreadNumber == 1)
            {
                averageRGB(ref bytes, 0, bytes.Length);
            }
            long ave = bytes.Length / ThreadNumber;
            long current = 0, end = bytes.Length;
            for (int i = 0; i < ThreadNumber; ++i)
            {
                if (i + 1 == ThreadNumber)
                {
                    //watek do konca aby nie tracic nic es
                }
                else
                {
                    current += ave;
                }
            }
        //ulong arg1 = 2;
        //ulong arg2 = 5;
        //ulong result = averageRGB(arg1, arg2);
        //MessageBox.Show("wynik dodawnia " + arg1.ToString() + " + " + arg2.ToString() + " = " + result.ToString(), "Assembly result", MessageBoxButtons.OK);
        }
    }
}

