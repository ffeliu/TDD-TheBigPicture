using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzzService;

        public FizzBuzzTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("1", _fizzBuzzService.Print(1));
        }

        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Print(3));
        }        

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", _fizzBuzzService.Print(5));
        }    

        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Print(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Print(30));
        }               
    }
}
