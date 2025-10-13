using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Casimo.Server.Helpers;

/// <summary>
/// Extension methods for IAsyncEnumerable to provide additional functionality
/// Provides utility methods for working with asynchronous enumerables
/// </summary>
public static class AsyncEnumerableExtensions
{
    /// <summary>
    /// Converts an IAsyncEnumerable to a List asynchronously
    /// Provides a convenient way to materialize an async enumerable into a list
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable</typeparam>
    /// <param name="source">The async enumerable to convert</param>
    /// <returns>A task containing the list of elements</returns>
    /// <exception cref="ArgumentNullException">Thrown when source is null</exception>
    public static Task<List<T>> ToListAsync<T>(this IAsyncEnumerable<T> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return ExecuteAsync();

        async Task<List<T>> ExecuteAsync()
        {
            List<T> list = new List<T>();

            await foreach (T element in source)
            {
                list.Add(element);
            }

            return list;
        }
    }
}
