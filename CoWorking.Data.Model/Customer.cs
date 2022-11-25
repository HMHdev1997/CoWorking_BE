using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoWorking.Data.Model
{
    [Table("Customers")]
    public class Customer
    {   
        [Key]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Fullname { set; get; }

        public string Image { set; get; }
        public int IdentifierCode { set; get; }
        [MaxLength(256)]
        public string Address { set; get; }
        public int PhoneNumbers { set; get; }
        [MaxLength(256)]
        public string Email { set; get; }
        [MaxLength(5)]
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public DateTime? RegistrationDate { set; get; }
        public int Status { set; get; }
        public virtual Accounts Accounts { set; get; }
      
      
        
    }
}
