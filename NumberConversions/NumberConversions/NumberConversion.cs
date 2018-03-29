using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversions
{
    class NumberConversion
    {
        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        

        public static int RomanToInteger(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            return number;
        }

        public static string IntegerToRoman(int integer)
        {
            string outPutString = " ";
            while (integer / 1000 >= 1)
            {
                integer = integer - 1000;
                outPutString = outPutString + "M";
            }

            while (integer / 500 >= 1)
            {
                integer = integer - 500;
                outPutString = outPutString + "D";
            }

            while (integer / 100 >= 1)
            {
                integer = integer - 100;
                outPutString = outPutString + "C";
            }

            while (integer / 50 >= 1)
            {
                integer = integer - 50;
                outPutString = outPutString + "I";
            }

            while (integer / 10 >= 1)
            {
                integer = integer - 10;
                outPutString = outPutString + "X";
            }

            while (integer / 5 >= 1)
            {
                integer = integer - 5;
                outPutString = outPutString + "V";
            }

            while (integer / 1 != 0)
            {
                integer = integer - 1;
                outPutString = outPutString + "I";
            }

            return outPutString;
        }

        
    }
}
