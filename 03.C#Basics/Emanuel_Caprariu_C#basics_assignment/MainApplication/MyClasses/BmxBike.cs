namespace MyClasses
{
    public class BmxBike : Bike
    {
        public void DoSomeTrick()
        {
            Console.WriteLine("Tabletop");
        }

        public void DoSomeTrick(String trick)
        {
            Console.WriteLine(trick);
        }
        public void DoSomeTrick(String trick, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(trick);
            }

        }

        public override void ShowDetails()
        {
            Console.WriteLine("------------ BMX BIKE -----");
            base.ShowDetails();

        }

    }
}
