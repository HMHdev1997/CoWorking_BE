using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("FeedBacks")]
    public class FeedBack
    {   
        [Key]
        public int ID { set; get; }
        [ForeignKey("CustomerId")]
        public int CustomerId { set; get; }
       
        [ForeignKey("OfficeId")]
        public int OfficeId { set; get; }
        [StringLength(500)]
        public string Message { set; get; }
        public int Location { set; get; }
        public int Votes { set; get; }        
        public virtual Accounts Accounts { set; get; }
        public virtual Office Office { set; get; }

    }
}
