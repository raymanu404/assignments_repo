
namespace Domain.ValueObjects
{
    public record struct Amount
    {
        public int Value { get; set; }
     
        public Amount(int value)
        {         
            if (value > 0)
            {
                Value = value;
            }
            else
            {
                //invalid amount
                Value = 0;
            }

        }

    }
}
