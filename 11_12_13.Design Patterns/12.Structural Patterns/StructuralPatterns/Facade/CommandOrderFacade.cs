//folosim aceeasi clasa ca exemplu din proiectul Proxy
using Proxy.Classes;
using Proxy.Abstractions;
using Facade.Domain;

namespace Facade
{
    public class CommandOrderFacade
    {
        public ClientData ClientData { get; set; }
        private List<Order> _orders = new List<Order>();
        private List<Menu> _menus = new List<Menu>();
        private static int count = 0;
        private float _total = 0;
        public CommandOrderFacade(ClientData clientData)
        {

           ClientData = clientData;

        }

        public void ChooseMenu(Menu menu, int amount)
        {

            _orders.Add( new Order() { Id = count++ , UserId = ClientData.UserId, MenuId = menu.Id, Amount = amount, Status = OrderStatus.Placed, TotalPrice = (menu.Price * amount) });
            _menus.Add(menu);

            _orders.Where(order => order.UserId == ClientData.UserId).ToList().ForEach(order => _total += order.TotalPrice);          
            Console.WriteLine($"Your order was placed & {menu.Title} ...");

            
        }
        public void PayYourMenu()
        {
          
            PaymentLibrary payment = new PaymentLibrary();

            payment.IniliazePayment();
            payment.SettleTransaction();

            if (payment.ValidateCard(ClientData))
            {
                switch (ClientData.CreditCard)
                {
                    case CardType.Visa:
                        payment.PayWithVisa(ClientData, _total);
                        break;
                    case CardType.MasterCard:
                        payment.PayWithMasterCard(ClientData, _total);
                        break;
                    case CardType.Maestro:
                        payment.PayWithMaestro(ClientData, _total);
                        break;
                    default:
                        throw new Exception("Some error with card type...");

                }

                _orders.Where(order => order.UserId == ClientData.UserId).ToList().ForEach(order => SettleCommand(order)); 
                
                Console.WriteLine($"Total price for your order: {_total} \n");

            }
            else
                Console.WriteLine("Unauthorized... Check again your card data\n");

        }

        private void SettleCommand(Order order)
        {
            order.Status = OrderStatus.InProgress;
            Console.WriteLine($"Status: {order.Status}");                         
        }
           
    }
}
