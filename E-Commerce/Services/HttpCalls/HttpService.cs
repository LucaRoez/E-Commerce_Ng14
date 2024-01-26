using E_Commerce.Repository;
using E_Commerce.Services.Utilities;
using Microsoft.IdentityModel.Tokens;
using E_Commerce.Repository.Entities;
using E_Commerce.Models;
using E_Commerce.Services.DataTransfer;

namespace E_Commerce.Services.HttpCalls
{
    public class HttpService : IHttpService
    {
        private readonly CommercialContext _DbContext;
        private readonly IFactory _Factory;
        public HttpService(CommercialContext dbContext, IFactory factory)
        {
            _DbContext = dbContext;
            _Factory = factory;
        }

        ////////////////////    Get Methods    ////////////////////
        public List<DProduct> GetAllProducts(int init, int length) => _DbContext.DProducts.OrderBy(p => p.Name)
            .Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetMaleProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Gender.Name == "Male")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetFemaleProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Gender.Name == "Female")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetBabyProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Gender.Name == "Baby")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetSummerProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Category.Name == "Summer")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetWinterProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Category.Name == "Winter")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetCasualProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Category.Name == "Casual")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetFormalProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Category.Name == "Formal")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetFashionProducts(int init, int length) => _DbContext.DProducts.Where(p => p.Category.Name == "Fashion")
            .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();

        public List<DProduct> GetFilteredProducts(string? genderFilter, string? categoryFilter) => genderFilter.IsNullOrEmpty() ?
            _DbContext.DProducts.Where(Verifications.GenderFilterIsNullOrEmpty(categoryFilter)).OrderBy(p => p.Name).ToList() :
            _DbContext.DProducts.Where(Verifications.GenderFilterIsNotNullOrEmpty(genderFilter, categoryFilter)).OrderBy(p => p.Name).ToList();

        ////////////////////    Post Methods    ////////////////////
        public async Task<string> PostProduct(Product product)
        {
            try
            {
                await _DbContext.DProducts.AddAsync(_Factory.CreateModel<DProduct>(product));
                await _DbContext.SaveChangesAsync();
                return "Product loaded successfully.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PostGender(Gender gender)
        {
            try
            {
                await _DbContext.CGenders.AddAsync(_Factory.CreateModel<CGender>(gender));
                await _DbContext.SaveChangesAsync();
                return "Catalog loaded successfully.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PostCategory(Category category)
        {
            try
            {
                await _DbContext.CCategories.AddAsync(_Factory.CreateModel<CCategory>(category));
                await _DbContext.SaveChangesAsync();
                return "Catalog loaded successfully.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PostCurrency(Currency currency)
        {
            try
            {
                await _DbContext.CCurrencies.AddAsync(_Factory.CreateModel<CCurrency>(currency));
                await _DbContext.SaveChangesAsync();
                return "Catalog loaded successfully.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
