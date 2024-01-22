using E_Commerce.Models;
using E_Commerce.Repository;
using E_Commerce.Services.Utilities;
using Microsoft.IdentityModel.Tokens;

namespace E_Commerce.Services.HttpCalls
{
    public class HttpService : IHttpService
    {
        private readonly ICommercialContext _DbContext;
        public HttpService(ICommercialContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<DProduct> GetAllProducts(int init, int end) => _DbContext.DProducts.OrderBy(p => p.Name).Skip((init - 1) * end).Take(end).ToList();

        public List<DProduct> GetMaleProducts(int init, int end) => _DbContext.DProducts.Where(p => p.Gender.Name == "Male").Skip((init - 1) * end).Take(end).ToList();

        public List<DProduct> GetFemaleProducts(int init, int end) => _DbContext.DProducts.Where(p => p.Gender.Name == "Female").Skip((init - 1) * end).Take(end).ToList();

        public List<DProduct> GetBabyProducts(int init, int end) => _DbContext.DProducts.Where(p => p.Gender.Name == "Baby").Skip((init - 1) * end).Take(end).ToList();

        public List<DProduct> GetFilteredProducts(string? genderFilter, string? categoryFilter) =>
            genderFilter.IsNullOrEmpty() ? _DbContext.DProducts.Where(Verifications.GenderFilterIsNullOrEmpty(categoryFilter)).ToList() :
            _DbContext.DProducts.Where(Verifications.GenderFilterIsNotNullOrEmpty(genderFilter, categoryFilter)).ToList();
    }
}
