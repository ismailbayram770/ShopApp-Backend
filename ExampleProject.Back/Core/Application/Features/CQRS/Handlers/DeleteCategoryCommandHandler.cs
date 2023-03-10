using ExampleProject.Back.Core.Application.Features.CQRS.Commands;
using ExampleProject.Back.Core.Application.Interfaces;
using ExampleProject.Back.Core.Domain;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IRepository<Category> repository;

        public DeleteCategoryCommandHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedCategory = await this.repository.GetByIdAsync(request.Id);
            if (deletedCategory != null)
            {
                await this.repository.RemoveAsync(deletedCategory);
            }
            return Unit.Value;
        }
    }
}
