using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApplication.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите ваше имя")]
        public string Name { get; set; }
        
        public string Line1 { get; set; }
    }
}
