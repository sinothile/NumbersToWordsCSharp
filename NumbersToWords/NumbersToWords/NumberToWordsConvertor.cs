using System;

namespace NumbersToWords
{
    public class NumberToWordsConvertor
    {
        string converter;
        public string ConvertUnitsToWords(int number)
        {
            string [] units = new string[] {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            converter = units[number % 10];
            return converter;
        }

        public string ConvertNumbersMoreThan10LessThan20(int number)
        {
            string [] numbersMoreThan10LessThan20 = new string[] {" ", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            converter = numbersMoreThan10LessThan20[number % 10];
            return converter;
        }
        public string ConvertTensToWords(int number)
        {
            string [] tens = new string[] {" ","ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            converter = tens[number % 100 / 10];
            return converter;
        }

        public string ConvertHundredsToWords(int number)
        {
            string [] hundreds = new string[] { " ", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
            converter = hundreds[number % 1000 / 100];
            return converter;
        }

        public string ConvertThousandsToWords(int number)
        {
            string [] thousands = new string[] { " ", "one thousand", "two thousand", "three thousand", "four thousand", "five thousand", "six thousand", "seven thousand", "eight thousand", "nine thousand" };
            converter = thousands[number % 10000 / 1000];
            return converter;
        }
        public string ConvertNumbersCombiningTensAndUnitsToWords(int number)
        {
            converter = ConvertTensToWords(number) +"-"+ ConvertUnitsToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningHundredsAndUnitsToWords(int number)
        {
            converter = ConvertHundredsToWords(number) +" "+ ConvertUnitsToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningHundredsAndTensToWords(int number)
        {
            converter = ConvertHundredsToWords(number) + " " + ConvertTensToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningHundredsAndNumbersCombiningTensAndUnits(int number)
        {
            converter = ConvertHundredsToWords(number) + " " + ConvertNumbersCombiningTensAndUnitsToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningThousandsAndUnits(int number)
        {
            converter = ConvertThousandsToWords(number) + " " + ConvertUnitsToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningThousandsHundredsTensAndUnits(int number)
        {
            converter = ConvertThousandsToWords(number) + " " + ConvertHundredsToWords(number) + " "+ ConvertNumbersCombiningTensAndUnitsToWords(number);
            return converter;
        }

        public string ConvertNumbersCombiningThousandsAndHundreds(int number)
        {
            converter = ConvertThousandsToWords(number) + " " + ConvertHundredsToWords(number);
            return converter;
        }
    }
}
