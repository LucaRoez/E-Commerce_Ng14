using ECommerceApi.Repository.Entities;

namespace ECommerceApi.Repository
{
    public interface IRepository
    {
        List<CCategory> GetCategories();
        Task<int> CreateCategory(CCategory category);
        List<CCurrency> GetCurrencies();
        Task<int> CreateCurrency(CCurrency currency);
        List<CGender> GetGenders();
        Task<int> CreateGender(CGender gender);
        List<DAuthor> GetAuthors();
        DAuthor? GetAuthor(int id);
        List<DAuthor> GetRelatedAuthorsBasedOnProduct(int id);
        Task<int> CreateAuthor(DAuthor author);
        List<DCommentary> GetCommentaries();
        Task<int> CreateCommentary(DCommentary commentary);
        List<DImage> GetImages();
        DImage? GetImage(int id);
        Task<int> CreateImage(DImage image);
        Task<int> LinkImageToProduct(DImage image, DProduct product, int slot);
        List<DProduct> GetProducts();
        DProduct? GetProduct(int id);
        Task<int> CreateProduct(DProduct product);
        List<DReview> GetReviews();
        DReview? GetReview(int id);
        List<DReview> GetRelatedReviewsBasedOnProduct(int id);
        Task<int> CreateReview(DReview review);
        List<DUser> GetUsers();
        DUser? GetUser(int id);
        Task<int> CreateUser(DUser user);
    }
}
