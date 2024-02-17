using ECommerce.Models;
using ECommerce.Repository.Entities;

namespace ECommerce.Services.DataTransfer
{
    public interface IFactory
    {
        T CreateEntity<T>(ModelBase model) where T : EntityBase;
        T CreateModel<T>(EntityBase entity) where T : ModelBase;
    }
}
