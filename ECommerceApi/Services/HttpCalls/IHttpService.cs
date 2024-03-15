using ECommerceApi.Models;

namespace ECommerceApi.Services.HttpCalls
{
    public interface IHttpService
    {
        object GetProduct(int id);
        List<object> GetAllProducts(int init, int length);
        List<object> GetMaleProducts(int init, int length);
        List<object> GetFemaleProducts(int init, int length);
        List<object> GetBabyProducts(int init, int length);
        List<object> GetSummerProducts(int init, int length);
        List<object> GetWinterProducts(int init, int length);
        List<object> GetCasualProducts(int init, int length);
        List<object> GetFormalProducts(int init, int length);
        List<object> GetFashionProducts(int init, int length);
        List<object> GetFilteredProducts(string? genderFilter, string? categoryFilter);

        List<object> GetAllImages();
        List<object> GetAllGenders();
        List<object> GetAllCategories();
        List<object> GetAllCurrencies();


        Task<string> PostProduct(Product product);
        Task<string> PostImage(Image image);
        Task<string> LinkImageToProduct(Image image, Product product, int slot);
        Task<string> PostGender(Gender gender);
        Task<string> PostCategory(Category category);
        Task<string> PostCurrency(Currency currency);
    }
}
