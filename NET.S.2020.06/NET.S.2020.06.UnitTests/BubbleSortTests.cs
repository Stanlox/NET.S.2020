using NET.S._2020._06;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        readonly int[][] input =
          {
                new int[] {1,2,3,4,5,6},
                new int[] {2,6,1,3},
                new int[] {5,2,8,2,7},
                new int[] {3,5},
         };

        [Test]
        public void AscendingSortSumElementsJaggedArrayReturnsSwapArrays()
        {

            int[][] expectedResult =
            {
                new int[]{3,5},
                new int[]{2,6,1,3},
                new int[]{1,2,3,4,5,6},
                new int[]{5,2,8,2,7},
            };

            var getResult = BubbleSort.AscendingSortSumElements(input);
            Assert.AreEqual(getResult, expectedResult);
        }

        [Test]
        public void DescendingSortSumElementsJaggedArrayReturnsSwapArrays()
        {
            int[][] expectedResult =
            {
                new int[] {5,2,8,2,7},
                new int[] {1,2,3,4,5,6},
                new int[] {2,6,1,3},
                new int[] {3,5},
            };

            var getResult = BubbleSort.DescendingSortSumElements(input);

            Assert.AreEqual(getResult, expectedResult);
        }

        [Test]
        public void AscendingSortMaxElementsJaggedArrayReturnsSwapArrays()
        {
            int[][] expectedResult =
            {
                new int[] {3,5},
                new int[] {2,6,1,3},
                new int[] {1,2,3,4,5,6},
                new int[] {5,2,8,2,7},
            };
            var getResult = BubbleSort.AscendingSortMaxElements(input);
            Assert.AreEqual(getResult, expectedResult);
        }

        [Test]
        public void DescendingSortMaxElementsJaggedArrayReturnsSwapArrays()
        {
            int[][] expectedResult =
            {
                new int[] {5,2,8,2,7},
                new int[] {1,2,3,4,5,6},
                new int[] {2,6,1,3},
                new int[] {3,5},
            };

            var getResult = BubbleSort.DescendingSortMaxElements(input);
            Assert.AreEqual(getResult, expectedResult);
        }

        [Test]
        public void AscendingSortMinElementsJaggedArrayReturnsSwapArrays()
        {
            int[][] expectedResult =
            {
                new int[] {2,6,1,3},
                new int[] {1,2,3,4,5,6},
                new int[] {5,2,8,2,7},
                new int[] {3,5},
            };

            int[][] getResult = BubbleSort.AscendingSortMinElements(input);
            Assert.AreEqual(getResult, expectedResult);
        }

        [Test]
        public void DescendingSortMinElementsJaggedArrayReturnsSwapArrays()
        {
            int[][] expectedResult =
            {
                new int[] {3,5},
                new int[] {5,2,8,2,7},
                new int[] {2,6,1,3},
                new int[] {1,2,3,4,5,6},
            };

            var getResult = BubbleSort.DescendingSortMinElements(input);
            Assert.AreEqual(getResult, expectedResult);
            
        }


    }
}