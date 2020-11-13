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
        /// Computes the average of a sequence of nullable Int32 values.
        ///</summary>
         public static double? myAverage(this IEnumerable<int?> source) {
            long sum = 0;
            long count = 0;
            checked {
                foreach (int? v in source) {
                    if (v != null) {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            return (double)sum / count;
        }

        ///<summary>
        /// Computes the average of a sequence of nullable Double values.
        ///</summary>
        public static double? myAverage(this IEnumerable<double?> source) 
        {
            double sum = 0;
            long count = 0;
            checked {
                foreach (double? v in source) {
                    if (v != null) {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return sum / count;
            return null;
        }

        ///<summary>
        /// Computes the average of a sequence of Int64 values.
        ///</summary>
        public static double myAverage(this IEnumerable<long> source) 
        {
            long sum = 0;
            long count = 0;
            checked {
                foreach (long v in source) {
                    sum += v;
                    count++;
                }
            }
            return (double)sum / count;
        }        

        ///<summary>
        /// Computes the average of a sequence of Int32 values.
        ///</summary>
        public static double myAverage(this IEnumerable<int> source) {
            long sum = 0;
            long count = 0;
            checked {
                foreach (int v in source) {
                    sum += v;
                    count++;
                }
            }
            return (double)sum / count;
        }

        ///<summary>
        /// Computes the average of a sequence of Double values.
        ///</summary>        
        public static double myAverage(this IEnumerable<double> source) 
        {
            double sum = 0;
            long count = 0;
            checked {
                foreach (double v in source) {
                    sum += v;
                    count++;
                }
            }
            return sum / count;
        }
        
        ///<summary>
        /// Computes the average of a sequence of Decimal values.
        ///</summary>
        public static decimal myAverage(this IEnumerable<decimal> source) 
        {
            decimal sum = 0;
            long count = 0;
            checked {
                foreach (decimal v in source) {
                    sum += v;
                    count++;
                }
            }
            return sum / count;
        }

        ///<summary>
        /// Computes the average of a sequence of nullable Decimal values.
        ///</summary>
        public static decimal? myAverage(this IEnumerable<decimal?> source) 
        {
            decimal sum = 0;
            long count = 0;
            checked {
                foreach (decimal? v in source) {
                    if (v != null) {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return sum / count;
            return null;
        }

        ///<summary>
        ///Computes the average of a sequence of nullable Int32 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Computes the average of a sequence of Single values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Computes the average of a sequence of nullable Single values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Computes the average of a sequence of nullable Int64 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        ///Computes the average of a sequence of nullable Double values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Computes the average of a sequence of nullable Decimal values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        ///Computes the average of a sequence of Int64 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));


        ///<summary>
        /// Computes the average of a sequence of Int32 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double myAverage<TSource> (this IEnumerable<TSource> source, Func<TSource,int> selector)
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source,selector));

        ///<summary>
        ///Computes the average of a sequence of Double values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Computes the average of a sequence of Decimal values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>        
        public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        => myAverage(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

    }
}
