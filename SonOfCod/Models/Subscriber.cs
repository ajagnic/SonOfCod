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
        public string Email { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
