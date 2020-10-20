using System;
using System.Collections.Generic;

namespace LinqTrain
{

    
    ///<summery>
    /// Overloads of Average Operations Reimplementation.
    /// Computes the average of a sequence of numeric values.
    ///</summary>
    public static class AverageOperationsTrain 
    {
        ///<summary>
        /// Computes the average of a sequence of Int values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double myAverage<TSource> (this IEnumerable<TSource> source, 
        Func<TSource,int> selector)
        {
            double sum = 0;
            var count = 0;
            foreach (var item in source)
            {
                sum = sum + selector(item);
                count ++;
            } 
            return sum/count;
        }
        ///<summary>
        /// Computes the average of sequence of nullable Int64 values.
        ///</summary>
        public static double? myAverage (this IEnumerable<Nullable<long>> source)
        {
            long sum = 0;
            var count = 0;
            foreach (var item in source)
            {
                sum = sum + item.GetValueOrDefault();
                count++;
            }
            return (double)sum/count;
        }
        ///<summary>
        /// Computes the average of a sequence of nullable Single values.
        ///</summary>
        public static float? myAverage (this IEnumerable<float?> source)
        {
            float? current = 0;
            var count = 0;
            foreach (var item in source)
            {
                current = current + item.GetValueOrDefault();                
                count++;
            }
            return current/count;
        }
        ///<summary>
        /// Computes the average of a sequence of Single values.
        ///</summary>
        public static float myAverage (this IEnumerable<float> source)
        {
            float sum = 0;
            var count = 0;
            foreach (var item in source)
            {
                sum = sum + item;                
                count++;
            }
            return sum/count;
        }
    }
}