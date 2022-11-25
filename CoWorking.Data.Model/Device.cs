using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("Decvice")]
    public class Device
    {   
        [Key]
        public int ID { set; get; }
        [ForeignKey("OfficeId")]
        public int OfficeId { set; get; }
        [MaxLength(256)]
        public string Name { set; get; }
        public int Numbers { set; get; }
        [MaxLength(256)]
        public string Decription { set; get; }
        public virtual Office Office { set; get; }
    }
}
