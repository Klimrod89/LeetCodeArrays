namespace DemoLibrary.Tests;

public class SortedSquaresTests
{
    [Theory]
    [InlineData(new int[]{2, 6, 3, -4, 0}, new int[]{0, 4, 9, 16, 36})]
    public void Square_And_Sort(int[] nums, int[] expected)
    {
        // Arrange
        SortedSquares sortedSquares = new();
        // Act
        int[] actual  = sortedSquares.SquareSort(nums);
        // Assert
        Assert.Equal(actual, expected);
    }

}
