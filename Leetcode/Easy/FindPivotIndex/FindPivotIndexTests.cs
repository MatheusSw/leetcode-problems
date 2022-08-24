using Xunit;

namespace Leetcode.Easy.FindPivotIndex;

public class FindPivotIndexTests
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {1, 7, 3, 6, 5, 6};
        const int expected = 3;
        
        //Act
        var result = FindPivotIndex.PivotIndex(nums);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {1,2,3};
        const int expected = -1;
        
        //Act
        var result = FindPivotIndex.PivotIndex(nums);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test3()
    {
        //Arrange
        var nums = new[] {2,1,-1};
        const int expected = 0;
        
        //Act
        var result = FindPivotIndex.PivotIndex(nums);
        
        //Assert
        Assert.Equal(expected, result);
    }
}