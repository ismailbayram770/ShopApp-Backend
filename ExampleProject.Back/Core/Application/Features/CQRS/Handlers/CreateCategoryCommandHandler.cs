using ExampleProject.Back.Core.Application.Features.CQRS.Commands;
using ExampleProject.Back.Core.Application.Interfaces;
using ExampleProject.Back.Core.Domain;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest>
    {
        private readonly IRepository<Category> repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Category
            {
                Definition= request.Definition
            });

            return Unit.Value;
        }
    }
}
