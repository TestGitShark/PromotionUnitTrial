using System;
namespace PromotionEngine
{
    public class CartItem:ICartItem
    {
        public char ProductId { get ; set ; }
        public int Count { get ; set ; }
        public bool PromotionApplied { get; set ; }
        public decimal FinalPrice { get ; set ; }
    }
}
