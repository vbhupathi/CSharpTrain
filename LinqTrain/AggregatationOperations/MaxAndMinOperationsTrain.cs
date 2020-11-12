using System;
using System.Collections.Generic;

namespace LinqTrain
{

    
    ///<summery>
    /// Overloads of Max and Min Operations Reimplementation.
    /// Returns the maximum and minimum value in a sequence of values.
    ///</summary>
    public static class MaxAndMinOperationsTrain 
    {
        
        ///<summary>
        /// Returns the maximum value in a sequence of nullable Single values.
        ///</summary>
        public static float? myMax (this IEnumerable<Nullable<float>> source)
        {
            float? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the maximum value in a sequence of Int32 values.
        ///</summary>
        public static int myMax (this IEnumerable<int> source)
        {            
            int currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable Int64 values.
        ///</summary>
        public static long? myMax (this System.Collections.Generic.IEnumerable<Nullable<long>> source)
        {
            long? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the maximum value in a sequence of Single values.
        ///</summary>
        public static float myMax (this System.Collections.Generic.IEnumerable<float> source)
        {
            float currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }

        ///<summary>
        /// Returns the maximum value in a sequence of nullable Int32 values.
        ///</summary>
        public static int? myMax (this System.Collections.Generic.IEnumerable<Nullable<int>> source)
        {
            int? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }
        ///<summary>
        /// Returns the maximum value in a sequence of Decimal values.
        ///</summary>
        public static decimal myMax (this System.Collections.Generic.IEnumerable<decimal> source)
        {
            decimal currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;

        }
        
        ///<summary>
        /// Returns the maximum value in a sequence of Nullable Decimal values.
        ///</summary>
        public static decimal? myMax (this System.Collections.Generic.IEnumerable<Nullable<decimal>> source)
        {
            decimal? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        //<summary>
        /// Returns the maximum value in a sequence of Int64 values.
        ///</summary>
        public static long myMax (this System.Collections.Generic.IEnumerable<long> source)
        {
            long currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {                   
                if (hasValue && item > currentValue)
                {
                    currentValue = item;                    
                } 
                hasValue = true;              
            }
            return currentValue;
        }
        ///<summary>
        /// Returns the maximum value in a sequence of Double values.
        ///</summary>
        public static double myMax (this IEnumerable<double> source)
        {
            double currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {
                if (hasValue && item > currentValue)
                {
                    currentValue = item;
                }
                    hasValue = true;
            }
            return currentValue;
        }

        ///<summary>
        /// Returns the maximum value in a sequence of nullable Double values.
        ///</summary>
        public static double? myMax (this IEnumerable<Nullable<double>> source)
        {
            double? currentValue = 0;
            bool hasValue = false;
            foreach (var item in source)
            {
                if (hasValue && item > currentValue)
                {
                    currentValue = item;
                }
                    hasValue = true;
            }
            return currentValue;
        }
        ///<summary>
        ///Invokes a transform function on each element of a generic sequence and returns the maximum resulting value.
        ///</summary>
        public static TResult myMax<TSource,TResult> (this IEnumerable<TSource> source, Func<TSource,TResult> selector)
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
        /// Invokes a transform function on each element of a sequence and returns the maximum Single value.
        ///</summary>
        public static float myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Nullable Single value.
        ///</summary>
        public static float? myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<float>> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Nullable Int64 value.
        ///</summary>
        public static long? myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<long>> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Nullable Int32 value.
        ///</summary>
        public static int? myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<int>> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Nullable Double value.
        ///</summary>
        public static double? myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<double>> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Int64 value.
        ///</summary>
        public static long myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Int32 value.
        ///</summary>
        public static int myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Double value.
        ///</summary>
        public static double myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));
        
        
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum Decimal value.
        ///</summary>
        public static decimal myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));

        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        public static TSource myMax<TSource> (this IEnumerable<TSource> source)
        {
            Comparer<TSource> compareValue = Comparer<TSource>.Default;
            TSource value = default(TSource);
            var currentValue = source.GetEnumerator().Current;            
            if (value == null) {
                foreach (var item in source) {
                    if (item != null && (value == null || compareValue.Compare(item, value) > 0))
                        value = item;
                }
                return value;
            }
            else {
                bool hasValue = false;
                foreach (TSource item in source) {
                    if (hasValue) {
                        if (compareValue.Compare(item, value) > 0)
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
        /// Invokes a transform function on each element of a sequence and returns the maximum Nullable Decimal value.
        ///</summary>
        public static decimal? myMax<TSource>(this IEnumerable<TSource> source, Func<TSource, Nullable<decimal>> selector) 
        => myMax(LinqTrain.FilterDataAndProjectionOperations.mySelect(source, selector));        
    }
}