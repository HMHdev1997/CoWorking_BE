using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("ServiceDetails")]
    public class ServiceDetail
    {   
        [Key]
        public int Id { set; get; }
        [ForeignKey("ServiceId")]
        public int ServiceId { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        public int Numbers { set; get; }
        public double Price { set; get; }
        public virtual Service Service { set; get; }
       
    }
}
