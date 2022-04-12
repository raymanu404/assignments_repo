using Presentation.Core;
using Domain.Models;
using Domain.ValueObjects;
using Enums;
using Domain;
using Domain.Repositories;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer1 = new Buyer
            {
                
                Email = "stefan.popescu@email.com",
                Password = "1234",
                FirstName = "Stefan",
                LastName = "Popescu",
                Sex = 'M',
                PhoneNumber = new string("07182391283"),
                Confirmed = false,
                Balance = 100
            };

            Buyer buyer2 = new Buyer
            {
               
                Email = "ana.ciurescu@email.com",
                Password = "1234",
                FirstName = "Ana",
                LastName = "Ciurescu",
                Sex = 'F',
                PhoneNumber = new string("07181232132"),
                Confirmed = false,
                Balance = 30
            };

            ComplexFoodContext _foodContext = new ComplexFoodContext();
            var repo = new BuyerRepository(_foodContext);

            //repo.GetAllBuyers().ForEach(x => Console.WriteLine(x.Email));
            var getBuyer = repo.GetAllBuyers().Where(x => x.Email.Equals("stefan.popescu@email.com")).First();
            repo.DeleteBuyer(getBuyer.Id);
            repo.Save();


            //ShoppingCore shopp1 = new ShoppingCore(buyer1);
            //shopp1.BuyCoupouns(TypeCoupons.TwentyProcent, 2);
            //shopp1.BuyCoupouns(TypeCoupons.TenProcent, 5);



            //buyer1.Coupouns.ForEach(x => Console.WriteLine($"{x.Type} : {x.UniqueCode}, {x.DateCreated}"));

        }
    }
}