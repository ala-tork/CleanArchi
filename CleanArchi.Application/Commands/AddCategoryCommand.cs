using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;
using CleanArchi.Core.Interfaces;
using MediatR;

namespace CleanArchi.Application.Commands
{
    public record class AddCategoryCommand(CategoryDto categ): IRequest<Category>;

    public class AddCategoryCommandHandler(ICategoryService categoryService) : IRequestHandler<AddCategoryCommand, Category>
    {
        public async  Task<Category> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
           return  await categoryService.Add(request.categ);
        }
    }

}
