using ECommerceApi.Models;
using ECommerceApi.Repository.Entities;

namespace ECommerceApi.Services.DataTransfer
{
    public interface IFactory
    {
        T CreateEntity<T>(ModelBase model) where T : EntityBase;
        T CreateModel<T>(EntityBase entity) where T : ModelBase;
    }
}
