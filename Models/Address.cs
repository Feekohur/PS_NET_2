using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS_NET_2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage ="Podaj ulice")]

        public string Street { get; set; }
        [Display(Name = "Zipcode")]
        [StringLength(60,MinimumLength = 3), Required]
        public string ZipCode { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "Podaj miasto")]
        public string City { get; set; }
        [Display(Name = "Number")]
        [Required]
        public int Number { get; set; }
    }
}
