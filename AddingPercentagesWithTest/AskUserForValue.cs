using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public class AskUserForValue()
    {
        public static string AskPorValue(string message)
        {
            string? descriptionInserted = null;

            while (string.IsNullOrEmpty(descriptionInserted) || (string.IsNullOrWhiteSpace(descriptionInserted)))
            {
                Console.WriteLine(message);
                descriptionInserted = Console.ReadLine();
            }

            return descriptionInserted;

        }

    }
}
