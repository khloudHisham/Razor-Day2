using ProductBlazorApp.Services;
using ProductBlazorApp.Models;


namespace ProductBlazorApp.Services
{
    public class CategoryService: IServies<Category>
    {
        List<Category> Catgs = new List<Category>();
        public CategoryService()
        {
            Catgs.Add(new Category { Id = 1, Name = "Phones" });
            Catgs.Add(new Category { Id = 2, Name = "Labtops"  });
            Catgs.Add(new Category { Id = 3, Name = "Cameras"  });
            Catgs.Add(new Category { Id = 4, Name = "Alarms" });
        }
        public List<Category> getAll()
        {
            return Catgs;
        }
        public Category getById(int id)
        {
            return Catgs.FirstOrDefault(e => e.Id == id);
        }
    }
}
