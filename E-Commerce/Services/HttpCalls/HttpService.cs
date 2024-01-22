using E_Commerce.Repository;

namespace E_Commerce.Services.HttpCalls
{
    public class HttpService
    {
        private readonly ICommercialContext _DbContext;
        public HttpService(ICommercialContext dbContext)
        {
            _DbContext = dbContext;
        }


    }
}
