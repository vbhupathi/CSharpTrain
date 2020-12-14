namespace LinqTrain
{
    ///<summary>
    /// Generates a collection that contains one repeated value.
    ///</summary>
    public class RepeatTrain
    {
        public static System.Collections.Generic.IEnumerable<TResult> myRepeat<TResult> (TResult element, int count)
        {
             for (int i = 0; i < count; i++) 
             yield return element;
        }
        
    }
    
}