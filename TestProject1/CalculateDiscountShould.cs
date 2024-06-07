using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddingPercentagesWithTest;
using FluentAssertions;

namespace TestProject1
{
    public class CalculateDiscountShould
    {
        [Fact]
        public void ReturnADecimal()
        {
            //Arrange
            CalculateDiscount calculateDiscount = new ();
            decimal discount = 10;
            Product product = new ("Table", 100);


            //Actç

            //Assert
            calculateDiscount.CalculateNewPrice(product, discount).Should().BeInRange(0, decimal.MaxValue);
        }
    }
}
