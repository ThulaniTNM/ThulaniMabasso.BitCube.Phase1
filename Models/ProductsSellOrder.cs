using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    
    //The type of product that was sold.
    public class ProductsSellOrder {
       public Product ProductSold { get; }
        public override string ToString() {
            return $"Product Sold : {ProductSold.Category}, Number of items sold : {ProductSold.NumberOfItems}"; 
        }
    }
}