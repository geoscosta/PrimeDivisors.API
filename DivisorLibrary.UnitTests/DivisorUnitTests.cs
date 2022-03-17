using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivisorLibrary;
using System.Collections.Generic;
using System.Text.Json;

namespace DivisorLibrary.UnitTests
{
    [TestClass]
    public class DivisorUnitTests
    {

        [TestMethod]
        public void GetPrimesAndDivisorsNumbers_EnterNumberIsPositiveAndGreaterThanOne_DivisorsAreGreaterThanZero()
        {
            var EntryNumber = new DivisorParameter { EntryNumber = 2 };

            var result = Divisor.GetPrimesAndDivisorsNumbers(EntryNumber);

            Assert.IsTrue(result.Divisors.Count > 0);
        }

        [TestMethod]
        public void GetPrimesAndDivisorsNumbers_EnterNumberIsPositiveAndGreaterThanOne_PrimesAreGreaterThanZero()
        {
            var EntryNumber = new DivisorParameter { EntryNumber = 2 };

            var result = Divisor.GetPrimesAndDivisorsNumbers(EntryNumber);

            Assert.IsTrue(result.Primes.Count > 0);
        }

        [TestMethod]
        public void GetPrimesAndDivisorsNumbers_EnterNumberIsNegative_DivisorIsEmpty()
        {
            var EntryNumber = new DivisorParameter { EntryNumber = -1 };

            var result = Divisor.GetPrimesAndDivisorsNumbers(EntryNumber);

            Assert.AreEqual(0, result.Primes.Count);
        }

        [TestMethod]
        public void GetPrimesAndDivisorsNumbers_EnterNumberIsNegative_PrimeIsEmpty()
        {
            var EntryNumber = new DivisorParameter { EntryNumber = -1 };

            var result = Divisor.GetPrimesAndDivisorsNumbers(EntryNumber);

            Assert.AreEqual(0, result.Divisors.Count);
        }

        [TestMethod]
        public void GetPrimesAndDivisorsNumbers_EnterNumberIs45_DivisorsAndPrimesResultAreEqual()
        {
            var expectedParameter = new DivisorParameter
            (
                45,
                new List<int> { 1, 3, 5, 9, 15, 45 },
                new List<int> { 3, 5 }
            );
            var expectedJson = JsonSerializer.Serialize(expectedParameter);

            var result = Divisor.GetPrimesAndDivisorsNumbers(new DivisorParameter { EntryNumber = 45 });

            Assert.AreEqual(expectedJson, JsonSerializer.Serialize(result));
        }
    }
}
