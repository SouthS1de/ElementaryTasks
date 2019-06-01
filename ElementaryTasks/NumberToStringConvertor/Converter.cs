using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToStringConvertor
{
    public static class Converter
    {
        private static int[] _arrayOfDigits = new int[4];
        private static string[,] _digits = new string[4, 3] {
                { " миллиард", " миллиарда", " миллиардов" },
                { " миллион", " миллиона", " миллионов" },
                { " тысяча", " тысячи", " тысяч" },
                { "", "", "" }
            };

        private static void SplitNumberByDigits(int number)
        {
            _arrayOfDigits[0] = (number - (number % 1000000000)) / 1000000000;
            _arrayOfDigits[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
            _arrayOfDigits[2] = ((number % 1000000) - (number % 1000)) / 1000;
            _arrayOfDigits[3] = number % 1000;
        }

        private static string ConvertBillion(int number)
        {
            if (number == 0)
                return string.Empty;
            else
                return $"{ConvertHundreds(number)} billion";
        }

        private static string ConvertUnits(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 0:
                    result = string.Empty;
                    break;
                case 1:
                    result = " one";
                    break;
                case 2:
                    result = " two";
                    break;
                case 3:
                    result = " three";
                    break;
                case 4:
                    result = " four";
                    break;
                case 5:
                    result = " five";
                    break;
                case 6:
                    result = " six";
                    break;
                case 7:
                    result = " seven";
                    break;
                case 8:
                    result = " eight";
                    break;
                case 9:
                    result = " nine";
                    break;                   
            }
            
            return result;
        }

        private static string ConvertTens(int number)
        {
            string result = string.Empty;

            switch (number)
            {
                case 10:
                    result = " ten";
                    break;
                case 11:
                    result = " eleven";
                    break;
                case 12:
                    result = " twelve";
                    break;
                case 13:
                    result = " thirteen";
                    break;
                default:
                    if (number < 20)
                        result = $"{ConvertUnits(number % 10)}teen";
                    else
                        result = ConvertMoreThanTwenty(number);
                    break;
            }

            return result;
        }

        private static string ConvertMoreThanTwenty(int number)
        {
            string result = string.Empty;

            int unit = number % 10;

            switch (number - (number % 10))
            {
                
                case 2:
                    result = $" twenty {ConvertUnits(unit)}";
                    break;
                case 3:
                    result = $" thirty {ConvertUnits(unit)}";
                    break;
                case 4:
                    result = $" fourty {ConvertUnits(unit)}";
                    break;
                case 5:
                    result = $" fifty {ConvertUnits(unit)}";
                    break;
                case 6:
                    result = $" sixty {ConvertUnits(unit)}";
                    break;
                case 7:
                    result = $" seventy {ConvertUnits(unit)}";
                    break;
                case 8:
                    result = $" eighty {ConvertUnits(unit)}";
                    break;
                case 9:
                    result = $" ninety {ConvertUnits(unit)}";
                    break;
            }

            return result;
        }
        
        
        private static string ConvertHundreds(int number)
        {
            int tens = number % 100;
            int hundred = number - tens;

            return  $"{ConvertUnits(number)} hundred {ConvertTens(tens)}";
        }

        public static string Convert(int number)
        {
            string result = string.Empty;

            if (number == 0)
                result = "zero";
            else
            {
                SplitNumberByDigits(number);



            }         
            
            return result.TrimStart();
        }
    }
}
