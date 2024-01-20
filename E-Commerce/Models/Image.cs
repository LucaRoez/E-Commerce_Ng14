namespace E_Commerce.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Source { get; set; }
        public string Alternative { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
