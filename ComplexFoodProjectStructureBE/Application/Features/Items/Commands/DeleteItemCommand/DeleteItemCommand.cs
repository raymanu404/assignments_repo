using MediatR;

namespace Application.Features.Items.Commands.DeleteItemCommand
{
    public class DeleteItemCommand : IRequest
    {
        public int ItemId { get; set; }
    }
}
