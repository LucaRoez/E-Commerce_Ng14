namespace E_Commerce.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CommentedDate { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public bool IsEdited { get; set; }
    }
}
