using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipSort
{

    /// <summary>  
    /// This class is intended for array sorting.
    /// </summary>  
    public class SortIntArr
    {
        #region MergeSort
        /// <summary>
        /// This method divides array into two parts recursively until their sizes are two or one.
        /// </summary>
        /// <param name="arr">Array which is sorted by Merge sort.</param>

        public static int[] Sort(int[] arr)
        {
            if (Equals(arr, null))
                throw new ArgumentNullException();

            if (arr.Length < 2) return arr;
            if (arr.Length == 2)
            {
                Array.Sort(arr);
                return arr;
            }

            int midle = (arr.Length - 1) / 2;
            int[] leftArr = new int[midle + 1];
            int[] rightArr = new int[arr.Length - midle - 1];

            for (int i = 0; i < leftArr.Length; i++)
                leftArr[i] = arr[i];
            for (int i = 0; i < rightArr.Length; i++)
                rightArr[i] = arr[i + midle + 1];

            leftArr = Sort(leftArr);
            rightArr = Sort(rightArr);

            return MergeSort(leftArr, rightArr);
        }

        /// <summary>
        /// This method sorts two arrays into another one by merge sort.
        /// </summary>
        /// <param name="leftArr">First part of array.</param>
        /// <param name="rightArr">Second part of array.</param>
        /// <returns>New sort array</returns>

        static int[] MergeSort(int[] leftArr, int[] rightArr)
        {
            int[] arr = new int[leftArr.Length + rightArr.Length];

            int i, iLeft, iRight;
            i = iLeft = iRight = 0;

            while (iLeft != leftArr.Length && iRight != rightArr.Length)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                    arr[i++] = leftArr[iLeft++];
                else arr[i++] = rightArr[iRight++];
            }
            while (iLeft != leftArr.Length)
                arr[i++] = leftArr[iLeft++];
            while (iRight != rightArr.Length)
                arr[i++] = rightArr[iRight++];

            return arr;
        }
        #endregion
    }
}