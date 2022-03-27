using Factory.Abstractions;

namespace Factory.Classes
{
    public class Pizza : PrepareFood
    {

        public void PrepareFood()
        {
            Console.WriteLine("Prepare Pizza...");
        }

    }
}
