namespace DemoLibrary.Tests;

public class DoubleExistsTests
{

	[Theory]
	[InlineData(new int[] {10, 2, 5, 3}, true)]
	[InlineData(new int[] {7, 1, 14, 11}, true)]
	[InlineData(new int[] {14, 1, 7, 11}, true)]
	[InlineData(new int[] {3, 1, 7, 11}, false)]

	
	public void Check_If_A_Digit_And_Its_Double_Exist(int[] arr, bool expected)
	{
		// Arrange
		DoubleExists sut = new();
		// Act
		bool actual = sut.CheckIfExists(arr);
		// Assert
		Assert.Equal(actual, expected);
	}
}