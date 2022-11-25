using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("Accounts")]
    public class Accounts
    {   
        [Key]
        public int ID { set; get; }
        [ForeignKey("CustomerId")]
        public int CustomerId { set; get; }
        [Required]
        public string UserName { set; get; }
        [Required]
        public string Password { set; get; }
        public double Point { set; get; }
        public double Money { set; get; }
        public virtual Customer Customer { set; get; }
        public virtual List<FeedBack> FeedBacks { set; get; } = new List<FeedBack>();
        public virtual List<Booking> Bookings { set; get; } = new List<Booking>();
    }
}
