using Factory.Abstractions;

namespace Factory.Classes
{
    public class Burger : PrepareFood
    {

        public void PrepareFood()
        {
            Console.WriteLine("Prepare burger... ");
        }    
      
    }
}
