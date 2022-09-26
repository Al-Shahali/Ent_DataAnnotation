using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("orders", Schema = "sales")]
    class Order
    {
        [Key]
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public bool order_status { get; set; }
        [Required]
        public DateTime order_date { get; set; }
        [Required]
        public DateTime required_date { get; set; }
        public DateTime shipped_date { get; set; }
        public int store_id { get; set; }
        public int staff_id { get; set; }



        [ForeignKey("customer_id")]
        public Customer customer { get; set; }
        [ForeignKey("staff_id")]
        public Staff staff { get; set; }
        [ForeignKey("store_id")]
        public Store store { get; set; }

       public ICollection<Product> products { get; set; }

        public List<order_items> order_Items { get; set; }
    }
}
