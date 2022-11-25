using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   [Table("Bookings")]
    public class Booking
    {   
        [Key]
        public int ID { set; get; }
        [ForeignKey("CustomerId")]
        public int CustomerId { set; get; }        
        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
        public DateTime? CreatedDate { set; get; }
        public double Total { set; get; }       
        public virtual Accounts Accounts { set; get; }
        public virtual List<BookingDetail> BookingDetails{ set; get; } = new List<BookingDetail>();
        public virtual List<Service> Services { set; get; } = new List<Service>();

    }
}
