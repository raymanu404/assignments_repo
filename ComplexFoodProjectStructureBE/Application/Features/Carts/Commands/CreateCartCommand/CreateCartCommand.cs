using Application.DtoModels.Cart;
using MediatR;

namespace Application.Features.Carts.Commands.CreateCartCommand
{
    public class CreateCartCommand : IRequest<int>
    {
        public int BuyerId { get; set; }
        public CartDto Cart { get; set; }

    }
}
