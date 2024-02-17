using ECommerce.Repository.Entities;

namespace ECommerce.Services.Utilities
{
    public static class Verifications
    {
        public static Func<DProduct, bool> GenderFilterIsNullOrEmpty(string? category)
        {
            if (category == null || category == "") { return p => p.Name != null || p.Name != ""; }
            else { return p => p.Category.Name == category; }
        }

        public static Func<DProduct, bool> GenderFilterIsNotNullOrEmpty(string gender, string? category)
        {
            if (category == null || category == "") { return p => p.Gender.Name == gender; }
            else { return p => p.Gender.Name == gender && p.Category.Name == category; }
        }
    }
}
