using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionModel:IPromotionState,IPromotionPrice
    {
        List<PromotionProduct> PromotionProductList { get; set; }
    }
}
