using Xunit;

namespace Leetcode.Easy.Squares_of_a_Sorted_Array;

public class SquaresOfASortedArrayTests
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {-4, -1, 0, 3, 10};
        var expected = new[] {0,1,9,16,100};
        
        //Act
        var result = SquaresOfASortedArray.SortedSquares(nums);
        
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {-7,-3,2,3,11};
        var expected = new[] {4,9,9,49,121};
        
        //Act
        var result = SquaresOfASortedArray.SortedSquares(nums);
        
        //Assert
        Assert.Equal(expected, result);
    }
}