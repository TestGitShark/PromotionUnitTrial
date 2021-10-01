using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionModel:IPromotionModel
    {
        public bool IsPromotionActive { get ; set ; }
       
        public decimal PromotionPrice { get; set ; }
        public List<PromotionProduct> PromotionProductList { get ; set ; }
    }
}
