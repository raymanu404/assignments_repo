using MediatR;
using Application.DtoModels.OrderItem;

namespace Application.Features.Items.Commands.UpdateItemCommand
{
    public class UpdateCartIdForOrderItemCommand : IRequest
    {
        public int ItemId { get; set; }
        public int CartId { get; set; }
    }
}
