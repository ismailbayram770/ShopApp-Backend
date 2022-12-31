﻿using ExampleProject.Back.Core.Application.Features.CQRS.Commands;
using ExampleProject.Back.Core.Application.Interfaces;
using ExampleProject.Back.Core.Domain;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedProduct = await this.repository.GetByIdAsync(request.Id);
            if (updatedProduct != null) 
            {
                updatedProduct.CategoryId= request.CategoryId;
                updatedProduct.Stock= request.Stock;
                updatedProduct.Price= request.Price;
                updatedProduct.Name = request.Name;
                await this.repository.UpdateAsync(updatedProduct);
            }
            return Unit.Value;
        }
    }
}
