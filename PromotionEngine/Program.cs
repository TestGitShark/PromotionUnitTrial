using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            
            List<IProductUnitPrice> unitPriceList = new List<IProductUnitPrice>();
            unitPriceList=DemoDataManager.LoadUnitPriceDemoData();


            List<SingleProductPromotionModel> singleProductPromotions = DemoDataManager.LoadSingleProductPromotionDemoData();
            

            ShoppingCartModel shoppingCart = DemoDataManager.LoadShoppingCartDemoData();
            SingleProductPromotionModel.ApplyPromotion(shoppingCart, unitPriceList, singleProductPromotions);
            decimal totalPrice = ShoppingCartModel.CalculatePriceAfterPromotion(shoppingCart);
            Console.WriteLine($"TotalPrice={totalPrice}");
             
            //List<CartItem> shoppingCart = DemoDataManager.ShoppingCartDemoData();
            //Console.WriteLine(unitPriceList.Find(x => x.ProductCode == 'A').UnitPrice);

            //ShoppingCartModel.CalculatePriceAfterPromotion(shoppingCart, promotions, unitPriceList);

        }
    }
}
