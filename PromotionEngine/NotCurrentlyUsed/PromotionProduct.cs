using System;
namespace PromotionEngine
{
    public  class PromotionProduct:IPromotionProduct
    {

        public char PromotionProductCode { get ; set; }
        public int ItemCountForPromotion { get ; set; }
    }
}
