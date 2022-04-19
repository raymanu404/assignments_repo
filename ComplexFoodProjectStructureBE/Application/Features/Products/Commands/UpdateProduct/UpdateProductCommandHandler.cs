﻿using MediatR;
using Application.Contracts.Persistence;

namespace Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var productToUpdate = await _unitOfWork.Products.GetByIdAsync(request.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Category = request.Product.Category != null ? request.Product.Category : productToUpdate.Category;
                productToUpdate.Title = request.Product.Title != null ? request.Product.Title : productToUpdate.Title;
                productToUpdate.Description = request.Product.Description != null ? request.Product.Description : productToUpdate.Description;
                productToUpdate.Price = request.Product.Price.Value != null ? request.Product.Price : productToUpdate.Price;
                productToUpdate.Image = request.Product.Image != null ? request.Product.Image : productToUpdate.Image;
                productToUpdate.DateCreated = request.Product.DateCreated != null ? request.Product.DateCreated : productToUpdate.DateCreated;
                productToUpdate.DateUpdated = request.Product.DateUpdated != null ? request.Product.DateUpdated : productToUpdate.DateUpdated;
                productToUpdate.IsInStock = request.Product.IsInStock != null ? request.Product.IsInStock : productToUpdate.IsInStock;
                           
                await _unitOfWork.CommitAsync(cancellationToken);
            }

            return Unit.Value;
        }
    }
}
