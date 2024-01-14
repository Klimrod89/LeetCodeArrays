namespace DemoLibrary.Tests;

public class NoDuplicateSortedTest
{
	[Theory]
	[InlineData(new int[]{1, 1, 2}, new int[]{1, 2, 0})]
	[InlineData(new int[]{0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, new int[]{0, 1, 2, 3, 4, 0, 0, 0, 0, 0})]
	[InlineData(new int[]{1}, new int[]{1})]
	[InlineData(new int[]{}, new int[]{})]
	[InlineData(new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, new int[]{1, 0, 0, 0, 0, 0, 0, 0, 0, 0})]
	public void Remove_Duplicates_In_Sorted_Array(int[] nums, int[] expected)
	{
		// Arrange
		NoDuplicateSorted sut = new();

		// Act
		sut.RemoveDuplicates(nums);

		// Assert
		Assert.Equal(nums, expected);
	}
}