using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public class ProductsSoldResult {
        // result of product sold.
        public ProductsSellOrder ProductSoldResult { get; set; }
       
        public override string ToString() {
            return $"{ProductSoldResult.ProductSold}";
        }
    }
}