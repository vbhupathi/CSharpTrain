using System;
using System.Collections.Generic;

namespace LinqTrain
{
    
    ///<summery>
    /// ToLookup Overloads Reimplementation.
    /// Creates a generic Lookup<TKey,TElement> from an IEnumerable<T>.
    ///</summary>
    public static class ToLookupTrain 
    {
        ///<summary>
        /// Creates a Lookup<TKey,TElement> from an IEnumerable<T> according to specified key selector and element selector functions.
        ///</summary>
        public static System.Linq.ILookup<TKey,TElement> ToLookup<TSource,TKey,TElement> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, Func<TSource,TElement> elementSelector)
        {

        }

        ///<summary>
        /// Creates a Lookup<TKey,TElement> from an IEnumerable<T> according to a specified key selector function, a comparer and an element selector function.
        ///</summary>
        public static System.Linq.ILookup<TKey,TElement> ToLookup<TSource,TKey,TElement> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey>? comparer)
        {

        }

        ///<summary>
        /// Creates a Lookup<TKey,TElement> from an IEnumerable<T> according to a specified key selector function.
        ///</summary>

        public static System.Linq.ILookup<TKey,TSource> ToLookup<TSource,TKey> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector)
        {

        }

        ///<summary>
        /// Creates a Lookup<TKey,TElement> from an IEnumerable<T> according to a specified key selector function and key comparer.
        ///</summary>
        public static System.Linq.ILookup<TKey,TSource> ToLookup<TSource,TKey> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey>? comparer)
        {
        }

        
    }


    public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>
    {
        TKey Key { get; }
    }

    public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>{
        int Count { get; }
        IEnumerable<TElement> this[TKey key] { get; }
        bool Contains(TKey key);
    }
        
}
