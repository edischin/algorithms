using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MergeSort.Test
{
    [TestClass]
    public class MergeSortUnitTest
    {
        [TestMethod]
        public void TestUnorderedSmallOddSizedList()
        {
            var inputA = new int[] { 1,6,3,5,4,2,9,7,8 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 1,2,3,4,5,6,7,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestOrderedSmallOddSizedList()
        {
            var inputA = new int[] { 1,2,3,4,5,6,7,8,9 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 1,2,3,4,5,6,7,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestUnorderedSmallEvenSizedList()
        {
            var inputA = new int[] { 1,6,3,5,4,2,9,7,8,0 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 0,1,2,3,4,5,6,7,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestOrderedSmallEvenSizedList()
        {
            var inputA = new int[] { 0,1,2,3,4,5,6,7,8,9 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 0,1,2,3,4,5,6,7,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestUnorderedSmallListWithRepeatedValues()
        {
            var inputA = new int[] { 1,6,3,6,5,4,2,9,1,7,8,8 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 1,1,2,3,4,5,6,6,7,8,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestOrderedSmallListWithRepeatedValues()
        {
            var inputA = new int[] { 1,1,2,3,4,5,6,6,7,8,8,9 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 1,1,2,3,4,5,6,6,7,8,8,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestUnorderedBigList()
        {
            var inputA = new int[] { 42,50,25,4,6,7,8,5,9,10,11,12,29,14,34,16,17,18,19,45,21,22,23,
                24,3,26,13,28,27,1,31,32,33,15,35,36,37,38,39,40,44,30,43,41,20,48,47,46,49,2 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,
                23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestListWithTwoValues()
        {
            var inputA = new int[] { 9,4 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 4,9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestListWithOneValue()
        {
            var inputA = new int[] { 9 };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { 9 };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestListWithNoValue()
        {
            var inputA = new int[] { };
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }

        [TestMethod]
        public void TestNullList()
        {
            int[] inputA = null;
            var outputB = MergeSort.Lib.MergeSortFuncs.MergeSortArray(inputA);
            var expectedOutput = new int[] { };

            Assert.AreEqual(string.Join(',', expectedOutput), string.Join(',', outputB));
        }
    }
}
