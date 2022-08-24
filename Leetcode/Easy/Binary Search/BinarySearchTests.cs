using Xunit;

namespace Leetcode.Easy.Binary_Search;

public class BinarySearchTests
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {-1, 0, 3, 5, 9, 12};
        const int target = 9;
        const int expected = 4;
        
        //Act
        var result = BinarySearch.Search(nums, target);

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {-1,0,3,5,9,12};
        const int target = 2;
        const int expected = -1;
        
        //Act
        var result = BinarySearch.Search(nums, target);

        //Assert
        Assert.Equal(expected, result);
    }
}