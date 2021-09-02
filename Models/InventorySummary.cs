using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public class InventorySummary {
        public IList<Product> ProductsInventory { get; set; }
        
        public override string ToString() {
            return ProductsInventory.ToString();
        }
    }
}