namespace DemoLibrary;

public class NoDuplicateSorted
{
	/*
	Input: nums = [1,1,2]
	Output: 2, nums = [1,2,_]
	*/
	public int RemoveDuplicates(int[] nums)
	{
		if(nums.Length == 0)
		{
			return 0;
		}
			
		
		int[] tempArray = new int[nums.Length];
		int currentNonDuplicateValue = nums[0];
		int tempArrayIncrement = 0;
		tempArray[tempArrayIncrement++] = nums[0];
		
		
		for(int i = 1; i < nums.Length; i++)
		{
			if(nums[i] == currentNonDuplicateValue)
			{
				continue;
			}
			else
			{
				currentNonDuplicateValue = nums[i];
				tempArray[tempArrayIncrement++] = nums[i];
			}
		}

		for(int i = 0; i < tempArray.Length; i++)
		{
			nums[i] = tempArray[i];
		}
		return tempArrayIncrement;
	}
}