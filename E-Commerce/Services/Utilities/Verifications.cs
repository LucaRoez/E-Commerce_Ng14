using E_Commerce.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;

namespace E_Commerce.Services.Utilities
{
    public static class Verifications
    {
        public static Func<DProduct, bool> GenderFilterIsNullOrEmpty(string? category)
        {
            if (category.IsNullOrEmpty()) { return p => !p.Name.IsNullOrEmpty(); }
            else { return p => p.Category.Name == category; }
        }

        public static Func<DProduct, bool> GenderFilterIsNotNullOrEmpty(string gender, string? category)
        {
            if (category.IsNullOrEmpty()) { return p => p.Gender.Name == gender; }
            else { return p => p.Gender.Name == gender && p.Category.Name == category; }
        }
    }
}
