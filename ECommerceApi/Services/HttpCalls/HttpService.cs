﻿using ECommerceApi.Repository;
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

        public object GetImage(int id)
        {
            try
            {
                List<DImage> dImages = _DbContext.GetImages();
                DImage dImage = dImages.FirstOrDefault(i => i.Id == id);
                Image image = _Factory.CreateModel<Image>(dImage);

                return image;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<object> GetAllImages()
        {
            try
            {
                List<DImage> dImages = _DbContext.GetImages();
                List<object> images = dImages.Select(dI => (object)_Factory.CreateModel<Image>(dI)).ToList();

                return images;
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

        public object GetAuthor(int id)
        {
            try
            {
                List<DAuthor> dAuthors = _DbContext.GetAuthors();
                DAuthor dAuthor = dAuthors.FirstOrDefault(a => a.Id == id);
                Author author = _Factory.CreateModel<Author>(dAuthor);

                return author;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<object> GetAllAuthors()
        {
            try
            {
                List<DAuthor> dAuthors = _DbContext.GetAuthors();
                List<object> authors = dAuthors.Select(dA => (object)_Factory.CreateModel<Author>(dA)).ToList();

                return authors;
            }
            catch (Exception ex)
            {
                List<object> exList = new() { ex };
                return exList;
            }
        }

        public object GetReview(int id)
        {
            try
            {
                List<DReview> dReviews = _DbContext.GetReviews();
                DReview dReview = dReviews.FirstOrDefault(p => p.Id == id);
                Review review = _Factory.CreateModel<Review>(dReview);

                return review;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<object> GetAllReviews()
        {
            try
            {
                List<DReview> dReviews = _DbContext.GetReviews();
                List<object> reviews = dReviews.Select(dR => (object)_Factory.CreateModel<Review>(dR)).ToList();

                return reviews;
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

        public async Task<string> PostImage(Image image)
        {
            try
            {
                int modified = await _DbContext.CreateImage(_Factory.CreateEntity<DImage>(image));
                if (modified > 0)
                {
                    return "Image loaded successfully.";
                }
                return "There was an issue loading your Image.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> LinkImageToProduct(Image image, Product product, int slot)
        {
            try
            {
                int modified = await _DbContext.LinkImageToProduct(_Factory.CreateEntity<DImage>(image), _Factory.CreateEntity<DProduct>(product), slot);
                if (modified > 0)
                {
                    switch (slot)
                    {
                        case 0:
                            return "Image linked to the product selected as its presentation successfully.";
                        case 1:
                            return "Image linked to the product selected as its secondary image successfully.";
                        case 2:
                            return "Image linked to the product selected as its third image successfully.";
                        case 3:
                            return "Image linked to the product selected as its fourth image successfully.";
                        case 4:
                            return "Image linked to the product selected as its fifth image successfully.";
                        case 5:
                            return "Image linked to the product selected as its sixth image successfully.";
                        default:
                            return "Image linked to the product selected as its presentation successfully.";
                    }
                }
                else
                {
                    return "There was an error trying to link the image to the product selected.";
                }
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
