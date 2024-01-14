namespace DemoLibrary.Tests;

public class MergeAndOrderTests
{
    [Theory]
    [InlineData(new int[] {1, 2, 3, 0, 0, 0}, 3, new int[] {2, 5, 6}, 3, new int[]{1, 2, 2, 3, 5, 6})]
	[InlineData(new int[] {1}, 1, new int[] {}, 0, new int[]{1})]
    [InlineData(new int[] {0, 0}, 1, new int[] {1}, 1, new int[]{0, 1})]


    
    public void Merge_And_Order(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Arrange
        MergeAndOrder sut = new();

        // Act
        sut.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Equal(nums1, expected);
    }
}