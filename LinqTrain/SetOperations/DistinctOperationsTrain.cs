using System;
using System.Collections.Generic;

namespace LinqTrain
{
    
    ///<summery>
    /// Overloads of Distinct Operations Reimplementation.
    /// Returns distinct elements from a sequence.
    ///</summary>
    public static class DistinctOperationsTrain 
    {
        ///<summary>
       /// Returns distinct elements from a sequence by using the default equality comparer to compare values.
       ///</summary>
       public static IEnumerable<TSource> myDistinct<TSource> (this IEnumerable<TSource> source)
       {
           return source.myDistinct(EqualityComparer<TSource>.Default);
           
           /*HashSet<TSource> set = new HashSet<TSource>();           
           foreach (var item in source)
           {
               if (set.Add(item))
                {
                    yield return item;
                }
           }  */       

       }
               
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified IEqualityComparer<T> to compare values.
        ///</summary>
        public static IEnumerable<TSource> myDistinct<TSource>(
            this IEnumerable<TSource> source,
            IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> setSource = new HashSet<TSource>(comparer);
            foreach (TSource item in source)
            {
                if (setSource.Add(item))
                {
                    yield return item;
                }
            }
        }        
    }
}