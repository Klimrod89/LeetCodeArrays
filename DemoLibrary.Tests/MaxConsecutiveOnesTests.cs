
namespace ArraysDemo.DemoLibrary.Tests;

public class MaxConsecutiveOnesTests
{

    [Theory]
    [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
    [InlineData(new int[] { 1, 0, 1, 1, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 6)]
    [InlineData(new int[] { 1, 1, 1, 0, 1, 1 }, 3)]
    [InlineData(new int[] { 1, 1, 1, 0, 1, 1, 1 }, 3)]
    [InlineData(new int[] { 1, 1, 1, 0, 1, 1, 1, 1 }, 4)]
    [InlineData(new int[] { 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0 }, 5)]
    public void FindMaxConsecutiveOnesTest(int[] nums, int expected)
    {
        // Arrange
        var sut = new MaxConsecutiveOnes();

        // Act
        int actual = sut.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
    
}
