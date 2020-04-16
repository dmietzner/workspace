using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz KataFizzBuzz;
        [TestInitialize]
        public void Initialize()
        {
            KataFizzBuzz = new KataFizzBuzz();
        }
        [TestMethod]
        public void Fizz_Buzz_3()
        {
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(9));
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(12));
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(33));
        }
        [TestMethod]
        public void Fizz_Buzz_5()
        {
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(20));
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(25));
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(40));
        }
        [TestMethod]
        public void Fizz_Buzz_15()
        {
            Assert.AreEqual("FizzBuzz", KataFizzBuzz.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", KataFizzBuzz.FizzBuzz(45));
            Assert.AreEqual("FizzBuzz", KataFizzBuzz.FizzBuzz(60));
        }
        [TestMethod]
        public void Fizz_Buzz_Over_Under100()
        {
            Assert.AreEqual("", KataFizzBuzz.FizzBuzz(109));
            Assert.AreEqual("", KataFizzBuzz.FizzBuzz(101));
            Assert.AreEqual("", KataFizzBuzz.FizzBuzz(-1));
        }
        [TestMethod]
        public void Fizz_Buzz_Over_Between_1_100()
        {
            Assert.AreEqual("88", KataFizzBuzz.FizzBuzz(88));
            Assert.AreEqual("77", KataFizzBuzz.FizzBuzz(77));
            Assert.AreEqual("2", KataFizzBuzz.FizzBuzz(2));
        }
        [TestMethod]
        public void Fizz_Buzz_Contains_3()
        {
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(13));
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(23));
            Assert.AreEqual("Fizz", KataFizzBuzz.FizzBuzz(32));
        }
        [TestMethod]
        public void Fizz_Buzz_Over_Contains()
        {
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(55));
            // 57 is divisible by 3 but also contains a '5'. Should we
            // print "Fizz" or "Buzz"? I am going to assume "Buzz" Seems like regardless of which order I set my muliple of 3 or 5 it seems to have an exception.
            Assert.AreEqual("Buzz", KataFizzBuzz.FizzBuzz(57));

        }
        [TestMethod]
        public void Fizz_Buzz_Over_Contains5_3()
        {
            Assert.AreEqual("FizzBuzz", KataFizzBuzz.FizzBuzz(35));
            Assert.AreEqual("FizzBuzz", KataFizzBuzz.FizzBuzz(53));
        }
    }
}
