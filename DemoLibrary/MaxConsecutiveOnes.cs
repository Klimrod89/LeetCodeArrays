namespace ArraysDemo.DemoLibrary;
public class MaxConsecutiveOnes
{
	public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int current = 0;
        foreach (int num in nums)
        {
            if (num == 1)
            {
                current++;
                max = Math.Max(max, current);
            }
            else
            {
                current = 0;
            }
        }
        return max;
    }
}