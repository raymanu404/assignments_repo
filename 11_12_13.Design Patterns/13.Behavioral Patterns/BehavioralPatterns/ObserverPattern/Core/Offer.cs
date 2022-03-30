using System;

namespace ObserverPattern.Core
{
   public record Offer(string Title, string Description, DateTime DateTime, float Price, float Discount)
    {
        public float TotalPrice { get; set; } = Price -  (Price * Discount);
    };

}
