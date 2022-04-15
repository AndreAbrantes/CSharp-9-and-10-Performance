using BenchmarkDotNet.Attributes;

namespace CSharp_9_and_10_Performance
{
    [MemoryDiagnoser(false)]
    public class BenchmarkTests
    {
        [Params(
                //new int[0],
                //new[] { 1 },
                //new[] { 1, 2 },
                new[] { 1, 2, 3 })]
        public int[] Parameters { get; set; } = Array.Empty<int>();
        
        [Benchmark]
        public int SwitchPatternMatching()
        {
            return NewFeatures.SwitchPatternMatching(Parameters);
        }

        [Benchmark]
        public int SwitchWithoutPatternMatching()
        {
            return NewFeatures.SwitchPatternMatching(Parameters);
        }

        public static void Run()
        {
            int[][] matrix = new int[][] {
                new int[0],
                new[] { 1 },
                new[] { 1, 2 },
                new[] { 1, 2, 3 }
            };
            foreach (var values in matrix)
            {
                Console.WriteLine("Current Values");
                Console.WriteLine(string.Join(",", values));

                var newFeaturesResult = NewFeatures.SwitchPatternMatching(values);
                var oldFeaturesResult = OldFeatures.SwitchWithoutPatternMatching(values);

                Console.WriteLine("Results for New Features");
                Console.WriteLine(newFeaturesResult);

                Console.WriteLine("Results for Old Features");
                Console.WriteLine(oldFeaturesResult);
                Console.WriteLine();
            }
        }
    }
}
