using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz.Model.Area
{
    public class New
    {
        public int ID { set; get; }
        
        public string City { set; get; }
        
        public string District { set; get; }
      
        public string Street { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
    }
}
