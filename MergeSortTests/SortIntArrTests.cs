using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipSort;

namespace MergeSortTests
{
    [TestFixture]
    public class SortIntArrTests
    {
        [TestCase(null)]
        public void Sort_ArgumentNullException(int[] arr)
        {
            Assert.Throws<ArgumentNullException>(() => SortIntArr.Sort(arr));
        }


        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 1 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[0], ExpectedResult = new int[0])]
        [TestCase(new int[] { 39, 18, -5, 19, 44, 19, -5, -7, 15 }, ExpectedResult = new int[] { -7, -5, -5, 15, 18, 19, 19, 39, 44 })]
        public int[] Sort_PositiveTest(int[] arr)
        {
            return SortIntArr.Sort(arr);
        }
    }
}
