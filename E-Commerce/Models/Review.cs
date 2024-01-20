namespace E_Commerce.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public int Rate { get; set; }
        public string Body { get; set; }
    }
}
