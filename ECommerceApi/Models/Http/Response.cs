namespace ECommerceApi.Models.Http
{
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<Image> Images { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Currency> Currencies { get; set; }

        public Response()
        {
            IsSuccessful = false;
        }
    }
}
