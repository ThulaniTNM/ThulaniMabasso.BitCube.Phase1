using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThulaniMabasso.BitCube.Phase1.Models {

    // list of all the products being purchased for our store,this is items the store needs to have
    public class ProductPurchaseOrder {

        public Product Product { get; set; }

        
        //public IList<Product> ProductsForStore { get; set; }

        //public void AddProductToStore() {
        //    ProductsForStore.Add(Product);
        //}

        // The above implementation can be coded when implementing our interface .
    }
}