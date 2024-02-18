using ECommerce.Repository;
using ECommerce.Services.Utilities;
using ECommerce.Repository.Entities;
using ECommerce.Models;
using ECommerce.Services.DataTransfer;

namespace ECommerce.Services.HttpCalls
{
    public class HttpService : IHttpService
    {
        private readonly IRepository _DbContext;
        private readonly IFactory _Factory;
        public HttpService(IRepository dbContext, IFactory factory)
        {
            _DbContext = dbContext;
            _Factory = factory;
        }

        ////////////////////    Get Methods    ////////////////////
        public Product GetProduct(int id)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            DProduct dProduct = dProducts.FirstOrDefault(p => p.Id == id);
            Product product = _Factory.CreateModel<Product>(dProduct);

            return product;
        }
        
        public List<Product> GetAllProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.OrderBy(p => p.Name).Skip((init - 1) * length).Take(length);
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetMaleProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Gender.Name == "Male")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFemaleProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Gender.Name == "Female")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetBabyProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Gender.Name == "Baby")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetSummerProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Category.Name == "Summer")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetWinterProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Category.Name == "Winter")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetCasualProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Category.Name == "Casual")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFormalProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Category.Name == "Formal")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFashionProducts(int init, int length)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts.Where(p => p.Category.Name == "Fashion")
                .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }

        public List<Product> GetFilteredProducts(string? genderFilter, string? categoryFilter)
        {
            List<DProduct> dProducts = _DbContext.GetProducts();
            dProducts = genderFilter == null || genderFilter == "" ?
                dProducts.Where(Verifications.GenderFilterIsNullOrEmpty(categoryFilter)).OrderBy(p => p.Name).ToList() :
                dProducts.Where(Verifications.GenderFilterIsNotNullOrEmpty(genderFilter, categoryFilter)).OrderBy(p => p.Name).ToList();
            List<Product> products = dProducts.Select(dP => _Factory.CreateModel<Product>(dP)).ToList();

            return products;
        }


        public List<Gender> GetAllGenders()
        {
            List<CGender> cGenders = _DbContext.GetGenders();
            List<Gender> genders = cGenders.Select(cG => _Factory.CreateModel<Gender>(cG)).ToList();

            return genders;
        }

        public List<Category> GetAllCategories()
        {
            List<CCategory> cCategories = _DbContext.GetCategories();
            List<Category> categories = cCategories.Select(cC => _Factory.CreateModel<Category>(cC)).ToList();

            return categories;
        }

        public List<Currency> GetAllCurrencies()
        {
            List<CCurrency> cCurrencies = _DbContext.GetCurrencies();
            List<Currency> currencies = cCurrencies.Select(cC => _Factory.CreateModel<Currency>(cC)).ToList();

            return currencies;
        }


        ////////////////////    Post Methods    ////////////////////
        public async Task<string> PostProduct(Product product)
        {
            try
            {
                await _DbContext.CreateProduct(_Factory.CreateEntity<DProduct>(product));
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
                await _DbContext.CreateGender(_Factory.CreateEntity<CGender>(gender));
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
                await _DbContext.CreateCategory(_Factory.CreateEntity<CCategory>(category));
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
                await _DbContext.CreateCurrency(_Factory.CreateEntity<CCurrency>(currency));
                return "Catalog loaded successfully.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
