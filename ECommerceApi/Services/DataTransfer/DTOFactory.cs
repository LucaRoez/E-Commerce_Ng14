using ECommerceApi.Models;
using ECommerceApi.Repository.Entities;

namespace ECommerceApi.Services.DataTransfer
{
    public class DTOFactory : IFactory
    {
        public T CreateEntity<T>(ModelBase model) where T : EntityBase
        {
            switch(model)
            {
                case Product product when typeof(T) == typeof(DProduct):
                    return RecordNewProduct(product as Product) as T;
                case Image image when typeof(T) == typeof(DImage):
                    return RecordNewImage(image as Image) as T;
                case Gender gender when typeof(T) == typeof(CGender):
                    return RecordNewGender(gender as Gender) as T;
                case Category category when typeof(T) == typeof(CCategory):
                    return RecordNewCategory(category as Category) as T;
                case Currency currency when typeof(T) == typeof(CCurrency):
                    return RecordNewCurrency(currency as Currency) as T;
                default: return null;
            }
        }

        public T CreateModel<T>(EntityBase entity) where T : ModelBase
        {
            switch(entity)
            {
                case DProduct product when typeof(T) == typeof(Product):
                    return ShowRecordedProduct(product as DProduct) as T;
                case DImage image when typeof(T) == typeof(Image):
                    return ShowRecordedImage(image as DImage) as T;
                case CGender gender when typeof(T) == typeof(Gender):
                    return ShowRecordedGender(gender as CGender) as T;
                case CCategory category when typeof(T) == typeof(Category):
                    return ShowRecordedCategory(category as CCategory) as T;
                case CCurrency currency when typeof(T) == typeof(Currency):
                    return ShowRecordedCurrency(currency as CCurrency) as T;
                default: return null;
            }
        }

        private Product ShowRecordedProduct(DProduct dProduct)
        {
            Product product = new()
            {
                Id = dProduct.Id,
                Name = dProduct.Name,
                Description = dProduct.Description,
                Price = dProduct.Price,
                Discount = dProduct.Discount,
                CurrencyId = dProduct.CurrencyId,
                QuantityAvailable = dProduct.QuantityAvailable,
                CategoryId = dProduct.CategoryId,
                GenderId = dProduct.GenderId,
                Visits = dProduct.Visits,
                Rate = dProduct.Rate,
                CreationDate = dProduct.CreationDate,
                PresentationImageId = dProduct.PresentationImageId,
                SecondImageId = dProduct.SecondImageId,
                ThirdImageId = dProduct.ThirdImageId,
                FourthImageId = dProduct.FourthImageId,
                FifthImageId = dProduct.FifthImageId,
                SixthImageId = dProduct.SixthImageId
            };
            return product;
        }

        private Image ShowRecordedImage(DImage dImage)
        {
            Image image = new()
            {
                Id = dImage.Id,
                Src = dImage.Src,
                Alt = dImage.Alt,
                Height = dImage.Height,
                Width = dImage.Width
            };
            return image;
        }

        private Gender ShowRecordedGender(CGender cGender)
        {
            Gender gender = new()
            {
                Id = cGender.Id,
                Name = cGender.Name
            };
            return gender;
        }

        private Category ShowRecordedCategory(CCategory cCategory)
        {
            Category category = new()
            {
                Id = cCategory.Id,
                Name = cCategory.Name
            };
            return category;
        }

        private Currency ShowRecordedCurrency(CCurrency cCurrency)
        {
            Currency currency = new()
            {
                Id = cCurrency.Id,
                Name = cCurrency.Name,
                Symbol = cCurrency.Symbol,
                Issuer = cCurrency.Issuer
            };
            return currency;
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
                CreationDate = DateTime.Now,
                PresentationImageId = model.PresentationImageId,
                SecondImageId = model.SecondImageId,
                ThirdImageId = model.ThirdImageId,
                FourthImageId = model.FourthImageId,
                FifthImageId = model.FifthImageId,
                SixthImageId = model.SixthImageId
            };
            return product;
        }

        private DImage RecordNewImage(Image model)
        {
            DImage image = new()
            {
                Src = model.Src,
                Alt = model.Alt,
                Height = model.Height,
                Width = model.Width
            };
            return image;
        }

        private CGender RecordNewGender(Gender model)
        {
            CGender gender = new()
            {
                Id = model.Id,
                Name = model.Name
            };
            return gender;
        }

        private CCategory RecordNewCategory(Category model)
        {
            CCategory category = new()
            {
                Id = model.Id,
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
