using North.Models;

northwndContext context=new northwndContext();
ICategoryService service = new CategoryService(context);

Category category = await service.GetByIdAsync(1);
Console.WriteLine(category.CategoryName);


