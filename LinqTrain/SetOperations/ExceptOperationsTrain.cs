using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Returns the set difference, which means the elements of one collection that do not appear in a second collection.
    ///</summary>
    public static class ExceptOperationsTrain 
    {
        ///<summary>
       /// Produces the set difference of two sequences by using the default equality comparer to compare values.
       ///</summary>
       public static IEnumerable<TSource> myExcept<TSource> (
           this IEnumerable<TSource> first, 
           IEnumerable<TSource> second)
       {
          // return first.myExcept(second);
           HashSet<TSource> set = new HashSet<TSource>(second, EqualityComparer<TSource>.Default);           
           foreach (var item in first)
           {
               if (set.Add(item))
                {
                    yield return item;
                }
           }  

       }
               
        ///<summary>
        /// Produces the set difference of two sequences by using the specified IEqualityComparer<T> to compare values.
        ///</summary>
        public static IEnumerable<TSource> myExcept<TSource> (
            this IEnumerable<TSource> first, IEnumerable<TSource> second, 
        IEqualityComparer<TSource>? comparer)
        {
            HashSet<TSource> setSource = new HashSet<TSource>(second, comparer);
            foreach (TSource item in first)
            {
                if (setSource.Add(item))
                {
                    yield return item;
                }
            }
        }        
    }

    
}