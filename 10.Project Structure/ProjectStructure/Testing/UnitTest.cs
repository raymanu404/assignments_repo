using NUnit.Framework;
using Domain.Models;
using Presentation.Core;
using Enums;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestFixture]
    public class UnitTest
    {
        Buyer buyer;
        [SetUp]
        public void Init()
        {
            buyer = new Buyer { FirstName = "Radu", LastName = "Serban", Balance = 100, Confirmed = true };
        }


        [TestCase]
        public void InitialBalanceForBuyer1Test()
        {

            Assert.AreEqual(0, buyer.Balance);
        }


        public static IEnumerable<TestCaseData> CheckDefaultBalanceForNewBuyers
        {
            //the main point about properties from Class is about: don't let clients from outside to contro l the inside of objects. 
            //trebuie controlate proprietatile din metode adica sa nu lasam posibilitatea sa fie controlate "fara vama" prin seturi
            get
            {
                yield return new TestCaseData(new Buyer { FirstName = "Andrei", LastName = "Sebastian", Balance = 100, Confirmed = true });
                yield return new TestCaseData(new Buyer { FirstName = "Marius", LastName = "Popescu", Balance = 30, Confirmed = true });
                yield return new TestCaseData(new Buyer { FirstName = "Maria", LastName = "Nicolae", Confirmed = true });
                yield return new TestCaseData(new Buyer { FirstName = "Adrian", LastName = "Mustata", Confirmed = true });
            }
        }


        [TestCaseSource("CheckDefaultBalanceForNewBuyers")]
        public void InitialBalanceForBuyersTest(Buyer buyer)
        {
            Assert.AreEqual(0, buyer.Balance);
        }


        [Test]
        public void ConfirmedBuyerTest()
        {
            Assert.AreEqual(true, buyer.Confirmed);
        }

        [Test]
        public void BalanceAfterShoppingTest()
        {
            buyer.Confirmed = true;
            buyer.Balance = 100;

            ShoppingCore shopp1 = new ShoppingCore(buyer);
            shopp1.BuyCoupouns(TypeCoupons.TwentyProcent, 1);

            Assert.AreEqual(true, buyer.Balance > 70);
        }

        [Test]
        public void CheckNumberOfCoupounsTest()
        {
            buyer.Confirmed = true;
            buyer.Balance = 100;

            ShoppingCore shopp1 = new ShoppingCore(buyer);
            shopp1.BuyCoupouns(TypeCoupons.TwentyProcent, 3);

            Assert.AreEqual(true, buyer.Coupouns.Count <= 5);
        }

        [TestCase(50)]
        [TestCase(70)]
        [TestCase(20)]
        [TestCase(40)]
        public void CheckBalanceForBuyerTest(float balance)
        {
            ShoppingCore shopp1 = new ShoppingCore(buyer);
            shopp1.BuyCoupouns(TypeCoupons.TenProcent, 5);

            Assert.AreEqual(true, buyer.Balance > balance);
        }
    }
}
