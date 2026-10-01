using System;
using System.Collections.Generic;

namespace Generics.src
{
    internal class Store<T> where T : IHasId
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T? GetById(int id)
        {
            foreach (var item in items)
            {
                if (item.Id == id) return item;
            }
            return default;
        }
        public List<T> GetAll() => items;
        public void Remove(int id)
        {
            var itemToRemove = GetById(id);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }
        }
    }
}