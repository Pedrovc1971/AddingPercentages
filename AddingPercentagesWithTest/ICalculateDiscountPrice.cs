using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public interface ICalculateDiscountPrice
    {
        public decimal CalculateNewPrice(Product product, decimal discount);
    }
}
