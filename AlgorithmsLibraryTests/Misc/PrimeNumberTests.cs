// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace AlgorithmsLibraryTests.Misc
{
    public class PrimeNumberTests
    {
        const int num1 = 49;
        const int num2 = 47;
        const int num3 = 43;
        static int num4 = 2_147_483_647;


        [Test]
        public void TestAlg1()
        {
            Assert.IsFalse(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime1(num1));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime1(num2));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime1(num3));
        }

        [Test]
        public void TestAlg2()
        {
            Assert.IsFalse(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime2(num1));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime2(num2));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime2(num3));
        }

        [Test]
        public void TestAlg3()
        {
            Assert.IsFalse(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime3(num1));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime3(num2));
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime3(num3));
        }

        [Test]
        public void TestAlg4()
        {
            Assert.IsTrue(AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime3(num4));
        }

        [Test]
        public void TestAlg5()
        {
            var cases = new Dictionary<int, bool> {
               { 1       ,false               } ,
               { 4       ,false               } ,
               { 9       ,false               } ,
               { 16      ,false               } ,
               { 25      ,false               } ,
               { 36      ,false               } ,
               { 49      ,false               } ,
               { 64      ,false               } ,
               { 81      ,false               } ,
               { 100     ,false               } ,
               { 121     ,false               } ,
               { 144     ,false               } ,
               { 169     ,false               } ,
               { 196     ,false               } ,
               { 225     ,false               } ,
               { 256     ,false               } ,
               { 289     ,false               } ,
               { 324     ,false               } ,
               { 361     ,false               } ,
               { 400     ,false               } ,
               { 441     ,false               } ,
               { 484     ,false               } ,
               { 529     ,false               } ,
               { 576     ,false               } ,
               { 625     ,false               } ,
               { 676     ,false               } ,
               { 729     ,false               } ,
               { 784     ,false               } ,
               { 841     ,false               } ,
               { 907     ,true }
            };

            foreach (var kvp in cases)
            {
                Console.WriteLine($"{kvp.Key} => {AlgorithmsLibrary.Misc.PrimeNumbers.IsPrime2(kvp.Key)}");
            }
            Assert.Pass();
        }

    }
}
