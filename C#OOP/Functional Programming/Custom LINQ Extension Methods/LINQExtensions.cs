using System;
using System.Collections.Generic;
using System.Linq;

public static class LINQExtensions
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Where(c => !predicate(c));
    }

    public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
    {
        var newCollection = collection.ToList();
        for (int i = 0; i < count - 1; i++)
        {
            newCollection.AddRange(collection);
        }

        return newCollection;
    }

    public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
    {
        var newCollection = new List<string>();
        foreach (var item in collection)
        {
            foreach (var suffix in suffixes)
            {
                if (item.EndsWith(suffix))
                {
                    newCollection.Add(item);
                }
            }
        }
        return newCollection;
    }
}

