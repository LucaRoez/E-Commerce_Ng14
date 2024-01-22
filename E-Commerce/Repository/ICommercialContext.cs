using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repository
{
    public interface ICommercialContext
    {
        DbSet<CCategory> CCategories { get; set; }
        DbSet<CCurrency> CCurrencies { get; set; }
        DbSet<CGender> CGenders { get; set; }
        DbSet<DAuthor> DAuthors { get; set; }
        DbSet<DCommentary> DCommentaries { get; set; }
        DbSet<DImage> DImages { get; set; }
        DbSet<DProduct> DProducts { get; set; }
        DbSet<DReview> DReviews { get; set; }
        DbSet<DUser> DUsers { get; set; }
    }
}
