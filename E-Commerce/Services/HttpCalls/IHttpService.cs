using E_Commerce.Models;

namespace E_Commerce.Services.HttpCalls
{
    public interface IHttpService
    {
        List<DProduct> GetAllProducts(int init, int end);
    }
}
