using E_Commerce.Models;
using E_Commerce.Repository.Entities;

namespace E_Commerce.Services.DataTransfer
{
    public class DTOFactory<TModel> : IFactory where TModel : ModelBase
    {
        public TModel CreateModel(ModelBase model)
        {
            switch(model)
            {
                case Product product when typeof(TModel) == typeof(DProduct):
                    return RecordNewProduct(product as Product) as TModel;
                default: return null;
            }
        }

        private DProduct RecordNewProduct(Product model)
        {
            DProduct product = new()
            {
                Name = model.Name,

            };

            return product;
        }
    }
}
