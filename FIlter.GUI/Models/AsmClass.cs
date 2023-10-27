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
using Filter.GUI.Models.Interfaces;

namespace FIlter.GUI.Models
{
    internal class AsmClass : IClass
    {
        private byte[] bytes;
        private long startPoint;
        private long endPoint;

        [DllImport("C:\\PRJs\\ASM_PRJs\\FIlter.GuiAndAssembler\\x64\\Debug\\Assembly.dll")]
        private static extern ulong averageRGB(ref byte[] bytes, long sp, long ep);

        public AsmClass(ref byte[] obraz, long sp, long ep)
        {
            bytes = obraz;
            startPoint = sp;
            endPoint = ep;
        }
        public void Execute()
        {
            averageRGB(ref bytes, startPoint, endPoint);
        }
    }
}

