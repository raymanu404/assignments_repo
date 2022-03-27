
namespace Factory.Abstractions
{
    public interface IPrepareFood
    {
        string Title { get; set; }
        string Description { get; set; }
        float Price { get; set; }
        int Amount { get; set; }
        void PrepareFood();

        void ShowMenu();

    }
}
