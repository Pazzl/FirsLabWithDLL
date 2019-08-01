using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLib
{
    public class SearchDll
    {
        public static void FindMinElementWithPosition(int[] arr, out int minElement, out int minPos)
        {
            minElement = arr[0];
            minPos = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (minElement > arr[i])
                {
                    minElement = arr[i];
                    minPos = i;
                }
            }
        }

        public static void FindMaxElementWithPosition(int[] arr, out int maxElement, out int maxPos)
        {
            maxElement = arr[0];
            maxPos = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxElement < arr[i])
                {
                    maxElement = arr[i];
                    maxPos = i;
                }
            }
        }

    }
}
