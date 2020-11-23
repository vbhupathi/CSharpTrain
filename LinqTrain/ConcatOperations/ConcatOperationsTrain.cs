using System;
using System.Collections.Generic;

namespace LinqTrain
{

    
    ///<summery>
    /// Concatenation refers to the operation of appending one sequence to another.
    ///</summary>
    public static class ConcatOperationsTrain 
    {
        
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>

        public static System.Collections.Generic.IEnumerable<TSource> myConcat<TSource> (this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
        {
            foreach (var item in first)
            { 
                yield return item;
            }
            foreach (var item in second)
            {
                yield return item;
            }
        }
    }
}