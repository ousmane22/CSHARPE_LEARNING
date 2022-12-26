﻿using System;
using System.Collections.Generic;
using System.Text;
using WireBraindCoffee.StorageApp.Entities;

namespace WireBraindCoffee.StorageApp.Repositories
{
  public  class GenericRepository<T,Tkey>
    {
        public Tkey  Key { get; set; }

        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
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
