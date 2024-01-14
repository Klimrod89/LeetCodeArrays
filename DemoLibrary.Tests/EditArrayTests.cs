namespace DemoLibrary.Tests;

public class EditArrayTests
{
	[Theory]
	[InlineData(new int[]{3, 2, 2, 3}, 3, new int[]{2, 2, 0, 0})]
	[InlineData(new int[]{0, 1, 2, 2, 3, 0, 4, 2}, 2, new int[]{0, 1, 3, 0, 4, 0, 0, 0})]
	[InlineData(new int[]{1}, 1, new int[]{0})]
	public void Remove_Element_And_Change_Array(int[] nums, int val, int[] expected)
	{
		// Arrange
		EditArray sut = new();
		// Act
		sut.RemoveElement(nums, val);
		// Assert
		Assert.Equal(nums, expected);
	}
}