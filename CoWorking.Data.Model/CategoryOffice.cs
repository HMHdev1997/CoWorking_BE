using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("CategoryOffice")]
    public class CategoryOffice
    {   
        [Key]
        public int ID { set; get; }
        [StringLength(256)]
        public string Name { set; get; }
        [StringLength(256)]
        public string Decription { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public virtual List<Office> Offices { set; get; } = new List<Office>();
    }
}
