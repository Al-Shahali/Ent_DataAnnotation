using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("order_items", Schema = "production")]

    class order_items
    {
        public int order_id { get; set; }
        public int item_id { get; set; }
        [Required]
        public int product_id { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public float list_price { get; set; }
        public float discount { get; set; }
        //[ForeignKey("product_id")]
        public Product product { get; set; }
       // [ForeignKey("order_id")]
        public Order order { get; set; }



    }
}
