using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddingPercentagesWithTest;
using FluentAssertions;

namespace TestProject1
{
    public class ShowDiscountPriceShould
    {
        [Fact]
        public void ShowACorrectMessage()
        {
            //Arrange
            Product product = new ("Table", 100.00m);
            decimal discount = 10.00m;
            CalculateDiscount calculateDiscount = new CalculateDiscount();
            //Act
            product.DiscountedPrice = decimal.Round(calculateDiscount.CalculateNewPrice(product, discount),2);
            string returnedString = ShowDiscountedPrice.ShowProductDiscountedPrice(product, discount);
            //Assert
            returnedString.Should().Be($"The price with a discount of: 10.00, for product Table is: 90.00");
        }
    }
}
