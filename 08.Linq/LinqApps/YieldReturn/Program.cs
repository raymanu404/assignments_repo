using System;

namespace YieldReturn;

class Program
{
    static List<int> listInt = new List<int>();
    
    static void Main(string[] args)
    {
        FillList();
        firstExampleYield();
        secondExampleYield();    
    }
    private static void FillList()
    {
        listInt.Add(1);
        listInt.Add(2);
        listInt.Add(3);
        listInt.Add(4);
        listInt.Add(5);
        listInt.Add(6);
        listInt.Add(7);
    }
    private static void firstExampleYield()
    {
       

        foreach(var i in FilterGreaterThanThree(listInt))
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //schema e urmatoarea cu yield ( ne imaginam ca si feed ul de pe instagram
        //nu astepti sa se incarce toate pozele din lista, se incarca la inceput 2 3 poze si dupa ce dai scroll iti mai descarca astfel e mult mai eficient

        // deci logica e urmatoarea:
        //din caller merge mai departe in functie, in functie se executa normal iar cand e ok cconditia returneaza item-ul inapoi in caller, afiseaza
        //dupa ce afiseaza caller apeleaza din nou metoda de unde a ramas si tot asa
    }  
    private static IEnumerable<int> FilterGreaterThanThree(List<int> list)
    {
        foreach(var i in list)
        {
            //daca nu foloseam yield faceam o lista locala, adaugam toate item -ele care satisfaceau conditia si returnam
            if(i > 3)
            {
                yield return i;
            }
        }
    }

    private static void secondExampleYield()
    {
        foreach(var i in RunningTotal())
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    private static IEnumerable<int> RunningTotal()
    {
        int sum = 0;
        foreach(var i in listInt)
        {
            sum += i;
            yield return sum;

        }
    }
    
}