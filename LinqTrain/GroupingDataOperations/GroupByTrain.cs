using System;
using System.Collections.Generic;

namespace LinqTrain
{
    
    ///<summery>
    /// GroupBy Overloads Reimplementation.
    /// Groups elements that share a common attribute. Each group is represented by an IGrouping<TKey,TElement> object.
    ///</summary>
    public static class GroupByTrain 
    {
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function and creates a result value from each group and its key. The elements of each group are projected by using a specified function.
        ///</summary>
        public static IEnumerable<TResult> myGroupBy<TSource,TKey,TElement,TResult> (
            this IEnumerable<TSource> source, 
            Func<TSource,TKey> keySelector, 
            Func<TSource,TElement> elementSelector, 
            Func<TKey,IEnumerable<TElement>,TResult> resultSelector)
        {
            

        }
    }
}