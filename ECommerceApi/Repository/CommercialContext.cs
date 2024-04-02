using Dapper;
using ECommerceApi.Models;
using ECommerceApi.Repository.Entities;
using Microsoft.Data.SqlClient;

namespace ECommerceApi.Repository
{
    public class CommercialContext : IRepository
    {
        private readonly string _connectionString;
        private string _query = "";
        public CommercialContext(IConfiguration config) {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public List<CCategory> GetCategories()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [c.Categories]";
                IEnumerable<CCategory> cCategories = connection.Query<CCategory>(_query);
                return cCategories.ToList();
            }
        }

        public async Task<int> CreateCategory(CCategory category)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [c.Categories](Id, Name) VALUES (@Id, @Name)";
                int affectedRows = await connection.ExecuteAsync(_query, category);
                return affectedRows;
            }
        }

        public List<CCurrency> GetCurrencies()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [c.Currencies]";
                IEnumerable<CCurrency> cCurrencies = connection.Query<CCurrency>(_query);
                return cCurrencies.ToList();
            }
        }

        public async Task<int> CreateCurrency(CCurrency currency)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [c.Currencies](Name, Symbol, Issuer) VALUES (@Name, @Symbol, @Issuer)";
                int affectedRows = await connection.ExecuteAsync(_query, currency);
                return affectedRows;
            }
        }

        public List<CGender> GetGenders()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [c.Genders]";
                IEnumerable<CGender> cGenders = connection.Query<CGender>(_query);
                return cGenders.ToList();
            }
        }

        public async Task<int> CreateGender(CGender gender)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [c.Genders](Id, Name) VALUES (@Id, @Name)";
                int affectedRows = await connection.ExecuteAsync(_query, gender);
                return affectedRows;
            }
        }

        public List<DAuthor> GetAuthors()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Authors]";
                IEnumerable<DAuthor> dAuthors = connection.Query<DAuthor>(_query);
                return dAuthors.ToList();
            }
        }

        public DAuthor? GetAuthor(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Authors] WHERE Id = {0}", id);
                DAuthor? dAuthor = connection.QuerySingleOrDefault<DAuthor>(_query);
                return dAuthor;
            }
        }

        public List<DAuthor> GetRelatedAuthorsBasedOnProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Authors] a JOIN [l.Author_Product] ap ON a.Id = ap.AuthorId " +
                    "JOIN [d.Products] p ON p.Id = ap.ProductId WHERE p.Id = {0}", id);
                IEnumerable<DAuthor> dAuthors = connection.Query<DAuthor>(_query);
                return dAuthors.ToList();
            }
        }

        public async Task<int> CreateAuthor(DAuthor author)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Authors](AuthorName, Presentation, Email, Password) " +
                    "VALUES (@AuthorName, @Presentation, @Email, @Password)";
                int affectedRows = await connection.ExecuteAsync(_query, author);
                return affectedRows;
            }
        }

        public List<DCommentary> GetCommentaries()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Commentaries]";
                IEnumerable<DCommentary> dCommentaries = connection.Query<DCommentary>(_query);
                return dCommentaries.ToList();
            }
        }

        public async Task<int> CreateCommentary(DCommentary commentary)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Commentaries](UserName, Body, IsEdited, Likes, Dislikes) " +
                    "VALUES (@UserName, @Body, @IsEdited, @Likes, @Dislikes)";
                int affectedRows = await connection.ExecuteAsync(_query, commentary);
                return affectedRows;
            }
        }

        public List<DImage> GetImages()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Images]";
                IEnumerable<DImage> dImages = connection.Query<DImage>(_query);
                return dImages.ToList();
            }
        }

        public DImage? GetImage(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Images] WHERE Id = {0}", id);
                DImage? dImage = connection.QuerySingleOrDefault<DImage>(_query);
                return dImage;
            }
        }

        public async Task<int> CreateImage(DImage image)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Images](Src, Alt, Width, Height)" +
                    "VALUES (@Src, @Alt, @Width, @Height)";
                int affectedRows = await connection.ExecuteAsync(_query, image);
                return affectedRows;
            }
        }

        public async Task<int> LinkImageToProduct(DImage image, DProduct product, int slot)
        {
            long imageId = image.Id;
            long? productId = product.Id;
            using (var connection = new SqlConnection(_connectionString))
            {
                if (slot == 0)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET PresentationImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else if (slot == 1)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET SecondImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else if (slot == 2)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET ThirdImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else if (slot == 3)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET FourthImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else if (slot == 4)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET FifthImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else if (slot == 5)
                {
                    _query = string.Format(@"UPDATE [d.Products] SET SixthImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
                else
                {
                    _query = string.Format(@"UPDATE [d.Products] SET PresentationImage = {0} WHERE Id = {1}", imageId, productId);
                    int affectedRows = await connection.ExecuteAsync(_query);
                    return affectedRows;
                }
            }
        }

        public List<DProduct> GetProducts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Products]";
                IEnumerable<DProduct> dProducts = connection.Query<DProduct>(_query);
                return dProducts.ToList();
            }
        }

        public DProduct? GetProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Products] WHERE Id = {0}", id);
                DProduct? dProduct = connection.QuerySingleOrDefault<DProduct>(_query);
                return dProduct;
            }
        }

        public async Task<int> CreateProduct(DProduct product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Products](Name, Description, Price, CurrencyId, Discount," +
                    " QuantityAvailable, SalesAmount, Rate, Visits, CategoryId, GenderId, CreationDate)" +
                    " VALUES (@Name, @Description, @Price, @CurrencyId, @Discount, @QuantityAvailable," +
                    " @SalesAmount, @Rate, @Visits, @CategoryId, @GenderId, @CreationDate)";
                int affectedRows = await connection.ExecuteAsync(_query, product);
                return affectedRows;
            }
        }

        public List<DReview> GetReviews()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Reviews]";
                IEnumerable<DReview> dReviews = connection.Query<DReview>(_query);
                return dReviews.ToList();
            }
        }

        public DReview? GetReview(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Reviews] WHERE Id = {0}", id);
                DReview? dReview = connection.QuerySingleOrDefault<DReview>(_query);
                return dReview;
            }
        }

        public List<DReview> GetRelatedReviewsBasedOnProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Reviews] WHERE ProductId = {0}", id);
                IEnumerable<DReview> dReviews = connection.Query<DReview>(_query);
                return dReviews.ToList();
            }
        }

        public async Task<int> CreateReview(DReview review)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Reviews](Author, AuthorId, Body, Rate) " +
                    "VALUES (@Author, @AuthorId, @Body, @Rate)";
                int affectedRows = await connection.ExecuteAsync(_query, review);
                return affectedRows;
            }
        }

        public List<DUser> GetUsers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = "SELECT * FROM [d.Users]";
                IEnumerable<DUser> dUsers = connection.Query<DUser>(_query);
                return dUsers.ToList();
            }
        }

        public DUser? GetUser(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = string.Format("SELECT * FROM [d.Users] WHERE Id = {0}", id);
                DUser? dUser = connection.QuerySingleOrDefault<DUser>(_query);
                return dUser;
            }
        }

        public async Task<int> CreateUser(DUser user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Users](UserName, FirstName, LastName, Email, Password) " +
                    "VALUES (@UserName, @FirstName, @LastName, @Email, @Password)";
                int affectedRows = await connection.ExecuteAsync(_query, user);
                return affectedRows;
            }
        }
    }
}
