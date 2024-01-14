namespace DemoLibrary;

public class MultiplyAndSorted
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(x => (int)Double.Pow(x, 2)).OrderBy(x => x).ToArray();
    }
}
