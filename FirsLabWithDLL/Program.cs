using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOLib;
using SearchLib;

namespace FirsLabWithDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxElement, maxPosition;
            int minElement, minPosition;

            int[] intArray = IODll.GetIntArrayFromKeyboard();
            SearchDll.FindMaxElementWithPosition(intArray, out maxElement, out maxPosition);
            SearchDll.FindMinElementWithPosition(intArray, out minElement, out minPosition);

            String maxInfoStr = String.Format("Maximum value is {0}, and index of maximum value is {1}", maxElement, maxPosition);
            String minInfoStr = String.Format("Minimum value is {0}, and index of minimum value is {1}", minElement, minPosition);

            IODll.PrintInfoMessage(minInfoStr);
            IODll.PrintInfoMessage(maxInfoStr);

            Console.ReadKey();

        }
    }
}
