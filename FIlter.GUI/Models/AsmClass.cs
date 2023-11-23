using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using Filter.GUI.Models.Interfaces;
using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace FIlter.GUI.Models
{

    internal class AsmClass : IClass
    {
        private byte[] bytes;
        private byte[] returnBytes;
        private long startPoint;
        private long endPoint;

        
        [DllImport("C:\\PRJs\\ASM_PRJs\\Filter\\x64\\Debug\\Assembly.dll")]
        public static extern void filter(byte[] p, long sp, long ep, byte[] r);
        
        public AsmClass(ref byte[] obraz, long sp, long ep, ref byte[] returnImage)
        {
            bytes = obraz;
            startPoint = sp;
            endPoint = ep;
            returnBytes = returnImage;
        }
        public void Execute()
        {
                filter(bytes, startPoint, endPoint, returnBytes);
        }
    }
}

