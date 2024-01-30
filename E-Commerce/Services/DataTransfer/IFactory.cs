using E_Commerce.Models;
using E_Commerce.Repository.Entities;

namespace E_Commerce.Services.DataTransfer
{
    public interface IFactory
    {
        T CreateEntity<T>(ModelBase model) where T : EntityBase;
        T CreateModel<T>(EntityBase entity) where T : ModelBase;
    }
}
