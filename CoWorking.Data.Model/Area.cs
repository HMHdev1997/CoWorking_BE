using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("Area")]
    public class Area
    {   
        [Key]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string City { set; get; }
        [Required]
        [MaxLength(256)]
        public string District { set; get; }
        [Required]
        [MaxLength(256)]
        public string Street { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public virtual List<Office> Offices { set; get; } = new List<Office>();
    }
}
