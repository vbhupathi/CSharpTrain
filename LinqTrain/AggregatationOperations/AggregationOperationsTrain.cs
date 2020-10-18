using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summery>
    /// Extension Methods of Aggregation Operations Reimplementation.
    ///</summary>
    public static class AggregationOperationsTrain 
    {
        ///<summary>
        /// Applies an accumulator function over a sequence.
        /// The specified seed value is used as the initial accumulator value, 
        /// and the specified function is used to select the result value.
        ///</summary>
        public static TResult myAggregate<TSource,TAccumulate,TResult>(
            this IEnumerable<TSource> source, 
            TAccumulate seed, 
            Func<TAccumulate,TSource,TAccumulate> func, 
            Func<TAccumulate,TResult> resultSelector)	
        {

            TAccumulate current = seed;
            foreach (var item in source)
            {
                current = func(current, item);
            }
            return resultSelector(current);

        }

        ///<summary>
        /// Applies an accumulator function over a sequence. 
        ///The specified seed value is used as the initial accumulator value.
        ///</summary>

        public static TAccumulate myAggregate<TSource,TAccumulate> (
            this IEnumerable<TSource> source, 
            TAccumulate seed, 
            Func<TAccumulate,TSource,TAccumulate> func)
        {
            return source.myAggregate(seed, func, x => x);

        }

        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>

        public static TSource myAggregate<TSource> (
            this IEnumerable<TSource> source, 
            Func<TSource,TSource,TSource> func)
        {
            // an enumerator that can be used to iterate through the collection.
        
            var sourceIterator= source.GetEnumerator();
            if (!sourceIterator.MoveNext())
            {
                throw new InvalidOperationException("Source sequence was empty");
            }

            var currentItem = sourceIterator.Current;
            while(sourceIterator.MoveNext())
            {
                currentItem = func(currentItem, sourceIterator.Current);

            }
            return currentItem;
        
        }

    }
}