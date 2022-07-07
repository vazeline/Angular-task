using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entity
{
    public class SourCream : BackeryProduct
    {
        protected override decimal STANDARD_DISCOUNT { get => base.STANDARD_DISCOUNT * 2; }
     
        public SourCream(int hoursUntilDispose, DateTime createdOn, DateTime controlPeriod, decimal initPrice) 
            : base(hoursUntilDispose, createdOn, controlPeriod, initPrice)
        {
        }

    }
}
