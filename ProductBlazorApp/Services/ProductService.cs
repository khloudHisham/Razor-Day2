using ProductBlazorApp.Services;
using ProductBlazorApp.Models;


namespace ProductBlazorApp.Services
{
    public class ProductService:IServies<Product>
    {
        List<Product> Prdcts { get; set; } = new List<Product>();
        public ProductService()
        {
            Prdcts.Add(new Product() {
                Id = 1,
                Name = "Phone",
                Image = "p1.jpg",
                Price = 50,
                CatId=1
            });
            Prdcts.Add(new Product() {
                Id = 2,
                Name = "Laptop",
                Image = "laptop.jpg",
                Price = 800,
                CatId = 2

            });
            Prdcts.Add(new Product() {
                Id = 3,
                Name = "Camera",
                Image = "camera.jpg",
                Price = 2800,
                CatId = 3

            });
            Prdcts.Add(new Product()
            {
                Id = 4,
                Name = "Alarm",
                Image = "alarm.jpg",
                Price = 5800,
                CatId = 4

            });

        }
        public List<Product> getAll()
        {
            return Prdcts;
        }
        public Product getById(int id)
        {
            return Prdcts.FirstOrDefault(d => d.Id == id);
        }
    }
}
