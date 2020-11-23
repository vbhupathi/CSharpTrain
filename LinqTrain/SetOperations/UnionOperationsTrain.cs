using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Returns the set union, which means unique elements that appear in either of two collections.
    ///</summary>
    public static class UnionOperationsTrain 
    {
        ///<summary>
       /// Produces the set union of two sequences by using the default equality comparer.
       ///</summary>
       public static IEnumerable<TSource> myUnion<TSource> (
           this IEnumerable<TSource> first, 
       IEnumerable<TSource> second)
       {
           HashSet<TSource> set = new HashSet<TSource>(EqualityComparer<TSource>.Default);           
           foreach (var item in first)
           {
               if (set.Add(item))
                {
                    yield return item;
                }
           }  
           foreach (var item in second)
           {
               if (set.Add(item))
                {
                    yield return item;
                }
           }  


       }
               
        ///<summary>
        /// Produces the set union of two sequences by using a specified IEqualityComparer<T>.
        ///</summary>
        public static IEnumerable<TSource> myUnion<TSource> (
            this IEnumerable<TSource> first, 
            IEnumerable<TSource> second, 
        IEqualityComparer<TSource>? comparer)
        {
            HashSet<TSource> setSource = new HashSet<TSource>(comparer);
            foreach (TSource item in first)
            {
                if (setSource.Add(item))
                {
                    yield return item;
                }
            }
            foreach (TSource item in second)
            {
                if (setSource.Add(item))
                {
                    yield return item;
                }
            }
        }        
    }

    
}