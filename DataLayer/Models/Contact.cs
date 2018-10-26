using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ContactId { get; set; }
        [Required]
        public string AddressType { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int StateId { get; set; }
        [Required]
        public string PostalCode { get; set; }
    }
}
