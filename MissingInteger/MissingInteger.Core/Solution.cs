namespace MissingInteger.Core
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int GetMissingInteger(int[] array)
        {
            var min = 1;
            foreach (var elem in array.Where(e => e > 0).OrderBy(e => e))
            {
                if (min == elem)
                {
                    min++;
                }
            }
            return min;
        }
    }
}
