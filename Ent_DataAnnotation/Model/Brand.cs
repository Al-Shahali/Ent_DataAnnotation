using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("brands",Schema= "production")]
    class Brand
    {
        [Key]
        public int brand_id { get; set; }
        [Required,MaxLength(255)]
        public string brand_name { get; set; }

        public List<Product> Products { get; set; }
    }
}
