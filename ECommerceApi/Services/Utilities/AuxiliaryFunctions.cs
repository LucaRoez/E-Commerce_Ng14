using ECommerceApi.Repository.Entities;
using ECommerceApi.Repository;

namespace ECommerceApi.Services.Utilities
{
    public class AuxiliaryFunctions
    {
        private readonly IRepository _DbContext;
        public AuxiliaryFunctions(IRepository dbContext)
        {
            _DbContext = dbContext;
        }
        public List<DAuthor> TakeRelatedAuthorsBasedOnProduct(int id) => _DbContext.GetRelatedAuthorsBasedOnProduct(id);
        public List<DReview> TakeRelatedReviewsBasedOnProduct(int id) => _DbContext.GetRelatedReviewsBasedOnProduct(id);
    }
}
