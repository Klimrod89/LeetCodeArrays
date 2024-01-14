namespace ArraysDemo.DemoLibrary.Tests;
public class EvenDigitsTests
{
    [Theory]
    [InlineData(new int[] { 12, 345, 2, 6, 7896 }, 2)]
    [InlineData(new int[] { 555, 901, 482, 1771 }, 1)]
	public void FindNumbersTest(int[] nums, int expected)
    {
        // Arrange
        EvenDigits sut = new();
       
        // Act
        int actual = sut.FindNumbers(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}