using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public class PrimeNumberTest
    {
        public static void InputCheckReturnsAnInt()
        {
            bool expected = true;
            bool actual = InputCheck();
            Assert.AreEqual(expected, actual, "Input is not a calculable number");
        }

        public static void PrimeReturnsCorrect()
        {
            int expected = 29;
            int actual = PrimeNumber.PrimeNumberCount(10);
            Assert.AreEqual(expected, actual, "not sure what to write.");
        }
    }
}
