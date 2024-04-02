using ECommerceApi.Repository.Entities;
using ECommerceApi.Models;

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
            else return p => p.CategoryNavigation.Name == category;
        }

        public static Func<DProduct, bool> GenderFilterIsNotNullOrEmpty(string gender, string? category)
        {
            if (category == null || category == "") return p => p.GenderNavigation.Name == gender;
            else return p => p.GenderNavigation.Name == gender && p.CategoryNavigation.Name == category;
        }

        public static bool IsProduct(object sample) => sample != null && sample is Product;
        public static bool IsImage(object sample) => sample != null && sample is Image;
        public static bool IsAuthor(object sample) => sample != null && sample is Author;
        public static bool IsReview(object sample) => sample != null && sample is Review;
        public static bool IsNoObjectInserted(object sample) => sample != null && sample.Equals("No Object Inserted");
    }
}
