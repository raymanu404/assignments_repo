using Presentation.Core;
using Domain.Models;
using Domain.ValueObjects;
using Enums;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer1 = new Buyer
            {
                Id = 1,
                Email = "stefan.popescu@email.com",
                Password = "1234",
                FirstName = "Stefan",
                LastName = "Popescu",
                Sex = 'M',
                PhoneNumber = new PhoneNumber("07182391283"),
                Confirmed = false,
                Balance = 100
            };

            Buyer buyer2 = new Buyer
            {
                Id = 2,
                Email = "ana.ciurescu@email.com",
                Password = "1234",
                FirstName = "Ana",
                LastName = "Ciurescu",
                Sex = 'F',
                PhoneNumber = new PhoneNumber("07181232132"),
                Confirmed = false,
                Balance = 30
            };

            BuyerCore.RegisterBuyer(buyer1);
            BuyerCore.RegisterBuyer(buyer2);

            foreach (var buyer in BuyerCore.GetBuyers())
            {
                Console.WriteLine($" Email: {buyer.Email} is confirmated: {buyer.Confirmed} {buyer.Id}");
            }

            ShoppingCore shopp1 = new ShoppingCore(buyer1);
            shopp1.BuyCoupouns(TypeCoupons.TwentyProcent, 2);
            shopp1.BuyCoupouns(TypeCoupons.TenProcent, 5);


            buyer1.Coupouns.ForEach(x => Console.WriteLine($"{x.Type} : {x.UniqueCode}, {x.DateCreated}"));

        }
    }
}