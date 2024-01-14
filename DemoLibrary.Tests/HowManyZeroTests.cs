namespace DemoLibrary.Tests;

public class HowManyZeroTests
{
    [Theory]
    [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
    [InlineData(new int[] {4, 5, 0, 0, 0, 2, 5, 0, 2, 4}, new int[] {4, 5, 0, 0, 0, 0, 0, 0, 2, 5})]
    public void Duplicate_Every_Zero(int[] arr, int[] expected)
    {
        // Arrange
        HowManyZero sut = new();

        // Act
        sut.DuplicateZeros(arr);

        // Assert
        Assert.Equal(expected, arr);
    }
}
