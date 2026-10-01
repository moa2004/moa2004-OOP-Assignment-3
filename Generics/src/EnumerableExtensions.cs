using System;
using System.Collections.Generic;

namespace Generics.src
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1) throw new ArgumentException("Page number must be 1 or greater.");
            if (pageSize < 1) throw new ArgumentException("Page size must be 1 or greater.");
            int skip = (pageNumber - 1) * pageSize;
            int skippedCount = 0;
            int returnedCount = 0;
            foreach (var item in source)
            {
                if (skippedCount < skip)
                {
                    skippedCount++;
                    continue;
                }

                if (returnedCount < pageSize)
                {
                    yield return item;
                    returnedCount++;
                }
                else
                {
                    break;
                }
            }
        }
        public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
        {
            foreach (var item in source)
            {
                if (item.Id == id) return item;
            }
            return default;
        }
        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
        {
            Dictionary<int, T> dict = new Dictionary<int, T>();
            foreach (var item in source)
            {
                dict[item.Id] = item;
            }
            return dict;
        }
    }
}