using System;

namespace WebAPI.Entity
{
    public interface IBackery
    {
        System.DateTime ControlPeriod { get; }
        decimal InitialPrice { get; }
        decimal Price { get; }
        bool ShouldBeDisposed { get; }


        DateTime NextPriceTime { get; }
        decimal NextPrice { get; }
    }
}