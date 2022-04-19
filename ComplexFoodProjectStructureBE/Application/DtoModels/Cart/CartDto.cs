using Domain.ValueObjects;
using Application.DtoModels.OrderItem;
using Application.DtoModels.Buyer;

namespace Application.DtoModels.Cart
{
    public class CartDto
    {
        private Price _totalPrice;
        public Price TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                _totalPrice = value;
            }
        }
        public DateTime DatePlaced { get; set; }
        public Discount Discount { get; set; }

        private UniqueCode _code;
        public UniqueCode Code
        {
            get { return _code; }
            set
            {
                _code = value;
            }
        }
        //public BuyerDto Buyer { get; set; }
        public int BuyerId { get; set; }
        //public ICollection<OrderItemDto> Items { get; set; }
    }
}
