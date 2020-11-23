using System;
using System.Collections.Generic;

namespace LinqTrain
{
    
    ///<summery>
    /// Overloads of Sum Operations Reimplementation.
    /// Computes the Sum of a sequence of numeric values.
    ///</summary>
    public static class SumOperationsTrain 
    {
        ///<summary>
        /// Computes the Sum of a sequence of Single values.
        ///</summary>
        public static float mySum (this IEnumerable<float> source)
        {
            float sum = 0;
            foreach (var item in source)
            {
                sum = sum + item;
            }
            return sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of nullable Single values.
        ///</summary>
        public static float? mySum (this IEnumerable<Nullable<float>> source)
        {
            float? current = 0;
            foreach (var item in source)
            {
                current = current + item.GetValueOrDefault();                
            }
            return current;
        }
        
        ///<summary>
        /// Computes the Sum of sequence of nullable Int64 values.
        ///</summary>
        public static double? mySum (this IEnumerable<Nullable<long>> source)
        {
            long sum = 0;
            foreach (var item in source)
            {
                sum = sum + item.GetValueOrDefault();
            }
            return (double)sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of nullable Int32 values.
        ///</summary>
         public static double? mySum(this IEnumerable<Nullable<int>> source) {
            long sum = 0;
            checked {
                foreach (var item in source) {
                    if (item != null) {
                        sum += item.GetValueOrDefault();
                    }
                }
            }
            return (double)sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of nullable Double values.
        ///</summary>
        public static double? mySum(this IEnumerable<Nullable<double>> source) 
        {
            double sum = 0;
            checked {
                foreach (var item in source) {
                    if (item != null) {
                        sum += item.GetValueOrDefault();
                    }
                }
            }
            return sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of Int64 values.
        ///</summary>
        public static double mySum(this IEnumerable<long> source) 
        {
            long sum = 0;
            checked {
                foreach (var item in source) {
                    sum += item;
                }
            }
            return (double)sum;
        }        

        ///<summary>
        /// Computes the Sum of a sequence of Int32 values.
        ///</summary>
        public static double mySum(this IEnumerable<int> source) {
            long sum = 0;
            checked {
                foreach (var item in source) {
                    sum += item;
                }
            }
            return (double)sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of Double values.
        ///</summary>        
        public static double mySum(this IEnumerable<double> source) 
        {
            double sum = 0;
            checked {
                foreach (var item in source) {
                    sum += item;
                }
            }
            return sum;
        }
        
        ///<summary>
        /// Computes the Sum of a sequence of Decimal values.
        ///</summary>
        public static decimal mySum(this IEnumerable<decimal> source) 
        {
            decimal sum = 0;
            checked {
                foreach (var item in source) {
                    sum += item;
                }
            }
            return sum;
        }

        ///<summary>
        /// Computes the Sum of a sequence of nullable Decimal values.
        ///</summary>
        public static decimal? mySum(this IEnumerable<Nullable<decimal>> source) 
        {
            decimal sum = 0;
            checked {
                foreach (var item in source) {
                    if (item != null) {
                        sum += item.GetValueOrDefault();
                    }
                }
            }
            return sum;
        }

        ///<summary>
        ///Computes the Sum of a sequence of nullable Int32 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Computes the Sum of a sequence of Single values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static float mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Computes the Sum of a sequence of nullable Single values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static float? mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Computes the Sum of a sequence of nullable Int64 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        ///Computes the Sum of a sequence of nullable Double values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double? mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Computes the Sum of a sequence of nullable Decimal values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static decimal? mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        ///Computes the Sum of a sequence of Int64 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));


        ///<summary>
        /// Computes the Sum of a sequence of Int32 values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double mySum<TSource> (this IEnumerable<TSource> source, Func<TSource,int> selector)
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source,selector));

        ///<summary>
        ///Computes the Sum of a sequence of Double values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        public static double mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Computes the Sum of a sequence of Decimal values that are obtained by invoking a transform function on each element of the input sequence.
        ///</summary>        
        public static decimal mySum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        => mySum(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

    }
}
