using E_Commerce.Models;

namespace E_Commerce.Services.HttpCalls
{
    public interface IHttpService
    {
        List<DProduct> GetAllProducts(int init, int length);
        List<DProduct> GetMaleProducts(int init, int length);
        List<DProduct> GetFemaleProducts(int init, int length);
        List<DProduct> GetBabyProducts(int init, int length);
        List<DProduct> GetFilteredProducts(string? genderFilter, string? categoryFilter);
    }
}
