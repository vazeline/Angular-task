using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Entity
{
    public abstract class BackeryProduct : IBackery
    {
        protected virtual decimal STANDARD_DISCOUNT { get => 0.02m; }
        public const decimal MAX_PRICE = 100m;

        public DateTime CreatedOn { get; }
        public DateTime ControlPeriod { get; }
        public decimal InitialPrice { get; }
        protected int HoursUntilDispose { get; }

        public BackeryProduct(int hoursUntilDispose, DateTime createdOn, DateTime controlPeriod, decimal initPrice)
        {
            this.HoursUntilDispose = hoursUntilDispose;
            this.CreatedOn = createdOn;
            this.ControlPeriod = controlPeriod;
            this.InitialPrice = initPrice;
        }

        public virtual bool ShouldBeDisposed
        {
            get
            {
                if (DateTime.Now > CreatedOn.AddHours(HoursUntilDispose))
                    return true;
                return false;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return CalculatePriceAtTime(DateTime.Now);
            }
        }

        private decimal CalculatePriceAtTime(DateTime time)
        {
            int datediff = (int)(time - CreatedOn).TotalHours;
            decimal price = InitialPrice * (1 - STANDARD_DISCOUNT * datediff);
            if (price < 0) return 0m;
            if (price > MAX_PRICE)
                return MAX_PRICE;

            return price;
        }

        public virtual DateTime NextPriceTime 
        { 
            get 
            {
                var datediff =(int)(DateTime.Now - this.CreatedOn).TotalHours;
                return this.CreatedOn.AddHours(datediff + 1);
            } 
        }
        public virtual decimal NextPrice
        {
            get
            {
                return CalculatePriceAtTime(NextPriceTime);
            }
        }
    }
}
