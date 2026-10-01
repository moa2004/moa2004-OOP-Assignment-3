using System;
using System.Collections.Generic;

namespace Generics.src
{
    internal class Store<T> where T : IHasId
    {
        private Dictionary<int, T> _items = new Dictionary<int, T>();
        public void Add(T item)
        {
            if (_items.ContainsKey(item.Id))
            {
                throw new InvalidOperationException($"An item with Id '{item.Id}' already exists.");
            }
            _items.Add(item.Id, item);
        }
        public T? GetById(int id)
        {
            if (_items.TryGetValue(id, out T? item))
            {
                return item;
            }
            return default;
        }
        public IEnumerable<T> GetAll() => _items.Values;
        public void Remove(int id)
        {
            if (!_items.Remove(id))
            {
                Console.WriteLine("ID Not Found");
            }
        }
    }
}