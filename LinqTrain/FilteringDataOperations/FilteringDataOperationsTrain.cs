using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Filtering refers to the operation of restricting the result set to contain only those elements that satisfy a specified condition. It is also known as selection.
    ///</summary>
    public static class FilteringDataOperationsTrain
    {
        ///<summary>
        /// Selects values, depending on their ability to be cast to a specified type.
        /// Filters the elements of an IEnumerable based on a specified type.
        ///</summary>
        public static IEnumerable<TResult> myOfType<TResult> (this System.Collections.IEnumerable source)
        {
            foreach (var item in source)
            {
                yield return (TResult)item;
            }

        }

        
        /// <summary>
        /// Filters a sequence of values based on a predicate        
        /// </summary>
        public static IEnumerable<TSource> myWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, Boolean> predicate)
        {
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }                
            }
        }

        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.
        ///</summary>
        public static IEnumerable<TSource> myWhere<TSource> (this IEnumerable<TSource> source, Func<TSource,int,bool> predicate)
        {
                int i = 0;

            foreach (var item in source)
            {
                if (predicate(item, i))
                {
                    yield return item;                    
                }
                i++;                
            }
        }
    }
}