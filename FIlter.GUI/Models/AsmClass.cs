using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FIlter.GUI.Models
{
    internal class AsmClass : IClass
    {
        [DllImport("C:\\PRJs\\ASM_PRJs\\FIlter.GuiAndAssembler\\x64\\Debug\\Assembly.dll")]
        private static extern ulong averageRGB(ulong RCX, ulong RDX);

        private int startPoint;
        private int endPoint;
        public AsmClass(int obraz, int sp, int ep)
        {
            startPoint = sp;
            endPoint = ep;
        }
        public void Execute()
        {
            ulong arg1 = 2;
            ulong arg2 = 5;
            ulong result = averageRGB(arg1, arg2);
            MessageBox.Show("wynik dodawnia " + arg1.ToString() + " + " + arg2.ToString() + " = " + result.ToString(), "Assembly result", MessageBoxButtons.OK);
        }
    }
}
