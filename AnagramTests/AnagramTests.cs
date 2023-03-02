using System;
using Anagram;


namespace AnagramTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReverseWord()
        {
            // arrange
            string word = "Test";
            string expectedResult = "tseT";
            ReverseString test1 = new ReverseString();

            // act
            string actualResult = test1.Reverse(word);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseSymbolsOnly()
        {
            // arrange
            string symbols = "$&*__%";
            string expectedResult = "$&*__%";
            ReverseString test2 = new ReverseString();

            // act
            string actualResult = test2.Reverse(symbols);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseNumbersOnly()
        {
            // arrange
            string number = "12345";
            string expectedResult = "12345";
            ReverseString test3 = new ReverseString();

            // act
            string actualResult = test3.Reverse(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseSpacesOnly()
        {
            // arrange
            string spaces = "     ";
            string expectedResult = "     ";
            ReverseString test4 = new ReverseString();

            // act
            string actualResult = test4.Reverse(spaces);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseNumbersAndSpaces()
        {
            // arrange
            string spaces = "   2  3  97  2 ";
            string expectedResult = "   2  3  97  2 ";
            ReverseString test5 = new ReverseString();

            // act
            string actualResult = test5.Reverse(spaces);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseSymbolsAndSpaces()
        {
            // arrange
            string spaces = "__ $%  @@ # ";
            string expectedResult = "__ $%  @@ # ";
            ReverseString test6 = new ReverseString();

            // act
            string actualResult = test6.Reverse(spaces);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseStringTest1()
        {
            // arrange
            string randomString = "  a1bcd    efg!h";
            string expectedResult = "  d1cba    hgf!e";
            ReverseString test7 = new ReverseString();

            // act 
            string actualResult = test7.Reverse(randomString);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseStringTest2()
        {
            // arrange
            string randomString = "  a1bcd    efg!h   ";
            string expectedResult = "  d1cba    hgf!e   ";
            ReverseString test8 = new ReverseString();

            // act 
            string actualResult = test8.Reverse(randomString);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReverseNull()
        {
            //arrange
            string isNull = null;
            ReverseString test9 = new ReverseString();

            // act
            string actualResult = test9.Reverse(isNull);

            // assert
            Assert.AreEqual(null, actualResult);
        }
    }
}