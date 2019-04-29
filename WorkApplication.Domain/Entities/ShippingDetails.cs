﻿using System;
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

        [Required(ErrorMessage = "Укажите первый адрес доставки")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
