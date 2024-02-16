namespace TestProject1;
using MyMath;
using NUnit.Framework;
using System;


    public class Tests
    {
        private Rooter rooter;

        [SetUp]
        public void Setup()
        {
            rooter = new Rooter();
        }

        [Test]
        public void RooterTestNegativeInput()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-10), "Expected ArgumentOutOfRangeException for negative input not thrown.");
        }

        [Test]
        public void BasicRooterTest()
        {
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [Test]
        public void RooterValueRange()
        {
            for (double expectedResult = 1e-8; expectedResult < 1e+8; expectedResult *= 3.2)
            {
                RooterOneValue(rooter, expectedResult);
            }
        }

        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }
    }


