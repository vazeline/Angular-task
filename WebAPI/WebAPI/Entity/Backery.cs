using System;
using WebAPI.Entity;

namespace WebAPI.Services
{
    /// <summary>
    /// Backery fabric class
    /// </summary>
    public class Backery
    {
        private readonly double CONTROL_PERIOD_DAYS = 2;
        private readonly int MAX_HOURS = 72;
        Random random = new Random();

        public IBackery NewItem()
        {
            DateTime created = DateTime.Now;
            DateTime controlPeriod = created.AddDays(CONTROL_PERIOD_DAYS);
            int type = (int)(5 * random.NextDouble());
            decimal price = (decimal)random.NextDouble() * BackeryProduct.MAX_PRICE;
            int hours = random.Next(1,MAX_HOURS);

            return (type) switch
            {
                0 => new Baguette(hours, created, controlPeriod, price),
                1 => new Croissant(hours, created, controlPeriod, price),
                2 => new Loaf(hours, created, controlPeriod, price),
                3 => new Pretzel(hours, created, controlPeriod, price),
                4 => new SourCream(hours, created, controlPeriod, price),
                _ => throw new NotImplementedException(),
            };
        }
    }
}