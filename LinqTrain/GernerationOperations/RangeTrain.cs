namespace LinqTrain
{
    ///<summary>
    /// Generates a sequence of integral numbers within a specified range.
    ///</summary>
    public static class RangeTrain
    {
        public static System.Collections.Generic.IEnumerable<int> myRange (int start, int count)
        {
            for (int i = 0; i < count; i++) 
            yield return start + i;
        }
        
    }
    
}