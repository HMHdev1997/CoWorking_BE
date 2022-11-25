using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{
    [Table("Spaces")]
    public class Space
    {
        [Key]
        public int ID { set; get; }
        [ForeignKey("OfficeId")]
        public int OfficeId { set; get; }
        [ForeignKey("CategorySpaceId")]
        public int CategorySpaceId { set; get; }
        [MaxLength(50)]
        public string LocationSlot { set; get; }
        [StringLength(500)]
        public string Decription { set; get; }
        public double Price { set; get; }
        public int Staus { set; get; }

        public virtual Office Office { set; get; }
        public virtual CategorySpace CategorySpace {set; get;}
    }
}
