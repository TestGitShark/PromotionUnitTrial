using System;
namespace PromotionEngine
{
    public interface IPromotionProduct
    {
        public char PromotionProductCode { get; set; }
        public int ItemCountForPromotion { get; set; }
    }
}
