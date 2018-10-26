using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StateName { get; set; }
    }
}
