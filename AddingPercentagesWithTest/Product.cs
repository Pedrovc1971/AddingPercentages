using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public class Product(string denomination, decimal basePrice)
    {
        public string Denomination { get; set; } = denomination;
        public decimal BasePrice { get; set; } = basePrice;
        public decimal DiscountedPrice { get; set; } = basePrice;
    }
}
