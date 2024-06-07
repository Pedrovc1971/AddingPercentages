using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public class ShowDiscountedPrice
    {
        public static string ShowProductDiscountedPrice(Product product, decimal discount)
        {
            return $"The price with a discount of: {discount}, for product {product.Denomination} is: {product.DiscountedPrice}";
        }
    }
}
