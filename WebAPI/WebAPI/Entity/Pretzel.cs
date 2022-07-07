using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entity
{
    public class Pretzel : BackeryProduct
    {
        protected override decimal STANDARD_DISCOUNT 
        {
            get
            {
                int datediff = (int)(this.ControlPeriod - this.CreatedOn).TotalHours;

                return .5m / datediff;
            }
        }

        public Pretzel(int hoursUntilDispose, DateTime createdOn, DateTime controlPeriod, decimal initPrice) 
            : base(hoursUntilDispose, createdOn, controlPeriod, initPrice)
        {
        }
    }
}
