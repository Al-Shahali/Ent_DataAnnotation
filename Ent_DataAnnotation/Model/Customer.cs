using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("customers", Schema = "sales")]
    class Customer
    {
        [Key]
        public int customer_id { get; set; }
        [MaxLength(255)]
        public string first_name { get; set; }
        [MaxLength(255)]
        public string last_name { get; set; }
        [MaxLength(25)]
        public string phone { get; set; }
        [MaxLength(255)]
        public string email { get; set; }
        [MaxLength(255)]
        public string street { get; set; }
        [MaxLength(50)]
        public string city { get; set; }
        [MaxLength(25)]
        public string state { get; set; }
        [MaxLength(5)]
        public string Zip_code { get; set; }


        public ICollection<Order> orders { get; set; }
    }
}
