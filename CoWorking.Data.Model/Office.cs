using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{
    [Table("Offices")]
    public class Office
    {
        [Key]
        public int ID { set; get; }
        [ForeignKey("CategoryId")]
        public int CategoryId { set; get; }
        [ForeignKey("AreaId")]
        public int AreaId { set; get; }
        [MaxLength(256)]
        public string NameOffice { set; get; }
        [MaxLength(256)]
        public string Address { set; get; }       
        public string Image { set; get; }
        [MaxLength(500)]
        public string GenenalDecription { set; get; }       
        public string Detail { set; get; }

        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }
        public string Tags { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public decimal Discount { set; get; }
        public long Latitude { set; get; }
        public long Longitude { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }

        public virtual CategoryOffice CategoryOffice { set; get; }
        public virtual Area Area { set; get; }
        public virtual List<Space> Spaces { set; get; } = new List<Space>();
        public virtual List<Device> Devices { set; get; } = new List<Device>();
        public virtual List<BookingDetail> BookingDetails { set; get; } = new List<BookingDetail>();
        public virtual List<FeedBack> FeedBacks { set; get; } = new List<FeedBack>();
        public virtual List<Manager> Managers { set; get; } = new List<Manager>();


    }

}
