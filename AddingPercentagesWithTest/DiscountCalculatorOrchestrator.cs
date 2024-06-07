using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPercentagesWithTest
{
    public class DiscountCalculatorOrchestrator
    {
        public static void Orchestrator()
        {
        //Variables
        var product = new Product("",0);
        

        //Ask for product description
        string denomination = AskUserForValue.AskPorValue("Insert product description:");

            //Ask for base price for product
            string valueInput1 = AskUserForValue.AskPorValue("Insert product base price:");
            decimal basePrice = TransformStringInDecimal.MakeTransformation(valueInput1);

            //Ask for product discount
            string valueInput2 = AskUserForValue.AskPorValue("Insert a decimal value to Product base price:");
            decimal discountApplied = TransformStringInDecimal.MakeTransformation(valueInput2);


            //Update object Product
            product.Denomination = denomination;
            product.BasePrice = basePrice;
            CalculateDiscount calculateDiscount = new();
            product.DiscountedPrice = calculateDiscount.CalculateNewPrice(product, basePrice);
            //Calculate new DiscountedPrice

            //Show result to user
            ShowDiscountedPrice.ShowProductDiscountedPrice(product, discountApplied);

        }


    }
}
