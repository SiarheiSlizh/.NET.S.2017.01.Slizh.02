using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipSort;

namespace TestingSlipSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, -4, 5, 9, 10, 3, 5, -7, -14, 9 };
            arr = SortIntArr.Sort(arr);
            foreach (int el in arr)
                Console.Write(el + " ");
            Console.WriteLine();
        }
    }
}
