using System;
using System.Collections;

namespace Otus.Delegates.Application.Extensions
{
    public static class CollectionsExtensions
    {
        public static T GetMax<T>(this IEnumerable items, Func<T, float> getParameter) where T: class
        {
            T res = null;
            var max = float.MinValue;
            foreach (T item in items)
            {
                var current = getParameter.Invoke(item);

                if (current > max)
                {
                    max = current;
                    res = item;
                }
            }

            return res;
        }
    }
}
