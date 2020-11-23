using System;
using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Projection refers to the operation of transforming an object into a new form that often consists only of those properties that will be subsequently used. 
    ///</summary>
    public static class ProjectionOperationsTrain
    {
        
        ///<summary>
        ///Projects each element of a sequence into a new form
        ///</summary>\
        public static IEnumerable<TResult> mySelect<TSource,TResult> (this IEnumerable<TSource> source, Func<TSource,TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);                
            }

        }

        ///<summary>
        /// Projects each element in the sequence into a new form by incorporating the element's index.
        ///</summary>
        public static IEnumerable<TResult> mySelect<TSource,TResult>(this IEnumerable<TSource> source, Func<TSource,Int32,TResult> selector)
        {
            var i = 0;
            foreach (var item in source)
            {
                yield return selector(item, i);  
                i++;              
            }           

        }

        ///<summary>
        /// Projects each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.
        ///</summary>
        public static IEnumerable<TResult> mySelectMany<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector)
        {
            foreach (var item in source)
            {
                foreach (var result in selector(item))
                {
                    yield return result;
                }
            }
        }

        ///<summary>
        /// Projects each element of a sequence to an IEnumerable<T>, flattens the resulting sequences into one sequence, 
        ///and invokes a result selector function on each element therein.
        ///</summary>
        public static IEnumerable<TResult> mySelectMany<TSource,TCollection,TResult> (
            this IEnumerable<TSource> source, 
            Func<TSource,IEnumerable<TCollection>> collectionSelector, 
            Func<TSource,TCollection,TResult> resultSelector)
        {
             foreach (var item in source)
            {
                foreach (var collectionItem in collectionSelector(item))
                {
                    yield return resultSelector(item, collectionItem);
                }
            }
        }


        ///<summary>
        /// Projects each element of a sequence to an IEnumerable<T>, flattens the resulting sequences into one sequence, 
        /// and invokes a result selector function on each element therein. 
        /// The index of each source element is used in the intermediate projected form of that element.
        ///</summary>
        public static IEnumerable<TResult> mySelectMany<TSource, TCollection, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
            Func<TSource, TCollection, TResult> resultSelector)
        {
            int index = 0;
            foreach (var item in source)
            {
                foreach (var collectionItem in collectionSelector(item, index++))
                {
                    yield return resultSelector(item, collectionItem);
                }
            }
        }

        ///<summary>
        /// Projects each element of a sequence to an IEnumerable<T>, and flattens the resulting sequences into one sequence. 
        /// The index of each source element is used in the projected form of that element.
        ///</summary>

        public static IEnumerable<TResult> mySelectMany<TSource,TResult> (
            this IEnumerable<TSource> source, 
            Func<TSource,int,IEnumerable<TResult>> selector)
        {
            var i = 0;
            foreach (var item in source)
            { 
                foreach (var collectionItem in selector(item, i++))
                {           
                    yield return collectionItem;  
                }              
            }            

        }

        ///<summary>
        /// Creates a List<T> from an IEnumerable<T>.
        /// A List<T> that contains elements from the input sequence.
        ///</summary>
        public static List<TSource> myToList<TSource> (
        this IEnumerable<TSource> source)
        => new List<TSource>(source);          
        
        
        ///<summary>
        ///
        ///</summary>

    //     public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source) 
    //     {
    //         foreach (var item in source)
    //         {
    //             yield return item;
    //         }
    //         return ReverseIterator<TSource>(source);
    //     }

    // public static IEnumerable<TSource> ReverseIterator<TSource>( this IEnumerable<TSource> source) 
    // { 
    //     var buffer = new Buffer<TSource>(source);
    //     for (int i = buffer.count - 1; i >= 0; i--) 
    //     yield return buffer.items[i]; 
    // } 


        
    }
    
}