using ECommerce.Repository.Entities;

namespace ECommerce.Repository
{
    public interface IRepository
    {
        Task<List<CCategory>> GetCategories();
        Task<int> CreateCategory(CCategory category);
        Task<List<CCurrency>> GetCurrencies();
        Task<int> CreateCurrency(CCurrency currency);
        Task<List<CGender>> GetGenders();
        Task<int> CreateGender(CGender gender);
        Task<List<DAuthor>> GetAuthors();
        Task<int> CreateAuthor(DAuthor author);
        Task<List<DCommentary>> GetCommentaries();
        Task<int> CreateCommentary(DCommentary commentary);
        Task<List<DImage>> GetImages();
        Task<int> CreateImage(DImage image);
        Task<List<DProduct>> GetProducts();
        Task<int> CreateProduct(DProduct product);
        Task<List<DReview>> GetReviews();
        Task<int> CreateReview(DReview review);
        Task<List<DUser>> GetUsers();
        Task<int> CreateUser(DUser user);
    }
}
