using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Xunit.Abstractions;

namespace AlgorithmsAndDatastructures.UnitTest
{

    public class SortingTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public SortingTests(ITestOutputHelper testOutoutHelper)
        {
            _testOutputHelper = testOutoutHelper;
        }
        [Fact]
        public void BubbleSort_WhenGivenValidInput_SortsTheInput()
        {
            RunTestsForSortingAlgorithm(Sorting.BubbleSort);
        }

        private void RunTestsForSortingAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {

            _testOutputHelper.WriteLine("----------TRACE----------\n");

            foreach (var el in array)
            {
                _testOutputHelper.WriteLine(el + " ");
            }

            _testOutputHelper.WriteLine("\n-------------------------\n");             
        }

        private int[][] Samples()
        {
            int[][] samples = new int[5][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2,1 };
            samples[2] = new[] { 3,-1,5,8,2,9 };
            samples[3] = new[] { 3,1,-9,7,8,4,3,2,6 };
            samples[4] = new[] { 8, 2, 9, 1, -9, 7,-4,5 };

            return samples;
        }
    }
}
