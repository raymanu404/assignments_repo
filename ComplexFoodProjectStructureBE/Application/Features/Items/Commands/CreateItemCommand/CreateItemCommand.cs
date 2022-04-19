using MediatR;
using Application.DtoModels.OrderItem;

namespace Application.Features.Items.Commands.CreateItemCommand
{
    public class CreateItemCommand : IRequest<int>
    {
        public OrderItemDto OrderItem { get; set; }
        public int BuyerId { get; set; }
    }
}
