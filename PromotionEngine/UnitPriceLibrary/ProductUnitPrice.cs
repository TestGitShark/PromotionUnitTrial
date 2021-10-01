using System;
namespace PromotionEngine
{
    public class ProductUnitPrice:IProductUnitPrice
    {
      

        public char ProductCode { get; set ; }
        public decimal UnitPrice { get ; set ; }
    }
}
