using Factory.Abstractions;

namespace Factory.Classes
{
    public class Soup : PrepareFood
    {
        public void PrepareFood()
        {
            Console.WriteLine("Prepare soup... ");
        }

    }
}
