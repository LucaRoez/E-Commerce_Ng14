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
        public Product GetProduct(int id)
        {
            DProduct dProduct = _DbContext.DProducts.FirstOrDefault(p => p.Id == id);
            Product product = _Factory.CreateModel<Product>(dProduct);

            return product;
        }
        
        public List<Product> GetAllProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetMaleProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Gender.Name == "Male")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFemaleProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Gender.Name == "Female")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetBabyProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Gender.Name == "Baby")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetSummerProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Category.Name == "Summer")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetWinterProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Category.Name == "Winter")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetCasualProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Category.Name == "Casual")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFormalProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Category.Name == "Formal")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFashionProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.DProducts.Where(p => p.Category.Name == "Fashion")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFilteredProducts(string? genderFilter, string? categoryFilter)
        {
            List<DProduct> dProducts = genderFilter.IsNullOrEmpty() ?
                _DbContext.DProducts.Where(Verifications.GenderFilterIsNullOrEmpty(categoryFilter)).OrderBy(p => p.Name).ToList() :
                _DbContext.DProducts.Where(Verifications.GenderFilterIsNotNullOrEmpty(genderFilter, categoryFilter)).OrderBy(p => p.Name).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }


        public List<Gender> GetAllGenders()
        {
            List<CGender> cGenders = _DbContext.CGenders.ToList();
            List<Gender> genders = cGenders.Select(cG => _Factory.CreateModel<Gender>(cG)).ToList();

            return genders;
        }
        
        public List<Category> GetAllCategories()
        {
            List<CCategory> cCategories = _DbContext.CCategories.ToList();
            List<Category> categories = cCategories.Select(cC => _Factory.CreateModel<Category>(cC)).ToList();

            return categories;
        }
        
        public List<Currency> GetAllCurrencies()
        {
            List<CCurrency> cCurrencies = _DbContext.CCurrencies.ToList();
            List<Currency> currencies = cCurrencies.Select(cC => _Factory.CreateModel<Currency>(cC)).ToList();

            return currencies;
        }


        ////////////////////    Post Methods    ////////////////////
        public async Task<string> PostProduct(Product product)
        {
            try
            {
                await _DbContext.DProducts.AddAsync(_Factory.CreateEntity<DProduct>(product));
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
                await _DbContext.CGenders.AddAsync(_Factory.CreateEntity<CGender>(gender));
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
                await _DbContext.CCategories.AddAsync(_Factory.CreateEntity<CCategory>(category));
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
                await _DbContext.CCurrencies.AddAsync(_Factory.CreateEntity<CCurrency>(currency));
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
