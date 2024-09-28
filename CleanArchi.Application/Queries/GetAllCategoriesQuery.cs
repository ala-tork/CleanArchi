using CleanArchi.Core.Interfaces;
using CleanArchi.Core.Entities;
using MediatR;

namespace CleanArchi.Application.Queries
{
    public record class GetAllCategoriesQuery():IRequest<List<Category>>;

    public class GetAllCategoriesQueryHandler(ICategoryService categoryService) : IRequestHandler<GetAllCategoriesQuery, List<Category>>
    {
        public async Task<List<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await categoryService.GetAll();
        }
    }
}
