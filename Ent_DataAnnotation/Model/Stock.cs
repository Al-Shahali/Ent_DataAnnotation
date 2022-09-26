using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("Stocks", Schema = "production")]
    class Stock
    {
        //internal object products;

        //[Key,Column(Order =0)]

        
        public int store_id { get; set; }
        public int quantity { get; set; }
        //[Key,Column(Order = 1)]
        public int product_id { get; set; }

        //[ForeignKey("product_id")]
        public Product product { get; set; }

        //[ForeignKey("store_id")]

        public Store store { get; set; }

        /*
        -- in this table has two primary key 
        -- so you can not crate this realtion using data annotaion class 
        -- to create it use fluent api 
         */
    }
}
