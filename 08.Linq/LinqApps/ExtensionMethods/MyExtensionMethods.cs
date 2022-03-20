using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods.Classes;

namespace ExtensionMethods
{
    public static class MyExtensionMethods
    {
        public static float CalculateTotalPrice(this Product product)
        {
            return product.Price * product.Amount;
        }

        public static float RaisePrice(this Product product, float ratePrice = .16f)
        {
            return product.Price * (ratePrice + 1); 
        }

        public static void ChangeCurrentCurrency(this Product product, Currency currency)
        {

            product.CurrentCurrency = currency;
        }

        public static void ChangeDescription(this Product product, string newDescription)
        {
            product.Description = newDescription;
        }
        public static void ChangeName(this Product product, string newName)
        {
            product.Name = newName;
            
        }

        public static string RemoveSpaces(this string myString)
        {
            string[] result = myString.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return String.Concat(result);
        }

        public static int SumOfNumbers(this int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
               
            }
            return sum;
        }




    }
}
