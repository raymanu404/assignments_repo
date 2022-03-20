using System;
using ExtensionMethods.Classes;

namespace ExtensionMethods;
class Program
{
    static void Main(string[] args)
    {
        Product product = new Product() { Id = 1, Name = "Rosii", Description = "Rosii din Romania", Price = 2.3f, Amount = 4, CurrentCurrency = Currency.RON };
        product.ChangeDescription("Rosii din Spania");
        product.ChangeCurrentCurrency(Currency.EURO);

        Console.WriteLine("Inainte de scumpire");
        product.TotalPrice = product.CalculateTotalPrice();
        Console.WriteLine(product.TotalPrice.ToString());

       
        Console.WriteLine("Dupa scumpire");
        product.Price = product.RaisePrice(.25f);
        product.TotalPrice = product.CalculateTotalPrice();
        Console.WriteLine(product.TotalPrice.ToString());

        product.ChangeName("Rosii Cherry");

        string myHelloWorld = "This code produces the following output.Some random stuff here!";
        myHelloWorld = myHelloWorld.RemoveSpaces();
        Console.WriteLine(myHelloWorld);

        int[] numbers = new int[] { 1,2,3,5,6,7,8,23,16};
        int sum = numbers.SumOfNumbers();
        Console.WriteLine($"Suma totala : {sum.ToString()}");
    }

}

