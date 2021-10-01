using System;
namespace PromotionEngine
{
    public interface IProductUnitPrice
    {
        public char ProductCode { get; set; }
        public decimal UnitPrice{ get; set; }
    }
}
