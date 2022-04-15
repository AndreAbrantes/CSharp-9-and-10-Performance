namespace CSharp_9_and_10_Performance;

public class NewFeatures
{
    public static int SwitchPatternMatching(int[] values)
    {
        return values switch
        {
            [int first] => first,
            [_, int second] => second,
            [_, .. int[] lastOnes] => lastOnes.Sum(),
            _ => 0
        };
    }
}

