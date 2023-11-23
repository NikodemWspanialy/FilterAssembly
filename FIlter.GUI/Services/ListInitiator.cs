using Filter.GUI.Enum;
using Filter.GUI.Models;
using Filter.GUI.Models.Interfaces;
using FIlter.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.GUI.Services
{
    internal class ListInitiator
    {
        public static List<IClass> InitFuncsList(Lenguage lenguage, uint threadNumber, ref byte[] image, ref byte[] returnImage)
        {
            List<IClass> newList = new List<IClass>();
            if(threadNumber == 1)
            {
                switch (lenguage)
                {
                    case Lenguage.ASM:
                        newList.Add(new AsmClass(ref image, 0, image.Length,ref returnImage));
                        break;
                    case Lenguage.CS:
                        newList.Add(new HighLvlClass(ref image, 0, image.Length, ref returnImage));
                        break;
                    default:
                        break;
                }
                return newList;
            }
            long ave = image.Length / threadNumber;
            while(ave % 3 == 0)
            {
                --ave;
            }
            long currentPoint = 0;
            long endPoint = image.Length;

            for (int i = 0; i < threadNumber - 1; ++i)
            {
                switch (lenguage)
                {
                    case Lenguage.ASM:
                        newList.Add(new AsmClass(ref image, currentPoint, currentPoint + ave, ref returnImage));
                        currentPoint += ave;
                        break;
                    case Lenguage.CS:
                        newList.Add(new HighLvlClass(ref image, currentPoint, currentPoint + ave, ref returnImage));
                        currentPoint += ave;
                        break;
                    default:
                        break;
                }
            }
            switch (lenguage)
            {
                case Lenguage.ASM:
                    newList.Add(new AsmClass(ref image, currentPoint, endPoint, ref returnImage));
                    break;
                case Lenguage.CS:
                    newList.Add(new HighLvlClass(ref image, currentPoint, endPoint, ref returnImage));
                    break;
                default:
                    break;
            }

            return newList;
        }
    }
}
