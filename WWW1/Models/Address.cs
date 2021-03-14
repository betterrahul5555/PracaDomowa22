using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WWW1.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]

       
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }
        
        public string ZipCode { get; set; }
       
        
        public string City { get; set; }
        
      
 [Required(ErrorMessage = "Zły numer")]
        public int Number { get; set; }
         
    }
}
