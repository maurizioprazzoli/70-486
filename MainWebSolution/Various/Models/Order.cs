using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Various.Models
{
    public class Order
    {
        public Int32 OrderId { get; set; }

        public string OrderDesc { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}