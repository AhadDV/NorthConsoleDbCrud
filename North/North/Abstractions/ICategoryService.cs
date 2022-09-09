
using North.Models;

public interface ICategoryService
{
    public Task AddAsync(Category category);
    public Task UpdateAsync(int id);

    public Task Delete(int id);
    public Task<Category> GetByIdAsync(int id);
    public Task<List<Category>> GetAll();
}
