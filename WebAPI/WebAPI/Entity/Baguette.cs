using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entity
{
    public class Baguette : BackeryProduct
    {
        public Baguette(int hoursUntilDispose, DateTime createdOn, DateTime controlPeriod, decimal initPrice) 
            : base(hoursUntilDispose, createdOn, controlPeriod, initPrice)
        {
        }
    }
}
