using ProductBlazorApp.Models;

namespace ProductBlazorApp.Services
{
    public interface IServies<T>
    {
        List<T> getAll();
        T getById(int id);
    }
}
