using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz.Model.Office
{
    public class New
    {
        public int ID { set; get; }
        public int AreaId { set; get; }
        public int CategoryId { set; get; }
        public string NameOffice { set; get; }
        public string Address { set; get; }
        public string Image { set; get; }
        public string GenenalDecription { set; get; }
        public string Detail { set; get; }
        public string MoreImage { set; get; }
        public string Tags { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public decimal Discount { set; get; }
        public long Latitude { set; get; }
        public long Longitude { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate {set; get;}
        public string ModifiedBy { set; get; }
    }
}
