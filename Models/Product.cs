using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {
    public class Product {
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public int NumberOfItems { get; set; }
    }
}