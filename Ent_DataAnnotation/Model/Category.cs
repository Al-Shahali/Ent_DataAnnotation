using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("categories", Schema = "production")]
    class Category
    {
        [Key]
        public int category_id { get; set; }
        [Required,MaxLength(255)]
        public string category_name { get; set; }

        public List<Product> Products { get; set; }
    }
}
