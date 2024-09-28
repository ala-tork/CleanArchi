using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;


namespace CleanArchi.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);

        Task<Category> Add(CategoryDto category);

        Task<Category> Update(int id, CategoryDto category);

        Task<Category> Delete(int id);
    }
}
