namespace Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services;

    [TestClass]
    public class FibonacciTests
    {
        private const int FIB3 = 2;
        private const int FIB4 = 3;
        private const int FIB5 = 5;
        private const int FIB6 = 8;
        private const int FIB_101 = -1;
        private const int FIB1000 = -1;

        [TestMethod]
        public void Fib3()
        {
            Assert.AreEqual(FIB3, FibonacciService.Compute(3));
        }

        [TestMethod]
        public void Fib4()
        {
            Assert.AreEqual(FIB4, FibonacciService.Compute(4));
        }

        [TestMethod]
        public void Fib5()
        {
            Assert.AreEqual(FIB5, FibonacciService.Compute(5));
        }

        [TestMethod]
        public void Fib6()
        {
            Assert.AreEqual(FIB6, FibonacciService.Compute(6));
        }

        [TestMethod]
        public void Fib101()
        {
            Assert.AreEqual(FIB_101, FibonacciService.Compute(-101));
        }

        [TestMethod]
        public void Fib1000()
        {
            Assert.AreEqual(FIB1000, FibonacciService.Compute(1000));
        }
    }
}
