using System.Web.Mvc;
using NUnit.Framework;
using Web.Services;
using System.Linq;



namespace Web.Tests
{
    [TestFixture]
    public class FibonacciServiceTests
    {
        [Test]
        public void GenerateFibonacciSequence_NegativeInput_ReturnsEmptySequence()
        {
            //arrange
            var fibonnaciObject = new FibonacciService();

            //act
            var actual = fibonnaciObject.GenerateFibonacciSequence(-2).ToList();

            //assert
            Assert.AreEqual(0, actual.Count);
            
        }
        [Test]
        public void GenerateFibonacciSequence_LargeInputCausesOverflow_ReturnsEmptySequence()
        {
            //arrange
            var fibonnaciObject = new FibonacciService();

            //act
            var actual = fibonnaciObject.GenerateFibonacciSequence(int.MaxValue).ToList();

            //assert
            Assert.AreEqual(0, actual.Count);
        }

        [Test]
        public void GenerateFibonacciSequence_Input5_Returns6Numbers()
        {
            //arrange
            var fibonnaciObject = new FibonacciService();

            //act
            var actual = fibonnaciObject.GenerateFibonacciSequence(5).ToList();

            //assert
            Assert.AreEqual(6, actual.Count);
        }
    }
}