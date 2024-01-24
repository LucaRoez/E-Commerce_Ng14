using E_Commerce.Models;

namespace E_Commerce.Services.HttpCalls
{
    public interface IHttpService
    {
        List<DProduct> GetAllProducts(int init, int length);
        List<DProduct> GetMaleProducts(int init, int length);
        List<DProduct> GetFemaleProducts(int init, int length);
        List<DProduct> GetBabyProducts(int init, int length);
        List<DProduct> GetSummerProducts(int init, int length);
        List<DProduct> GetWinterProducts(int init, int length);
        List<DProduct> GetCasualProducts(int init, int length);
        List<DProduct> GetFormalProducts(int init, int length);
        List<DProduct> GetFashionProducts(int init, int length);
        List<DProduct> GetFilteredProducts(string? genderFilter, string? categoryFilter);

        Task<string> PostProduct(DProduct product);
        Task<string> PostGender(CGender gender);
        Task<string> PostCategory(CCategory category);
    }
}
