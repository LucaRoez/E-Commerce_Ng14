using ECommerce.Repository.Entities;

namespace ECommerce.Repository
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
        Task<int> CreateAuthor(DAuthor author);
        List<DCommentary> GetCommentaries();
        Task<int> CreateCommentary(DCommentary commentary);
        List<DImage> GetImages();
        Task<int> CreateImage(DImage image);
        List<DProduct> GetProducts();
        Task<int> CreateProduct(DProduct product);
        List<DReview> GetReviews();
        Task<int> CreateReview(DReview review);
        List<DUser> GetUsers();
        Task<int> CreateUser(DUser user);
    }
}
