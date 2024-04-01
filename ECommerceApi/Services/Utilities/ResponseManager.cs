using ECommerceApi.Models;
using ECommerceApi.Models.Http;
using ECommerceApi.Services.HttpCalls;

namespace ECommerceApi.Services.Utilities
{
    public class ResponseManager
    {
        private readonly IHttpService _Http;
        public ResponseManager(IHttpService http)
        {
            _Http = http;
        }

        ////////////////    Main Controller    ////////////////
        public Response ReturnProductResponse(int id)
        {
            Response result = new();
            object response = _Http.GetProduct(id);
            if (response is null)
            {
                result.StatusCode = 404;
                result.Message = "There was a problem to get the Product requested, and got a null as response.";
            }
            else if (response is Exception)
            {
                Exception ex = (Exception)response;
                result.StatusCode = ex.HResult;
                result.Message = ex.Message;
            }
            else if (response is Product)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Product = (Product)response;
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else
            {
                try
                {
                    Exception ex = (Exception)response;
                    result.StatusCode = 500;
                    result.Message = ex.Message;
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }

            return result;
        }

        public Response ReturnAllProductsResponse(int init, int length) => ParseList(_Http.GetAllProducts(init, length));
        public Response ReturnMaleProductsResponse(int init, int length) => ParseList(_Http.GetMaleProducts(init, length));
        public Response ReturnFemaleProductsResponse(int init, int length) => ParseList(_Http.GetFemaleProducts(init, length));
        public Response ReturnBabyProductsResponse(int init, int length) => ParseList(_Http.GetBabyProducts(init, length));
        public Response ReturnSummerProductsResponse(int init, int length) => ParseList(_Http.GetSummerProducts(init, length));
        public Response ReturnWinterProductsResponse(int init, int length) => ParseList(_Http.GetWinterProducts(init, length));
        public Response ReturnCasualProductsResponse(int init, int length) => ParseList(_Http.GetCasualProducts(init, length));
        public Response ReturnFormalProductsResponse(int init, int length) => ParseList(_Http.GetFormalProducts(init, length));
        public Response ReturnFashionProductsResponse(int init, int length) => ParseList(_Http.GetFashionProducts(init, length));
        public Response ReturnFilteredProductsResponse(string? genderFilter, string? categoryFilter) => ParseList(_Http.GetFilteredProducts(genderFilter, categoryFilter));

        public Response ReturnImageResponse(int id)
        {
            Response result = new();
            object response = _Http.GetImage(id);
            if (response is null)
            {
                result.StatusCode = 404;
                result.Message = "There was a problem to get the Image requested, and got a null as response.";
            }
            else if (response is Exception)
            {
                Exception ex = (Exception)response;
                result.StatusCode = ex.HResult;
                result.Message = ex.Message;
            }
            else if (response is Image)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Image = (Image)response;
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else
            {
                try
                {
                    Exception ex = (Exception)response;
                    result.StatusCode = 500;
                    result.Message = ex.Message;
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }

            return result;
        }
        public Response ReturnAllImagesResponse() => ParseList(_Http.GetAllImages());
        public Response ReturnAllGendersResponse() => ParseList(_Http.GetAllGenders());
        public Response ReturnAllCategoriesResponse() => ParseList(_Http.GetAllCategories());
        public Response ReturnAllCurrenciesResponse() => ParseList(_Http.GetAllCurrencies());

        public Response ReturnAllAuthorsResponse() => ParseList(_Http.GetAllAuthors());
        public Response ReturnAllReviewsResponse() => ParseList(_Http.GetAllReviews());

        private Response ParseList(List<object> response)
        {
            Response result = new();

            if (response.FirstOrDefault() is null)
            {
                result.StatusCode = 404;
                result.Message = "There was a problem to get the Product requested, and got a null as response.";
            }
            else if (response.FirstOrDefault() is Exception)
            {
                Exception ex = (Exception)response.FirstOrDefault();
                result.StatusCode = ex.HResult;
                result.Message = ex.Message;
            }
            else if (response.FirstOrDefault() is Product)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Products = response.Cast<Product>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Gender)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Genders = response.Cast<Gender>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Category)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Categories = response.Cast<Category>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Currency)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Currencies = response.Cast<Currency>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Image)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Images = response.Cast<Image>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Author)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Authors = response.Cast<Author>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else if (response.FirstOrDefault() is Review)
            {
                try
                {
                    result.IsSuccessful = true;
                    result.StatusCode = 200;
                    result.Reviews = response.Cast<Review>().ToList();
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }
            else
            {
                try
                {
                    Exception ex = (Exception)response.FirstOrDefault();
                    result.StatusCode = 500;
                    result.Message = ex.Message;
                }
                catch (Exception ex)
                {
                    result.StatusCode = ex.HResult;
                    result.Message = ex.Message;
                }
            }

            return result;
        }

        ////////////////    Admin Controller    ////////////////
        public async Task<Response> ReturnResponse(Product product) => ParsePostAction(await _Http.PostProduct(product));

        public async Task<Response> ReturnResponse(Image image) => ParsePostAction(await _Http.PostImage(image));

        public async Task<Response> ReturnResponse(Image image, Product product, int slot) =>
            ParsePostAction(await _Http.LinkImageToProduct(image, product, slot));

        public async Task<Response> ReturnResponse(Gender gender) => ParsePostAction(await _Http.PostGender(gender));

        public async Task<Response> ReturnResponse(Category category) => ParsePostAction(await _Http.PostCategory(category));

        public async Task<Response> ReturnResponse(Currency currency) => ParsePostAction(await _Http.PostCurrency(currency));

        private Response ParsePostAction(string response)
        {
            Response result = new();
            result.IsSuccessful = Verifications.IsSuccessful(response) ? true : false;
            result.Message = response;
            result.StatusCode = Verifications.IsSuccessful(response) ? 200 :
                Verifications.IsNotFound(response) ? 404 :
                Verifications.IsForbidden(response) ? 403 :
                Verifications.IsUnauthorized(response) ? 401 :
                Verifications.IsConflict(response) ? 409 :
                Verifications.IsInternalServerError(response) ? 500 :
                Verifications.IsServiceUnavailable(response) ? 503 :
                Verifications.IsBadRequest(response) ? 400 :
                Verifications.IsUnableToProcess(response) ? 422 : 503;

            return result;
        }
    }
}
