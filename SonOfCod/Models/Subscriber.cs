using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
