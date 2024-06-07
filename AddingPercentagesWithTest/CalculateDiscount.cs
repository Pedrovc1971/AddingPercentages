namespace AddingPercentagesWithTest
{
    public class CalculateDiscount:ICalculateDiscountPrice
    {
        public decimal CalculateNewPrice(Product product, decimal discount)
        {
            return (product.BasePrice - (product.BasePrice * (discount * 0.01m)));
        }
    }
}
