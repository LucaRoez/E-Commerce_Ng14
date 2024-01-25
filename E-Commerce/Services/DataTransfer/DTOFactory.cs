using E_Commerce.Models;
using E_Commerce.Repository.Entities;

namespace E_Commerce.Services.DataTransfer
{
    public class DTOFactory : IFactory
    {
        public T CreateModel<T>(ModelBase model) where T : EntityBase
        {
            switch(model)
            {
                case Product product when typeof(T) == typeof(DProduct):
                    return RecordNewProduct(product as Product) as T;
                case Gender gender when typeof(T) == typeof(Gender):
                    return RecordNewGender(gender as Gender) as T;
                case Category category when typeof(T) == typeof(Category):
                    return RecordNewCategory(category as Category) as T;
                case Currency currency when typeof(T) == typeof(Currency):
                    return RecordNewCurrency(currency as Currency) as T;
                default: return null;
            }
        }

        private DProduct RecordNewProduct(Product model)
        {
            DProduct product = new()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Discount = model.Discount,
                CurrencyId = model.CurrencyId,
                QuantityAvailable = model.QuantityAvailable,
                CategoryId = model.CategoryId,
                GenderId = model.GenderId,
                Visits = 0,
                Rate = null,
                CreationDate = DateTime.Now
            };
            return product;
        }

        private CGender RecordNewGender(Gender model)
        {
            CGender gender = new()
            {
                Name = model.Name
            };
            return gender;
        }

        private CCategory RecordNewCategory(Category model)
        {
            CCategory category = new()
            {
                Name = model.Name
            };
            return category;
        }

        private CCurrency RecordNewCurrency(Currency model)
        {
            CCurrency category = new()
            {
                Name = model.Name,
                Symbol = model.Symbol,
                Issuer = model.Issuer
            };
            return category;
        }
    }
}
