using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{   
    [Table("CategorySpace")]
    public class CategorySpace
    {   
        [Key]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
        public int Capacity { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime? ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public virtual List<Space> Spaces { set; get; } = new List<Space>();

    }
}
