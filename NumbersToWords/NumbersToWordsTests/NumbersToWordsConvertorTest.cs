using NumbersToWords;
using NUnit.Framework;

namespace NumbersToWordsTests
{
    [TestFixture]
    public class NumbersToWordsConvertorTest
    {
        [TestCase(0,"zero")]
        [TestCase(1,"one")]
        [TestCase(2,"two")]
        [TestCase(3,"three")]
        [TestCase(4,"four")]
        [TestCase(5,"five")]
        [TestCase(6,"six")]
        [TestCase(7,"seven")]
        [TestCase(8,"eight")]
        [TestCase(9,"nine")]
        public void ConvertUnitsToWord_GivenUnits_ShouldReturnUnitsInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertUnitsToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        public void ConvertNumbersMoreThan10LessThan20_GivenNumbersMoreThan10LessThan20_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersMoreThan10LessThan20(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "ten")]
        [TestCase(20, "twenty")]
        [TestCase(30, "thirty")]
        [TestCase(40, "fourty")]
        [TestCase(50, "fifty")]
        [TestCase(60, "sixty")]
        [TestCase(70, "seventy")]
        [TestCase(80, "eighty")]
        [TestCase(90, "ninety")]
        public void ConvertTensToWords_GivenTens_ShouldReturnTensInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertTensToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "one hundred")]
        [TestCase(200, "two hundred")]
        [TestCase(300, "three hundred")]
        [TestCase(400, "four hundred")]
        [TestCase(500, "five hundred")]
        [TestCase(600, "six hundred")]
        [TestCase(700, "seven hundred")]
        [TestCase(800, "eight hundred")]
        [TestCase(900, "nine hundred")]
        public void ConvertHundredsToWords_GivenHundreds_ShouldReturnHundredsInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertHundredsToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(21, "twenty-one")]
        [TestCase(32, "thirty-two")]
        [TestCase(45, "fourty-five")]
        [TestCase(56, "fifty-six")]
        [TestCase(67, "sixty-seven")]
        [TestCase(73, "seventy-three")]
        [TestCase(89, "eighty-nine")]
        [TestCase(94, "ninety-four")]
        public void ConvertNumbersCombiningTensAndUnitsToWords_GivenNumbersCombiningTensAndUnits_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningTensAndUnitsToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101, "one hundred one")]
        [TestCase(203, "two hundred three")]
        [TestCase(303, "three hundred three")]
        [TestCase(405, "four hundred five")]
        [TestCase(507, "five hundred seven")]
        [TestCase(609, "six hundred nine")]
        [TestCase(702, "seven hundred two")]
        [TestCase(804, "eight hundred four")]
        [TestCase(906, "nine hundred six")]
        public void ConvertNumbersCombiningHundredsAndUnitsToWords_GivenNumbersCombiningHundredsAndUnits_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningHundredsAndUnitsToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(110, "one hundred ten")]
        [TestCase(220, "two hundred twenty")]
        [TestCase(330, "three hundred thirty")]
        [TestCase(450, "four hundred fifty")]
        [TestCase(560, "five hundred sixty")]
        [TestCase(670, "six hundred seventy")]
        [TestCase(720, "seven hundred twenty")]
        [TestCase(810, "eight hundred ten")]
        [TestCase(980, "nine hundred eighty")]
        public void ConvertNumbersCombiningHundredsAndTensToWords_GivenNumbersCombiningHundredsAndTens_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningHundredsAndTensToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(555, "five hundred fifty-five")]
        [TestCase(678, "six hundred seventy-eight")]
        [TestCase(834, "eight hundred thirty-four")]
        [TestCase(988, "nine hundred eighty-eight")]
        public void ConvertNumbersCombiningHundredsAndNumbersCombiningTensAndUnits_GivenNumbersCombiningHundredsAndNumbersCombiningTensAndUnits_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningHundredsAndNumbersCombiningTensAndUnits(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, "one thousand")]
        [TestCase(2000, "two thousand")]
        [TestCase(3000, "three thousand")]
        [TestCase(4000, "four thousand")]
        [TestCase(5000, "five thousand")]
        [TestCase(6000, "six thousand")]
        [TestCase(7000, "seven thousand")]
        [TestCase(8000, "eight thousand")]
        [TestCase(9000, "nine thousand")]
        public void ConvertThousandsToWords_GivenThousands_ShouldReturnThousandsInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertThousandsToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4007, "four thousand seven")]
        [TestCase(8006, "eight thousand six")]
        [TestCase(9001, "nine thousand one")]
        public void ConvertNumbersCombiningThousandsAndUnits_GivenNumbersCombiningThousandsAndUnits_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningThousandsAndUnits(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2400, "two thousand four hundred")]
        [TestCase(9600, "nine thousand six hundred")]
        public void ConvertNumbersCombiningThousandsAndHundreds_GivenNumbersCombiningThousandsAndHundreds_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningThousandsAndHundreds(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3466, "three thousand four hundred sixty-six")]
        [TestCase(5577, "five thousand five hundred seventy-seven")]
        public void ConvertNumbersCombiningThousandsHundredsTensAndUnits_GivenNumbersCombiningThousandsWithHundredsAndCombinationOfTensAndUnits_ShouldReturnNumbersInWords(int number, string expected)
        {
            //Arrange
            var sut = new NumberToWordsConvertor();

            //Act
            var actual = sut.ConvertNumbersCombiningThousandsHundredsTensAndUnits(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
