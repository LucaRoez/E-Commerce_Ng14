using E_Commerce.Models;

namespace E_Commerce.Services.HttpCalls
{
    public interface IHttpService
    {
        List<Product> GetAllProducts(int init, int length);
        List<Product> GetMaleProducts(int init, int length);
        List<Product> GetFemaleProducts(int init, int length);
        List<Product> GetBabyProducts(int init, int length);
        List<Product> GetSummerProducts(int init, int length);
        List<Product> GetWinterProducts(int init, int length);
        List<Product> GetCasualProducts(int init, int length);
        List<Product> GetFormalProducts(int init, int length);
        List<Product> GetFashionProducts(int init, int length);
        List<Product> GetFilteredProducts(string? genderFilter, string? categoryFilter);

        List<Gender> GetAllGenders();
        List<Category> GetAllCategories();
        List<Currency> GetAllCurrencies();


        Task<string> PostProduct(Product product);
        Task<string> PostGender(Gender gender);
        Task<string> PostCategory(Category category);
        Task<string> PostCurrency(Currency currency);
    }
}
