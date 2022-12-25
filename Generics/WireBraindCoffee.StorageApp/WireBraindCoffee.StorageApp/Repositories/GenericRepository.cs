using System;
using System.Collections.Generic;
using System.Text;
using WireBraindCoffee.StorageApp.Entities;

namespace WireBraindCoffee.StorageApp.Repositories
{
  public  class GenericRepository<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach(var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
