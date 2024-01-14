namespace ArraysDemo.DemoLibrary;
public class EvenDigits
{
	public int FindNumbers(int[] nums)
    {
        int count = 0;
        foreach(var i in nums)
        {
            count += i.ToString().Length % 2 == 0 ? 1 : 0;
        }
        return count;
    }
}