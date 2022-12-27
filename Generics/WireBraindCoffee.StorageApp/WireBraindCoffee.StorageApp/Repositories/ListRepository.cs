using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WireBraindCoffee.StorageApp.Entities;

namespace WireBraindCoffee.StorageApp.Repositories
{
    public  class ListRepository<T>:IRepository<T> where T:EntityBase,IEntity
    {
        

        private readonly List<T> _items = new List<T>();

        public T GetId(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }


        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public void Save()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    /*public class GenericRepositoryWithRemeove<T> : GenericRepository<T>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }*/
}
