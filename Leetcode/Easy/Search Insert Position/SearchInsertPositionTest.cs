using Xunit;

namespace Leetcode.Easy.Search_Insert_Position;

public class SearchInsertPositionTest
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {1, 3, 5, 6};
        const int target = 5;
        const int expected = 2;
        
        //Act
        var result = SearchInsertPosition.SearchInsert(nums, target);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {1, 3, 5, 6};
        const int target = 2;
        const int expected = 1;
        
        //Act
        var result = SearchInsertPosition.SearchInsert(nums, target);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test3()
    {
        //Arrange
        var nums = new[] {1, 3, 5, 6};
        const int target = 7;
        const int expected = 4;
        
        //Act
        var result = SearchInsertPosition.SearchInsert(nums, target);
        
        //Assert
        Assert.Equal(expected, result);
    }
}