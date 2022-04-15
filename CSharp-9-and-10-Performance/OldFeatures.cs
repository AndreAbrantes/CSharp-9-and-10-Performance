namespace CSharp_9_and_10_Performance
{
    internal class OldFeatures
    {
        public static int SwitchWithoutPatternMatching(int[] values)
        {
            if (values.Length == 0)
            {
                return 0;
            }
            if (values.Length == 1)
            {
                return values[0];
            }
            if (values.Length == 2)
            {
                return values[1];
            }
            if (values.Length > 2)
            {
                Span<int> spanOfValues = values;
                var lastOnes = spanOfValues.Slice(1, values.Length - 1);
                int sum = 0;
                for (int i = 0; i < lastOnes.Length; i++)
                {
                    sum += lastOnes[i];
                }
                return sum;
            }
            return -1;
        }
    }
}
