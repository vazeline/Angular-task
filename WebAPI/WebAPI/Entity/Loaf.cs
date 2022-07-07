using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Entity
{
    public class Loaf : BackeryProduct
    {
        public Loaf(int hoursUntilDispose, DateTime createdOn, DateTime controlPeriod, decimal initPrice) 
            : base(hoursUntilDispose, createdOn, controlPeriod, initPrice)
        {
        }
    }
}
