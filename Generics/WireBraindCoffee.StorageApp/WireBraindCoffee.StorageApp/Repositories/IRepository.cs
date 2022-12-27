using System.Collections.Generic;
using WireBraindCoffee.StorageApp.Entities;

namespace WireBraindCoffee.StorageApp.Repositories
{
    public interface IRepository<T> where T :  IEntity
    {
        IEnumerable<T>  GetAll();
        void Add(T item);
        T GetId(int id);
        void Remove(T item);
        void Save();
    }
}