using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public class TransformStringInDecimal
    {
        public static decimal MakeTransformation(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                throw new ArgumentException("The string is empty or only contains white spaces.");
            }

            inputString = inputString.Trim();
               if (decimal.TryParse(inputString, out decimal result))
               {
                   return result;
               }
               else
               {
                   throw new FormatException("Can't convert string in decimal.");
               }

           
        }
    }
}
