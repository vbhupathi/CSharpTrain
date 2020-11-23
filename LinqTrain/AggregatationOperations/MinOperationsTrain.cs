using System;
using System.Collections.Generic;

namespace LinqTrain
{    
    ///<summery>
    /// Overloads of Min Operations Reimplementation.
    /// Returns the minimum value in a sequence of values.
    ///</summary>
    public static class MinOperationsTrain 
    {
        
        ///<summary>
        /// Returns the minimum value in a sequence of nullable Single values.
        ///</summary>
        public static float? myMin (this IEnumerable<Nullable<float>> source)
        {
            float? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the minimum value in a sequence of Int32 values.
        ///</summary>
        public static int myMin (this IEnumerable<int> source)
        {            
            int currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable Int64 values.
        ///</summary>
        public static long? myMin (this System.Collections.Generic.IEnumerable<Nullable<long>> source)
        {
            long? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the minimum value in a sequence of Single values.
        ///</summary>
        public static float myMin (this System.Collections.Generic.IEnumerable<float> source)
        {
            float currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the minimum value in a sequence of nullable Int32 values.
        ///</summary>
        public static int? myMin (this System.Collections.Generic.IEnumerable<Nullable<int>> source)
        {
            int? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }
        ///<summary>
        /// Returns the minimum value in a sequence of Decimal values.
        ///</summary>
        public static decimal myMin (this System.Collections.Generic.IEnumerable<decimal> source)
        {
            decimal currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }
        
        ///<summary>
        /// Returns the minimum value in a sequence of Nullable Decimal values.
        ///</summary>
        public static decimal? myMin (this System.Collections.Generic.IEnumerable<Nullable<decimal>> source)
        {
            decimal? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        //<summary>
        /// Returns the minimum value in a sequence of Int64 values.
        ///</summary>
        public static long myMin (this System.Collections.Generic.IEnumerable<long> source)
        {
            long currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item < currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        ///<summary>
        /// Returns the minimum value in a sequence of Double values.
        ///</summary>
        public static double myMin (this IEnumerable<double> source)
        {
            double currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {
                if (hasValue && item < currentValue)
                {
                    currentValue = item;
                }
                    hasValue = true;
            }
            return currentValue;
        }

        ///<summary>
        /// Returns the minimum value in a sequence of nullable Double values.
        ///</summary>
        public static double? myMin (this IEnumerable<Nullable<double>> source)
        {
            double? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {
                if (hasValue && item < currentValue)
                {
                    currentValue = item;
                }
                    hasValue = true;
            }
            return currentValue;
        }
        ///<summary>
        ///Invokes a transform function on each element of a generic sequence and returns the minimum resulting value.
        ///</summary>
        public static TResult myMin<TSource,TResult> (this IEnumerable<TSource> source, Func<TSource,TResult> selector)
        {
            var currentValue = selector(source.GetEnumerator().Current);            
            bool hasValue = false;
            foreach (var item in source)
            {  
                if (hasValue)              
                currentValue = selector(item);
                hasValue = true;
            }
            return currentValue;
        }

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Single value.
        ///</summary>
        public static float myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Nullable Single value.
        ///</summary>
        public static float? myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Nullable Int64 value.
        ///</summary>
        public static long? myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Nullable Int32 value.
        ///</summary>
        public static int? myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Nullable Double value.
        ///</summary>
        public static double? myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Int64 value.
        ///</summary>
        public static long myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Int32 value.
        ///</summary>
        public static int myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Double value.
        ///</summary>
        public static double myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));
        
        
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Decimal value.
        ///</summary>
        public static decimal myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));

        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        public static TSource myMin<TSource> (this IEnumerable<TSource> source)
        {
            Comparer<TSource> compareValue = Comparer<TSource>.Default;
            TSource value = default(TSource);
            var currentValue = source.GetEnumerator().Current;            
            if (value == null) {
                foreach (var item in source) {
                    if (item != null && (value == null || compareValue.Compare(item, value) < 0))
                        value = item;
                }
                return value;
            }
            else {
                bool hasValue = false;
                foreach (TSource item in source) {
                    if (hasValue) {
                        if (compareValue.Compare(item, value) < 0)
                            value = item;
                    }
                    else {
                        value = item;
                        hasValue = true;
                    }
                }
                return value;
            }
        }

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum Nullable Decimal value.
        ///</summary>
        public static decimal? myMin<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector) 
        => myMin(LinqTrain.ProjectionOperationsTrain.mySelect(source, selector));        
    }
}