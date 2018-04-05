using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabictoRoman
{
    class ArabictoRoman
    {
        public static string IntegerToRoman(int integer)
        {
            int inputValue = integer;
            string OutputValue = "";

            while (inputValue / 1000 != 0)
            {
                inputValue = (inputValue - 1000);
                OutputValue = (OutputValue + "M");
            }
            while (inputValue / 900 != 0)
            {
                inputValue = (inputValue - 900);
                OutputValue = (OutputValue + "CM");
            }
            while (inputValue / 500 != 0)
            {
                inputValue = (inputValue - 500);
                OutputValue = (OutputValue + "D");
            }
            while (inputValue / 400 != 0)
            {
                inputValue = (inputValue - 400);
                OutputValue = (OutputValue + "CD");
            }
            while (inputValue / 100 != 0)
            {
                inputValue = (inputValue - 100);
                OutputValue = (OutputValue + "C");
            }
            while (inputValue / 90 != 0)
            {
                inputValue = (inputValue - 90);
                OutputValue = (OutputValue + "XC");
            }
            while (inputValue / 50 != 0)
            {
                inputValue = (inputValue - 50);
                OutputValue = (OutputValue + "L");
            }
            while (inputValue / 40 != 0)
            {
                inputValue = (inputValue - 40);
                OutputValue = (OutputValue + "XL");
            }
            while (inputValue / 10 != 0)
            {

                inputValue = (inputValue - 10);
                OutputValue = (OutputValue + "X");
            }
            while (inputValue / 5 != 0)
            {
                if (inputValue == 9)
                {
                    inputValue = (inputValue - 9);
                    OutputValue = (OutputValue + "IX");
                }
                else
                {
                    inputValue = (inputValue - 5);
                    OutputValue = (OutputValue + "V");
                }
            }
            while (inputValue / 1 != 0)
            {
                if (inputValue / 1 > 3)
                {
                    inputValue = (inputValue - 4);
                    OutputValue = (OutputValue + "IV");
                }
                else
                {
                    inputValue = (inputValue - 1);
                    OutputValue = (OutputValue + "I");
                }
            }
            return OutputValue;
        }
    }
}
