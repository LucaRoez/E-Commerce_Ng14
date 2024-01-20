namespace E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image[] Images { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public Comment[] Commentaries { get; set; }
        public Review[] Reviews { get; set; }
    }
}
