using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Bandaruk._01
{
    /// <summary>
    /// Class contains methods for  quick sorting 
    /// </summary>
    class QuickSort
    {
        /// <summary>
        /// The array is recursively divided into subarrays right and left around middleIndex
        /// </summary>
        /// <param name="arr">Source array</param>
        /// <param name="startIndex">The zero-based position of the start of block part to be sorted</param>
        /// <param name="endIndex">The zero-based position of the end of block part to be sorted</param>
        public static void QuickSorting(int[] arr, int startIndex, int endIndex)
        {
            
                {
                    if (startIndex >= endIndex)
                    {
                        return;
                    }
                    int middleIndex = startIndex + (endIndex - startIndex) / 2;
                    middleIndex = OrderItemsAroundMiddle(arr, startIndex, middleIndex, endIndex);
                    QuickSorting(arr, startIndex, middleIndex - 1);
                    QuickSorting(arr, middleIndex + 1, endIndex);
                }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">Array for sorting</param>
        /// <param name="leftStart">First index of the first array</param>
        /// <param name="middelLocation">Last index of the first array</param>
        /// <param name="rightEnd">Last index of the second array</param>
        /// <returns></returns>
        public static int OrderItemsAroundMiddle(int[] arr, int leftStart, int middelLocation, int rightEnd)
        {
            int middle = arr[middelLocation];
            SwapValues(arr, middelLocation, rightEnd);
            var leftIndex = leftStart;
            var rightIndex = rightEnd - 1;
            while (leftIndex <= rightIndex)
            {
                if (arr[leftIndex] <= middle)
                {
                    leftIndex++;
                    continue;
                }

                if (arr[rightIndex] >= middle)
                {
                    rightIndex--;
                    continue;
                }
                SwapValues(arr, leftIndex, rightIndex);
            }
            SwapValues(arr, rightEnd, leftIndex);
            return leftIndex;
        }
        /// <summary>
        /// method for the exchange of arguments
        /// </summary>
        /// <param name="arr">Array consisting of elements for exchanging places</param>
        /// <param name="firstElementToSwap">First element for exchanging</param>
        /// <param name="secondElementToSwap">Seond element for exchanging</param>
        public static void SwapValues(int[] arr, int firstElementToSwap, int secondElementToSwap)
        {
            int temp = arr[firstElementToSwap];
            arr[firstElementToSwap] = arr[secondElementToSwap];
            arr[secondElementToSwap] = temp;
        }
    }
}
