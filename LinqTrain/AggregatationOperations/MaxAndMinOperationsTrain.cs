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
    }
}