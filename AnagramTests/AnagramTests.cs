using System;
using Anagram;


namespace AnagramTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReverseWordTest()
        {
            // arrange
            string randomWord = "Test";
            string expectedResult = "tseT";
            ReverseString test1 = new ReverseString();

            // act
            string actualResult = test1.ReverseWord(randomWord);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            // arrange
            string randomText = "  a1bcd    efg!h";
            string expectedResult = "  d1cba    hgf!e";
            ReverseString test2 = new ReverseString();

            // act 
            string actualResult = test2.Reverse(randomText);

            // assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void ReverseNull()
        {
            //arrange
            string isNull = null;
            ReverseString test3 = new ReverseString();

            // act
            string actualResult = test3.Reverse(isNull);

            // assert
            Assert.AreEqual(null, actualResult);
        }
    }
}