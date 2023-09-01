using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSytemWithCSharp.Entities
{
    public class NumberBaseConverter
    {
        private string digits = "0123456789ABCDEFG";
        public double Number { get; set; }

        public int BaseNumber { get; set; }

        private int integerPart = 0;

        private double decimalPart = 0.0;
        public NumberBaseConverter(double number, int baseNumber= 10)
        {
            (Number,BaseNumber) = (number, BaseNumber);
            integerPart = (int)number;
            decimalPart = number - integerPart;
        }

        private StringBuilder ConvertDecimalToOther(int baseConvert)
        {
            StringBuilder binaryNumber = new StringBuilder();
            do
            {
                binaryNumber.Insert(0, digits[integerPart % baseConvert]);
                integerPart /= baseConvert;
            } while (integerPart > 0);

            if (decimalPart > 0)
            {
                binaryNumber.Append(".");

                do
                {
                    decimalPart *= baseConvert;
                    binaryNumber.Append(digits[(int)decimalPart]);
                    decimalPart -= (int)decimalPart;

                } while (decimalPart > 0);

            }


            return binaryNumber;


        }

        public StringBuilder getNumberBaseConvert(int baseConvert)
        {
            return ConvertDecimalToOther(baseConvert);
        }

    }
}
