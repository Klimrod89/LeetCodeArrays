namespace DemoLibrary;

public class SortedSquares
{
    public int[] SquareSort(int[] nums)
    {
        int[] output = nums;
        for(int i = 0; i < nums.Length; i++)
        {
            output[i] *= nums[i];
        }
        Array.Sort(output);
        return output;
    }
}
