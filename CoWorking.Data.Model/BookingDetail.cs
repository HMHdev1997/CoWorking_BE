using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("BookingDetails")]
   public class BookingDetail
   {    
        [Key]
        public int ID { set; get; }
        [ForeignKey("OfficeId")]
        public int OfficeId { set; get; }
        [ForeignKey("BookingId")]
        public int BookingId { set; get; }
        public int PaymentStatus { set; get; }
        public int Stautus { set; get; }
        public virtual Booking Booking { set; get; }
        public virtual Office Office { set; get; }

    }
}
