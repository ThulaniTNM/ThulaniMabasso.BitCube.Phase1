using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public class OnlineStore : IOnlineStore {
        public IList<Product> Inventory { get; set; }
        public void AddProductsToInventory(ProductPurchaseOrder purchaseOrder) {
            Inventory.Add(purchaseOrder.Product);
        }

        public InventoryItemSummary GetInventoryItemSummary(ProductType stock) {
            var productTypeList = Inventory.Where(product => product.Category == stock.ProductCategory).ToList();
            double total = 0;
            
            foreach (var el in productTypeList) {
                total += el.Price;
            }

            double average = total / productTypeList.Count();
            int numOfProductsAvailable = productTypeList.Count();
            return new InventoryItemSummary {Average = average,NumOfProducts = numOfProductsAvailable };
        }

        public InventorySummary GetInventorySummary() {
            return new InventorySummary { ProductsInventory = Inventory };
        }

        public ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder) {
            var itemWantingToSell = Inventory.Where(product => product.Category == itemsSoldOrder.ProductSold.Category).First();
            if (itemWantingToSell.NumberOfItems <= itemsSoldOrder.ProductSold.NumberOfItems){
                return new ProductsSoldResult { ProductSoldResult = itemsSoldOrder };
            }
            else {
                throw new Exception("Product not available for that specified number of items");
            }
        }

    }
}