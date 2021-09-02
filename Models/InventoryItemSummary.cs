using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public class InventoryItemSummary {
        public double Average { get; set; }
        public int NumOfProducts { get; set; }

        public override string ToString() {
            return $" Average Price : {Average} , Number of items available {NumOfProducts}";
        }
    }
}