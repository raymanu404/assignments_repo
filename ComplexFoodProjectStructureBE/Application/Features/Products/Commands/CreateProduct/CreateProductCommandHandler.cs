using MediatR;

using AutoMapper;
using Application.Contracts.Persistence;
using Domain.Models.Shopping;

namespace Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            int id = 0;
            try
            {
                var product = _mapper.Map<Product>(command.Product);
 
                await _unitOfWork.Products.AddAsync(product);
                await _unitOfWork.CommitAsync(cancellationToken);
                id = product.Id;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return id;
        }
    }
}
