using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Returns the set intersection, which means elements that appear in each of two collections.
    ///</summary>
    public static class IntersectOperationsTrain 
    {
        ///<summary>
       /// Produces the set intersection of two sequences by using the default equality comparer to compare values.
       ///</summary>
       public static IEnumerable<TSource> myIntersect<TSource> (
           this IEnumerable<TSource> first, 
       IEnumerable<TSource> second)
       {
          // return first.myExcept(second);
           HashSet<TSource> set = new HashSet<TSource>(second, EqualityComparer<TSource>.Default);           
           foreach (var item in first)
           {
               if (set.Remove(item))
                {
                    yield return item;
                }
           }  

       }
               
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified IEqualityComparer<T> to compare values.
        ///</summary>
        public static IEnumerable<TSource> myIntersect<TSource> (
            this IEnumerable<TSource> first, 
            IEnumerable<TSource> second, 
        IEqualityComparer<TSource>? comparer)
        {
            HashSet<TSource> setSource = new HashSet<TSource>(second, comparer);
            foreach (TSource item in first)
            {
                if (setSource.Remove(item))
                {
                    yield return item;
                }
            }
        }        
    }

    
}