using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSytemWithCSharp.Entities
{
    public class ConvertNumericalBase
    {
        private string digits = "0123456789ABCDEFG";
        public double Number { get; set; }
        public int NumberBase { get; set; }

        public ConvertNumericalBase(double number, int numberBase = 10) => (Number, NumberBase) = (number, numberBase);

        public void ConvertDecimalToOther(int baseToConversion)
        {
            int integerPart = (int)this.Number;
            double decimalPart = this.Number - integerPart;
            string binaryNumber = "";
            
            do
            {
                binaryNumber = digits[integerPart % baseToConversion] + binaryNumber;
                integerPart /= baseToConversion;
            } while (integerPart > 0);

            if (decimalPart > 0)
            {
                binaryNumber += ".";

                do
                {
                    decimalPart *= baseToConversion;
                    binaryNumber += digits[(int)decimalPart];
                    decimalPart -= (int)decimalPart;

                } while (decimalPart > 0);

            }


            System.Console.WriteLine(binaryNumber);
        }
    }
}