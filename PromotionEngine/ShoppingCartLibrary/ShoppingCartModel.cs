using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class ShoppingCartModel
    {
       public List<CartItem> Items { get; set; } = new List<CartItem>();

        public static decimal CalculatePriceAfterPromotion(ShoppingCartModel shoppingCart
                                                )
        {
            

            decimal totalPrice=0;
            foreach (CartItem cartItem in shoppingCart.Items)

            {
                totalPrice += cartItem.FinalPrice;

            }
            return totalPrice;
            //foreach (CartItem cartItem in shoppingCart)
            //{
            //    if(!cartItem.PromotionApplied)
            //    {
            //        char currentProductId = cartItem.ProductId;
            //        IPromotionModel applicablePromotion = new PromotionModel();
            //        foreach(IPromotionModel promotion in promotions)
            //        {
            //            var p = promotion.PromotionProductList.Find(x => x.PromotionProductCode == currentProductId);
            //            if(p!=null)
            //            {
            //                Console.WriteLine($"{p.PromotionProductCode} {p.ItemCountForPromotion}");
            //                //promotion is an applicable promotion

            //                if(promotion.PromotionProductList.Count==1)
            //                {
            //                    //promotion on a single item


            //                }


            //            }
            //        }
            //        //applicablePromotion = promotions.Find(x => x.PromotionProductList.Find(p=>p.PromotionProductCode==currentProductId));
            //    }
            //}
        }
    }
}

//{}



/*
 * 
 * 
 * 
 *   //
            int i = shoppingCart.FindIndex(x => x.ProductId == duoComboPromotion.ProductIdTwo);
            double priceAfterPromotion = 0;
            if (currentCartItem.Count == shoppingCart[i].Count)

            {
                priceAfterPromotion = currentCartItem.Count * duoComboPromotion.Price;
                currentCartItem.PriceAfterPromotion = priceAfterPromotion;
                shoppingCart[i].PromotionApplied = true;
                shoppingCart[i].PriceAfterPromotion = 0; // combined price given to the other item
            }
            else if (currentCartItem.Count < shoppingCart[i].Count)
            {
                priceAfterPromotion = (currentCartItem.Count * duoComboPromotion.Price) + (shoppingCart[i].Count - currentCartItem.Count) * unitPriceProduct2;
                currentCartItem.PriceAfterPromotion = currentCartItem.Count * duoComboPromotion.Price;
                shoppingCart[i].PromotionApplied = true;
                shoppingCart[i].PriceAfterPromotion = (shoppingCart[i].Count - currentCartItem.Count) * unitPriceProduct2;
            }
            else
            {
                priceAfterPromotion = (shoppingCart[i].Count * duoComboPromotion.Price) + (currentCartItem.Count - shoppingCart[i].Count) * unitPriceProduct1;

                currentCartItem.PriceAfterPromotion = (shoppingCart[i].Count * duoComboPromotion.Price) + (currentCartItem.Count - shoppingCart[i].Count) * unitPriceProduct1;
                shoppingCart[i].PromotionApplied = true;
                shoppingCart[i].PriceAfterPromotion = 0;

            }
            return priceAfterPromotion;



--------------------------------------------------------------



    public static double CalculateMultibuyPromotionalPrice(CartItem cartItem, MultibuyPromotion multibuyPromotion, double unitPrice)

        {

            double priceAfterPromotion = (int)(cartItem.Count / multibuyPromotion.Count) * multibuyPromotion.Price +
                        (cartItem.Count % multibuyPromotion.Count) * unitPrice;




            return priceAfterPromotion;
        }
 * 
 */
