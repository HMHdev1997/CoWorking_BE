using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz.Model.CategoryOffice
{
    public class New
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Decription { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
    }
}
