using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using Domain.Models.Shopping;
using Domain.ValueObjects;
using Application.DtoModels.Buyer;

namespace Application.Features.Carts.Commands.CreateCartCommand
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCartCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {

            var buyer = await _unitOfWork.Buyers.GetByIdAsync(command.BuyerId);
            int cartID = 0;
            if(buyer != null)
            {
                command.Cart.BuyerId = buyer.Id;
                command.Cart.Code = new UniqueCode(RandomCode(6));
                command.Cart.DatePlaced = DateTime.Now;

                //var itemsByBuyerId = await _unitOfWork.Items.GetALLItemsByBuyerId(buyer.Id);
                //command.Cart.TotalPrice = itemsByBuyerId.Sum(x => new Price(x.Amount.Value * x.Product.Price.Value));

                var cart = _mapper.Map<ShoppingCart>(command.Cart);

                await _unitOfWork.Carts.AddAsync(cart);
                await _unitOfWork.CommitAsync(cancellationToken);

                cartID = cart.Id;
            }

            return cartID;
        }

        private static string RandomCode(int length)
        {
            var ran = new Random();

            var b = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string random = "";

            for (var i = 0; i < length; i++)
            {
                var a = ran.Next(b.Length);
                random = random + b.ElementAt(a);
            }

            return random;
        }
    }
}
