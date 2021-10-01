using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class DemoDataManager
    {
        public static List<IProductUnitPrice> LoadUnitPriceDemoData()
        {

           // List<IProductUnitPrice> unitPrices = new List<IProductUnitPrice>();

            List<IProductUnitPrice> productUnitPrices = new List<IProductUnitPrice>
            {
                //  ( new { }}
                new ProductUnitPrice { ProductCode = 'A', UnitPrice = 100M },
                new ProductUnitPrice { ProductCode = 'B', UnitPrice = 50M },
                new ProductUnitPrice { ProductCode = 'C', UnitPrice = 25M },
                new ProductUnitPrice { ProductCode = 'D', UnitPrice = 15M },
                new ProductUnitPrice { ProductCode = 'E', UnitPrice = 10M },
                new ProductUnitPrice { ProductCode = 'F', UnitPrice = 30M }
            };

            return productUnitPrices;
        }

        //public static List<IPromotionModel> LoadDemoPromotions()
        //{

        //    //Single product
        //    List<PromotionProduct> promotion1 = new List<PromotionProduct>
        //                            {new PromotionProduct { ItemCountForPromotion = 3, PromotionProductCode = 'A' }};

        //    List<PromotionProduct> promotion2 = new List<PromotionProduct>
        //                            {new PromotionProduct { ItemCountForPromotion = 2, PromotionProductCode = 'B' }};



        //    //Multiple products
        //    List<PromotionProduct> promotion3 = new List<PromotionProduct>
        //                            { new PromotionProduct { ItemCountForPromotion = 1, PromotionProductCode = 'C' },
        //                            new PromotionProduct { ItemCountForPromotion = 1, PromotionProductCode = 'D' }
        //    };

           

        //    List<IPromotionModel> promotions = new List<IPromotionModel> {
        //        new PromotionModel { IsPromotionActive=true,PromotionProductList=promotion1,PromotionPrice=200 },
        //        new PromotionModel { IsPromotionActive=true,PromotionProductList=promotion2,PromotionPrice=75 },
        //        new PromotionModel { IsPromotionActive=true,PromotionProductList=promotion3,PromotionPrice=20 }
        //    };
        //    return promotions;
        //}
        public static List<SingleProductPromotionModel> LoadSingleProductPromotionDemoData()
        {
            //SingleProductPromotionLibrary.SingleProductPromotions promotions = new SingleProductPromotionLibrary.SingleProductPromotions();
            //promotions.SingleProductPromotionList.Add(new SingleProductPromotionModel
            //            { IsPromotionActive = true, ItemCountForPromotion = 3, PromotionProductCode = 'A', PromotionPrice = 250 });
            //promotions.SingleProductPromotionList.Add(new SingleProductPromotionModel
            //{ IsPromotionActive = true, ItemCountForPromotion = 2, PromotionProductCode = 'B', PromotionPrice = 75 });
            //promotions.SingleProductPromotionList.Add(new SingleProductPromotionModel
            //{ IsPromotionActive = true, ItemCountForPromotion = 2, PromotionProductCode = 'C', PromotionPrice = 40 });

            List<SingleProductPromotionModel> singleProductPromotions = new List<SingleProductPromotionModel>
                                                { new SingleProductPromotionModel{ IsPromotionActive = true, ItemCountForPromotion = 3, PromotionProductCode = 'A', PromotionPrice = 250 },
                                                  new SingleProductPromotionModel { IsPromotionActive = true, ItemCountForPromotion = 2, PromotionProductCode = 'B', PromotionPrice = 75 },
                                                  new SingleProductPromotionModel { IsPromotionActive = true, ItemCountForPromotion = 2, PromotionProductCode = 'C', PromotionPrice = 40 }

                                        };


            return singleProductPromotions;

        }


        public static ShoppingCartModel LoadShoppingCartDemoData()
        {
            //List<CartItem> shoppingCart = new List<CartItem>
            //                    {
            //                        new CartItem { ProductId='A',Count=5,PromotionApplied=false, PriceAfterPromotion=0},
            //                        new CartItem { ProductId='B',Count=3,PromotionApplied=false, PriceAfterPromotion=0},
            //                        new CartItem { ProductId='C',Count=2,PromotionApplied=false, PriceAfterPromotion=0},
            //                        new CartItem { ProductId='D',Count=1,PromotionApplied=false, PriceAfterPromotion=0}
            //                    };


            ShoppingCartModel cart = new ShoppingCartModel();
            cart.Items.Add(new CartItem { ProductId = 'A', Count = 5, PromotionApplied = false, FinalPrice = 0 });
            cart.Items.Add(new CartItem { ProductId = 'B', Count = 3, PromotionApplied = false, FinalPrice = 0 });
            cart.Items.Add(new CartItem { ProductId = 'C', Count = 2, PromotionApplied = false, FinalPrice = 0 });
            cart.Items.Add(new CartItem { ProductId = 'D', Count = 1, PromotionApplied = false, FinalPrice = 0 });
            return cart;

        }

    }
}
//{}