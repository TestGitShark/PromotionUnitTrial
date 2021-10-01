using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class SingleProductPromotionModel:ISingleProductPromotionModel
    {
        public bool IsPromotionActive { get ; set ; }
        public decimal PromotionPrice { get ; set ; }
        public char PromotionProductCode { get; set ; }
        public int ItemCountForPromotion { get ; set ; }

        public static void ApplyPromotion(ShoppingCartModel shoppingCart, List<IProductUnitPrice> productUnitPrices
                                                    , List<SingleProductPromotionModel> promotions)
        {
            foreach(CartItem cartItem in shoppingCart.Items )
            {
                if(!cartItem.PromotionApplied)
                {
                        var applicablePromotion = promotions.Find(x => x.PromotionProductCode == cartItem.ProductId);
                    decimal unitPrice = productUnitPrices.Find(x => x.ProductCode == cartItem.ProductId).UnitPrice;
                    if(applicablePromotion!=null && applicablePromotion.IsPromotionActive)

                    {
                       cartItem.FinalPrice = (int)(cartItem.Count / applicablePromotion.ItemCountForPromotion) * applicablePromotion.PromotionPrice +
                            (cartItem.Count % applicablePromotion.ItemCountForPromotion) * unitPrice;
                        cartItem.PromotionApplied = true;
                        MentionPromotion.WriteMessage($"Promotion applied on {cartItem.ProductId}- " +
                            $"original price {cartItem.Count * unitPrice} promotional price {cartItem.FinalPrice}");
                    }
                    else
                    {
                        // No promotion applicable for this cartItem
                        cartItem.FinalPrice = cartItem.Count * unitPrice;
                    }
                }
                //else some promotion already applied & only one promotion per product
            }
        }
    }
}
