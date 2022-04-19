using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Models.Roles;
using MediatR;

namespace Application.Features.Buyers.Commands.CreateBuyer;

public class CreateBuyerCommandHandler : IRequestHandler<CreateBuyerCommand, int>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateBuyerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateBuyerCommand command, CancellationToken cancellationToken)
    {
        var buyer = _mapper.Map<Buyer>(command.Buyer);

        await _unitOfWork.Buyers.AddAsync(buyer);
        await _unitOfWork.CommitAsync(cancellationToken);

        return buyer.Id;
    }
}