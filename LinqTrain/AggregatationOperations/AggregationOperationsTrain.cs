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
        /// Returns an Int64 that represents the total number of elements in a sequence
        ///</summary>
        public static int myLongCount<TSource> (this IEnumerable<TSource> source)
        {           
            var sourceIterator = source.GetEnumerator(); 

            int count = 0;
            while(sourceIterator.MoveNext())
            {
                count++;
            }
            return count;

        }
        ///<summary>
        /// Returns an Int64 that represents how many elements in a sequence satisfy a condition.
        ///</summary>
        public static long myLongCount<TSource> (
            this IEnumerable<TSource> source, 
            Func<TSource,bool> predicate)
        {
            int count = 0;
            foreach (var item in source)
            {
                if(predicate(item)){
                    count ++;
                }                           
            }             
            return count;            

        }


        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        public static int myCount<TSource> (this IEnumerable<TSource> source)
        {           
            var sourceIterator = source.GetEnumerator(); 

            int count = 0;
            while(sourceIterator.MoveNext())
            {
                count++;
            }
            return count;

        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence satisfy a condition.
        ///</summary>
        public static int myCount<TSource> (
            this IEnumerable<TSource> source, 
            Func<TSource,bool> predicate)
        {
            int count = 0;
            foreach (var item in source)
            {
                if(predicate(item)){
                    count ++;
                }                           
            }             
            return count;            

        }

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
            TAccumulate current = seed;
            foreach (var item in source)
            {
                current = func(current, item);
            }
            return current;
            //return source.myAggregate(seed, func, x => x);

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