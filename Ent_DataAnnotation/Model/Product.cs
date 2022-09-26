using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("products",Schema= "production")]
    class Product
    {
        [Key]
        public int product_id { get; set; }
        [Required,MaxLength(255)]
        public string product_name { get; set; }
        public int model_year { get; set; }
        public int list_price { get; set; }
        [ForeignKey("Brand")]
        public int brand_id { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Category")]
        public int category_id { get; set; }
        public Category Category { get; set; }
        public ICollection<Store> stores{ get; set; }
        public ICollection<Order> Orders { get; set; }
        public List<Stock> stocks { get; set; }

        public List<order_items> order_Items { get; set; }

    }
}
