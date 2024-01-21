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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIlter.GUI.Models
{

    internal class AsmClass : IClass
    {
        private float[] bytes;
        private float[] returnBytes;
        private long startPoint;
        private long endPoint;

        [DllImport(@"C:\PRJs\ASM_PRJs\gh\Assembly\x64\Release\Assembly.dll")]
        public static extern void filter(float[] p, long sp, long ep, float[] r);

        public AsmClass(ref float[] obraz, long sp, long ep, ref float[] returnImage)
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

