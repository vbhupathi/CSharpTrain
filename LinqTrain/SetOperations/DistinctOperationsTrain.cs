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
        var value = source.GetEnumerator();
           var currentValue = value.Current;
           foreach (var item in source)
           {
               
           }
           return source;

       }
    }
}