namespace DemoLibrary.Tests;

public class MultiplyAndSortedTests
{
    [Theory]
    [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
    [InlineData(new int[]{0, -5, 3, 10}, new int[]{0, 9, 25, 100})]
    [InlineData(new int[]{-7, -3, 2, 3, 11}, new int[]{4, 9, 9, 49, 121})]
    [InlineData(new int[]{5, 0, -9, 1, 1, -2, -1}, new int[]{0, 1, 1, 1, 4, 25, 81})]
    public void Return_Sorted_Squares(int[] nums, int[] expected)
    {
        // Arrange
        var sut = new MultiplyAndSorted();

        // Act
        int[] actual = sut.SortedSquares(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
}
