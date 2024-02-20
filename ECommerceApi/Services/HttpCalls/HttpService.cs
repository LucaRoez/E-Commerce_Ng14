using ECommerceApi.Repository;
using ECommerceApi.Services.Utilities;
using ECommerceApi.Repository.Entities;
using ECommerceApi.Models;
using ECommerceApi.Services.DataTransfer;

namespace ECommerceApi.Services.HttpCalls
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
        public object GetProduct(int id)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                DProduct dProduct = dProducts.FirstOrDefault(p => p.Id == id);
                Product product = _Factory.CreateModel<Product>(dProduct);

                return product;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
        
        public List<object> GetAllProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.OrderBy(p => p.Name).Skip((init - 1) * length).Take(length);
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetMaleProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Gender.Name == "Male")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetFemaleProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Gender.Name == "Female")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetBabyProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Gender.Name == "Baby")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetSummerProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Category.Name == "Summer")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetWinterProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Category.Name == "Winter")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetCasualProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Category.Name == "Casual")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetFormalProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Category.Name == "Formal")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetFashionProducts(int init, int length)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts.Where(p => p.Category.Name == "Fashion")
                    .OrderBy(p => p.Name).Skip((init - 1) * length).Take(length).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetFilteredProducts(string? genderFilter, string? categoryFilter)
        {
            try
            {
                List<DProduct> dProducts = _DbContext.GetProducts();
                dProducts = genderFilter == null || genderFilter == "" ?
                    dProducts.Where(Verifications.GenderFilterIsNullOrEmpty(categoryFilter)).OrderBy(p => p.Name).ToList() :
                    dProducts.Where(Verifications.GenderFilterIsNotNullOrEmpty(genderFilter, categoryFilter)).OrderBy(p => p.Name).ToList();
                List<object> products = dProducts.Select(dP => (object)_Factory.CreateModel<Product>(dP)).ToList();

                return products;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }


        public List<object> GetAllGenders()
        {
            try
            {
                List<CGender> cGenders = _DbContext.GetGenders();
                List<object> genders = cGenders.Select(cG => (object)_Factory.CreateModel<Gender>(cG)).ToList();

                return genders;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetAllCategories()
        {
            try
            {
                List<CCategory> cCategories = _DbContext.GetCategories();
                List<object> categories = cCategories.Select(cC => (object)_Factory.CreateModel<Category>(cC)).ToList();

                return categories;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public List<object> GetAllCurrencies()
        {
            try
            {
                List<CCurrency> cCurrencies = _DbContext.GetCurrencies();
                List<object> currencies = cCurrencies.Select(cC => (object)_Factory.CreateModel<Currency>(cC)).ToList();

                return currencies;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }


        ////////////////////    Post Methods    ////////////////////
        public async Task<string> PostProduct(Product product)
        {
            try
            {
                int modified = await _DbContext.CreateProduct(_Factory.CreateEntity<DProduct>(product));
                if (modified > 0)
                {
                    return "Product loaded successfully.";
                }
                return "There was an issue loading your Product.";
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
                int modified = await _DbContext.CreateGender(_Factory.CreateEntity<CGender>(gender));
                if (modified > 0)
                {
                    return "Catalog loaded successfully.";
                }
                return "There was a problem loading the catalog.";
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
                int modified = await _DbContext.CreateCategory(_Factory.CreateEntity<CCategory>(category));
                if (modified > 0)
                {
                    return "Catalog loaded successfully.";
                }
                return "There was a problem loading the catalog.";
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
                int modified = await _DbContext.CreateCurrency(_Factory.CreateEntity<CCurrency>(currency));
                if (modified > 0)
                {
                    return "Catalog loaded successfully.";
                }
                return "There was a problem loading the catalog.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
