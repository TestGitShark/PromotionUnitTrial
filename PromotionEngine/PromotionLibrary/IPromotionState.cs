using System;
namespace PromotionEngine
{
    public interface IPromotionState
    {

        bool IsPromotionActive{ get; set; }
    }
}
