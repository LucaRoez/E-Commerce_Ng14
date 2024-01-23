using E_Commerce.Models;

namespace E_Commerce.Services.HttpCalls
{
    public interface IHttpService
    {
        List<DProduct> GetAllProducts(int init, int end);
        List<DProduct> GetMaleProducts(int init, int end);
        List<DProduct> GetFemaleProducts(int init, int end);
        List<DProduct> GetBabyProducts(int init, int end);
        List<DProduct> GetFilteredProducts(string? genderFilter, string? categoryFilter);
    }
}
