using System.Collections.Generic;

namespace LinqTrain
{
    ///<summary>
    /// Replaces an empty collection with a default valued singleton collection.
    /// Returns the elements of an IEnumerable<T>, or a default valued singleton collection if the sequence is empty.
    ///</summary>
    public static class DefaultIfEmptyTrain
    {
       ///<summary>
       /// Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.
       ///</summary>
       public static System.Collections.Generic.IEnumerable<TSource> myDefaultIfEmpty<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, TSource defaultValue)
       {
           using (IEnumerator<TSource> e = source.GetEnumerator()) {
                if (e.MoveNext()) {
                    do {
                        yield return e.Current;
                    } while (e.MoveNext());
                }
                else {
                    yield return defaultValue;
                }
            }
       }
       
       ///<summary>
       /// Returns the elements of the specified sequence or the type parameter's default value in a singleton collection if the sequence is empty.
       ///</summary>
        public static IEnumerable<TSource> myDefaultIfEmpty<TSource>(this IEnumerable<TSource> source) 
        {
            return myDefaultIfEmpty(source, default(TSource));
        }        
        
    }
}