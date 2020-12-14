namespace LinqTrain
{
    ///<summary>
    /// Returns an empty collection.
    /// Returns an empty IEnumerable<T> that has the specified type argument.
    ///</summary>
    public class EmptyTrain
    {
        ///<summary>
        /// Returns an empty IEnumerable<T> that has the specified type argument.
        ///</summary>
        public static System.Collections.Generic.IEnumerable<TResult> myEmpty<TResult>()
        {
            return EmptyEnumerable<TResult>.Instance;
        }        
    }
    internal class EmptyEnumerable<TElement>
    {        
        public static readonly TElement[] Instance = new TElement[0];
    }
}