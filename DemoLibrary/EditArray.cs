namespace DemoLibrary;

public class EditArray
{
	/*
	Input: nums = [3,2,2,3], val = 3
	Output: 2, nums = [2,2,_,_]
	*/
	public int RemoveElement(int[] nums, int val)
	{
		int totalValInNums = Array.FindAll(nums, x => x == val).Length;
		int[] tempArray = new int[nums.Length];
		int tempArrayIncrement = 0;
		for(int i = 0; i < nums.Length; i++)
		{
			if(nums[i] == val)
			{
				continue;
			}
			else
			{
				tempArray[tempArrayIncrement++] = nums[i];
			}
		}

		for(int i = 0; i < nums.Length; i++)
		{
			nums[i] = tempArray[i];
		}
		return tempArrayIncrement;
	}
}