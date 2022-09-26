using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("stores", Schema = "sales")]
    class Store
    {
        [Key]
        public int store_id { get; set; }
        [Required,MaxLength(255)]
        public string store_name { get; set; }
        [MaxLength(255)]
        public string phone { get; set; }
        [MaxLength(255)]
        public string email { get; set; }
        [MaxLength(255)]
        public string street { get; set; }
        [MaxLength(255)]
        public string city { get; set; }
        [MaxLength(10)]
        public string state { get; set; }
        [MaxLength(5)]
        public string zip_code { get; set; }


        public ICollection<Product> products { get; set; }

        public List<Stock> stocks { get; set; }
        public ICollection<Staff> staffs { get; set; }

        public ICollection<Order> orders { get; set; }

    }
}
