// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using AlgorithmsLibrary;
using NUnit.Framework;

namespace AlgorithmsLibraryTests.Arrays
{
    public class ArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLinearSearch()
        {
            var array = new int[] { 1, 2, 2, 5, 3, 4 };
            var result = AlgorithmsLibrary.Arrays.LinearSearch(array, 5);

        }


    }
}
