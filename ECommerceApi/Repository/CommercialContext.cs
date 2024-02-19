using Dapper;
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
                _query = @"INSERT INTO [c.Currencies](Id, Name, Symbol, Issuer) VALUES (@Id, @Name, @Symbol, @Issuer)";
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

        public async Task<int> CreateAuthor(DAuthor author)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Authors](Id, AuthorName, Presentation, Email, Password) " +
                    "VALUES (@Id, @AuthorName, @Presentation, @Email, @Password)";
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
                _query = @"INSERT INTO [d.Commentaries](Id, UserName, Body, IsEdited, Likes, Dislikes) " +
                    "VALUES (@Id, @UserName, @Body, @IsEdited, @Likes, @Dislikes)";
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

        public async Task<int> CreateImage(DImage image)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Images](Id, Src, Alt, Width, Height)" +
                    "VALUES (@Id, @Src, @Alt, @Width, @Height)";
                int affectedRows = await connection.ExecuteAsync(_query, image);
                return affectedRows;
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

        public async Task<int> CreateProduct(DProduct product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Products](Id, Name, Description, Price, CurrencyId, Discount," +
                    " QuantityAvailable, SalesAmount, Rate, Visits, CategoryId, GenderId, CreationDate)" +
                    "VALUES (@Id, @Name, @Description, @Price, @CurrencyId, @Discount, @QuantityAvailable" +
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

        public async Task<int> CreateReview(DReview review)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Reviews](Id, Author, AuthorId, Body, Rate) " +
                    "VALUES (@Id, @Author, @AuthorId, @Body, @Rate)";
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

        public async Task<int> CreateUser(DUser user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                _query = @"INSERT INTO [d.Users](Id, UserName, FirstName, LastName, Email, Password) " +
                    "VALUES (@Id, @UserName, @FirstName, @LastName, @Email, @Password)";
                int affectedRows = await connection.ExecuteAsync(_query, user);
                return affectedRows;
            }
        }
    }
}
