using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz.Model.Customer
{
    public class Edit
    {
        public int ID { set; get; }       
        public string Name { set; get; }     
        public string Fullname { set; get; }
        public string Image { set; get; }
        public int IdentifierCode { set; get; }      
        public string Address { set; get; }
        public int PhoneNumbers { set; get; }      
        public string Email { set; get; }     
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public DateTime? RegistrationDate { set; get; }
        public int Status { set; get; }
    }
}
