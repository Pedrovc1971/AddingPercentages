using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AddingPercentagesWithTest;

namespace TestProject1
{
    public class CalculatePriceShould
    {
        [Fact]
        public void VerifyReturnValue()
        {
            //Arrange
            var calculateDiscountPrice = new CalculateDiscount();
            var product = new Product("Car", 100);
            var discount = 5;
            var compareValue = 0.0m;
            //Act
            var result = calculateDiscountPrice.CalculateNewPrice(product, discount);
            compareValue = product.BasePrice - (product.BasePrice * discount * 0.01m);
            //Assert
            Assert.Equal(compareValue, result);
        }

        [Fact]
        public void VerifyIsPositiveValue()
        {
            //Arrange
            var calculateDiscountPrice = new CalculateDiscount();
            var product = new Product("Car", 100);
            var discount = 5;
            //Act
            var result = calculateDiscountPrice.CalculateNewPrice(product, discount);
            bool IsPositive = result >= 0;
            //Assert
            Assert.True(IsPositive);
        }
    }
}
