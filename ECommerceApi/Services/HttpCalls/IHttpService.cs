using ECommerce.Models;

namespace ECommerce.Services.HttpCalls
{
    public interface IHttpService
    {
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetAllProducts(int init, int length);
        Task<List<Product>> GetMaleProducts(int init, int length);
        Task<List<Product>> GetFemaleProducts(int init, int length);
        Task<List<Product>> GetBabyProducts(int init, int length);
        Task<List<Product>> GetSummerProducts(int init, int length);
        Task<List<Product>> GetWinterProducts(int init, int length);
        Task<List<Product>> GetCasualProducts(int init, int length);
        Task<List<Product>> GetFormalProducts(int init, int length);
        Task<List<Product>> GetFashionProducts(int init, int length);
        Task<List<Product>> GetFilteredProducts(string? genderFilter, string? categoryFilter);

        Task<List<Gender>> GetAllGenders();
        Task<List<Category>> GetAllCategories();
        Task<List<Currency>> GetAllCurrencies();


        Task<string> PostProduct(Product product);
        Task<string> PostGender(Gender gender);
        Task<string> PostCategory(Category category);
        Task<string> PostCurrency(Currency currency);
    }
}
