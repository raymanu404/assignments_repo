using Domain.Models;
using Enums;

namespace Presentation.Core
{
    public class ShoppingCore
    {
        private Buyer _buyer;
        public ShoppingCore(Buyer buyer) 
        {
            _buyer = buyer;
        }

        public void BuyCoupouns(TypeCoupons type, int amount)
        {
            _buyer.Coupouns = new List<Coupoun>();
            if (_buyer.Confirmed)
            {
                if(_buyer.Balance > 0)
                {
                    int totalPrice = 0;
                    switch (type)
                    {
                        case TypeCoupons.TenProcent:
                            totalPrice = amount * 10;                          
                            break;
                        case TypeCoupons.TwentyProcent:
                            totalPrice = amount * 20;
                            break;
                        case TypeCoupons.ThirtyProcent:
                            totalPrice = amount * 30;
                            break;
                    }

                    if (_buyer.Balance >= totalPrice)
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            _buyer.Coupouns.Add(new Coupoun() { 
                                Id = i,
                                Type = type,
                                DateCreated = DateTime.Now,
                                UniqueCode = RandomCode(6),
                                UserId = _buyer.Id 
                            });
                        }

                        _buyer.Balance = _buyer.Balance - totalPrice;
                        Console.WriteLine($"You had paid {amount} of type {type} Coupons and current balance : {_buyer.Balance }");
                    }
                    else
                    {
                        Console.WriteLine("You don't have balance in your account...");
                    }
                }
                else
                {
                    Console.WriteLine("You don't have balance in your account...");
                }
                
            }
            else
            {
                Console.WriteLine("you must be confirmed...");
            }
           
        }


        private string RandomCode(int length)
        {
            Random ran = new Random();

            string b = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(52);
                random = random + b.ElementAt(a);
            }

            return random;
        }


    }
}
