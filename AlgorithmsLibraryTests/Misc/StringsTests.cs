// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using System.Collections;
using AlgorithmsLibrary.Misc;
using NUnit.Framework;

namespace AlgorithmsLibraryTests.Misc
{
    public class StringsTests
    {

        [Test]
        public void TestFindStringPermutations1()
        {
            var expected = new int[] { 0, 2, 8, 9, 19, 24 };
            const string str = "ZXYXZTFRXYZXZTREACBXZYPOXYZ";
            const string src = "XYZ";

            var result = Strings.FindStringPermutations1(str, src).ToArray();
            Assert.AreEqual(expected, result);

            var a = new Hashtable();
            

        }



    }
}
