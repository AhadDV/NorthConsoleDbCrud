
using Microsoft.EntityFrameworkCore;
using North.Models;
using System.Linq.Expressions;

public class CategoryService : ICategoryService
{

   private readonly northwndContext _northwndContext;

    public CategoryService(northwndContext northwndContext)
    {
        _northwndContext = northwndContext;
    }

    public async Task AddAsync(Category category)
        => await _northwndContext.Categories.AddAsync(category);

    public async Task Delete(int id)
    {
        Category exsist = await GetByIdAsync(id);

        if (exsist == null)
            throw new Exception("Item not found");

        _northwndContext.Categories.Remove(exsist);
    }

    public async Task<List<Category>> GetAll()
        => await _northwndContext.Categories.ToListAsync();

    public async Task<Category> GetByIdAsync(int id)
        => await _northwndContext.Categories.FirstOrDefaultAsync(X=>X.CategoryId==id);


    public async  Task UpdateAsync(int id)
    {
        Category exsist = await GetByIdAsync(id);

        if (exsist == null)
            throw new Exception("Item not found");

        _northwndContext.Categories.Update(exsist);
    }
     

 
}


