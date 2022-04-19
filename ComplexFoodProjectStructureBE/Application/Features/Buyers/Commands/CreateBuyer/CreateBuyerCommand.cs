using Domain.ValueObjects;
using MediatR;
using Application.DtoModels.Buyer;

namespace Application.Features.Buyers.Commands.CreateBuyer;

public class CreateBuyerCommand : IRequest<int>
{
    public BuyerDto Buyer { get; set; }   
}