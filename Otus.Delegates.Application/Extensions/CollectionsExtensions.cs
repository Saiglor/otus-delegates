using System;
using System.Collections;

namespace Otus.Delegates.Application.Extensions
{
    public static class CollectionsExtensions
    {
        public static T GetMax<T>(this IEnumerable items, Func<T, float> getParameter) where T: class
        {
            if (items is null) throw new ArgumentNullException($"Аргумент {nameof(items)} не может быть равен null");
            if (getParameter is null)
                throw new ArgumentNullException($"Аргумент {nameof(getParameter)} не может быть равен null");

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
