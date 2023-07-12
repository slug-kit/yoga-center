﻿namespace Utils;

public static class EnumerableExtensions
{
    /// <summary>
    /// Returns all items in the first collection except the ones in the second collection that match the lambda condition
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    /// <param name="listA">The first list</param>
    /// <param name="listB">The second list</param>
    /// <param name="lambda">The filter expression</param>
    /// <returns>The filtered list</returns>
    public static IEnumerable<T> Except<T>(this IEnumerable<T> listA, IEnumerable<T> listB, Func<T, T, bool> lambda)
    {
        return listA.Except(listB, new LambdaComparer<T>(lambda));
    }

    /// <summary>
    /// Returns all items in the first collection that intersect the ones in the second collection that match the lambda condition
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    /// <param name="listA">The first list</param>
    /// <param name="listB">The second list</param>
    /// <param name="lambda">The filter expression</param>
    /// <returns>The filtered list</returns>
    public static IEnumerable<T> Intersect<T>(this IEnumerable<T> listA, IEnumerable<T> listB, Func<T, T, bool> lambda)
    {
        return listA.Intersect(listB, new LambdaComparer<T>(lambda));
    }

    /// <summary>
    /// Returns all items in both collections, excluding duplicates, that match the lambda condition
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    /// <param name="listA">The first list</param>
    /// <param name="listB">The second list</param>
    /// <param name="lambda">The filter expression</param>
    /// <returns>The filtered list</returns>
    public static IEnumerable<T> Union<T>(this IEnumerable<T> listA, IEnumerable<T> listB, Func<T, T, bool> lambda)
    {
        return listA.Union(listB, new LambdaComparer<T>(lambda));
    }
}