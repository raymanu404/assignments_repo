using System;

namespace ActionAndFunc;

class Program
{
    //Lamda Expressions
    // reprezinta o functie anonimica
    // sunt de doua tipuri :
    // 1. Expression Lambda - Func, returneaza ceva
    // Func<cati parametrii vrei, type-ul rezultatului pentru returnare> nume_random = (item) => item * item 


    // 2. Statement Lambda - Action, void
    // Action<cati parametrii vrei tu> ce_nume_vrei_tu = (item) =>{ if(item === 0) Console.Writeline("wow"); }  
    static void Main(string[] args)
    {
        //Func
        //01
        int[] numbers = new int[] { 1, 0, -23, 3000, 2, 10 };
        int max = GetMaximumNumber(numbers, (a,b) => Math.Max(a,b) ); 
        Console.WriteLine(max);

        //02
        string myWord = "Happy BirthDay,Darling!";
        Func<string> func = () => myWord;
        Console.WriteLine(RepeatString(3,func));


        //Action
        //01
        Action<int> action1 = (a) =>
        {
            Console.WriteLine(a);
        };

        //02
        Action<string> action2 = (item) =>
        {
           string res = "";
           foreach(char c in item.ToCharArray())
           {
                res += c + " ";
           }
           Console.WriteLine(res);
        };

        action1(2);
        action2("amdaris");
    }

    //01 Func
    static int GetMaximumNumber(int[] numbers, Func<int,int,int> maximum) {

        int maxim = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            maxim = maximum(maxim, numbers[i]);
        }
        return maxim;
    }

    //02 Func
    static string RepeatString(int times,Func<string> repeat)
    {
        string result = "";
        for(int i = 0; i < times; i++)
        {
            result += repeat();
        }
        return result;
    }

    static void Display<T>(T[] items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
