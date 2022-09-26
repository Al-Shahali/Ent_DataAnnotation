using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ent_DataAnnotation.Model
{
    [Table("staffs", Schema = "sales")]

    class Staff
    {
        [Key]
        public int staff_id { get; set; }
        [Required,MaxLength(50)]
        public string first_name { get; set; }
        [Required, MaxLength(50)]
        public int last_name { get; set; }
        [Required, MaxLength(255)]
        public int email { get; set; }
        [MaxLength(25)]
        public int phone { get; set; }
        [Required]
        public int active { get; set; }
        [Required]
        public int store_id { get; set; }
        
        public int manager_id { get; set; }
        [ForeignKey("manager_id")]
        public Staff staff { get; set; }

        [ForeignKey("store_id")]
        public Store Store { get; set; }

        public ICollection<Order> orders { get; set; }
    }

    
}
