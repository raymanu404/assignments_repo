using System.Diagnostics.CodeAnalysis;

HashSet<int> intHashSet  = new HashSet<int>(); //hashset-urile nu permit dublicarile

intHashSet.Add(2);
intHashSet.Add(2);
intHashSet.Add(3);
intHashSet.Add(5);



HashSet<string> stringHashSet = new HashSet<string>();
stringHashSet.Add("s1");
stringHashSet.Add("s2");
stringHashSet.Add("s1");

HashSet<string> stringHashSet2 = new(new StringComparer());
stringHashSet2.Add("s122");
stringHashSet2.Add("s8");
stringHashSet2.Add("s2");
stringHashSet2.Add("s1"); //returneaza s1 pentru ca tine cont de lungimi cum sunt toate egale afiseaza doar primul element intalnit



foreach (var i in stringHashSet2)
{
    Console.WriteLine(i);
}

var order = new Order();
if (order.Status == OrderStatus.Deleted)
{
    //do something
}else if(order.Status == OrderStatus.Canceled)
{
    //do elsething
}

public class StringComparer : IEqualityComparer<string>
{
    public bool Equals(string x, string y)
    {       
        return x.Length == y.Length;

    }

    public int GetHashCode([DisallowNull] string obj)
    {
        return obj.Length.GetHashCode();
    }
}



public class Order
{
    public OrderStatus Status { get; set; }
   
}
public enum OrderStatus
{
    Receveived,
    Canceled,
    Deleted
}


