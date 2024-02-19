using ECommerce.Models;

namespace ECommerceApi.Models.Http
{
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ModelBase Data { get; set; }

        public Response()
        {
            IsSuccessful = false;
        }
    }
}
