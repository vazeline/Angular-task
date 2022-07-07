using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class BackeryItem
    {
        public string ItemType { get; set; }
        public decimal InitPrice { get; set; }
        public decimal CurrentPrice { get; set; }

        public DateTime NextPriceTime { get; set; }
        public decimal NextPrice { get; set; }
    }
}
