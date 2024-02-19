using ECommerceApi.Repository.Entities;

namespace ECommerceApi.Services.Utilities
{
    public static class Verifications
    {
        public static bool IsSuccessful(string result) => result.Contains("loaded successfully");
        public static bool IsNotFound(string result) => result.Contains("not found");
        public static bool IsForbidden(string result) => result.Contains("forbidden");
        public static bool IsUnauthorized(string result) => result.ToLower().Contains("authentication");
        public static bool IsConflict(string result) => result.ToLower().Contains("violation") || result.Contains("constraint");
        public static bool IsInternalServerError(string result) => result.Contains("server") && result.Contains("unexpected");
        public static bool IsServiceUnavailable(string result) => result.ToLower().Contains("failed to fetch");
        public static bool IsBadRequest(string result) => result.Contains("request message");
        public static bool IsUnableToProcess(string result) => result.ToLower().Contains("unable to process");

        public static Func<DProduct, bool> GenderFilterIsNullOrEmpty(string? category)
        {
            if (category == null || category == "") return p => p.Name != null && p.Name != "";
            else return p => p.Category.Name == category;
        }

        public static Func<DProduct, bool> GenderFilterIsNotNullOrEmpty(string gender, string? category)
        {
            if (category == null || category == "") return p => p.Gender.Name == gender;
            else return p => p.Gender.Name == gender && p.Category.Name == category;
        }
    }
}
