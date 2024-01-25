using E_Commerce.Models;
using E_Commerce.Repository.Entities;

namespace E_Commerce.Services.DataTransfer
{
    public interface IFactory
    {
        T CreateModel<T>(ModelBase model) where T : EntityBase;
    }
}
