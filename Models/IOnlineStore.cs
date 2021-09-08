using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public interface IOnlineStore {
        void AddProductsToInventory(ProductPurchaseOrder purchaseOrder);
        ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder);
        InventoryItemSummary GetInventoryItemSummary(ProductType stock);
        InventorySummary GetInventorySummary();

    }
}
