using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("Services")]
    public class Service
    {   
        [Key]
        public int ID { set; get; }
        [ForeignKey("BookingId")]
        public int BookingId { set; get; }
        [Required]
        [StringLength(256)]
        public string Name { set; get; }
        [StringLength(50)]
        public string Type { set; get; }
        public int Numbers { set; get; }
        public double Totail { set; get; }
        public virtual Booking Booking { set; get; } 
        public virtual ServiceDetail ServiceDetail { set; get; }

    }
}
