using MediatR;
using Application.DtoModels.OrderItem;

namespace Application.Features.Items.Queries.GetItemById
{
    public class GetItemByIdQuery : IRequest<OrderItemDto>
    {
        public int ItemId { get; set; }
    }
}
