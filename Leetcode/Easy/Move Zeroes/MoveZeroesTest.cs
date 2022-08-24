using Xunit;

namespace Leetcode.Easy.Move_Zeroes;

public class MoveZeroesTest
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {0, 1, 0, 3, 12};
        var expected = new[] {1, 3, 12, 0, 0};

        //Act
        MoveZeroes._MoveZeroes(nums);

        //Assert
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {0};
        var expected = new[] {0};

        //Act
        MoveZeroes._MoveZeroes(nums);

        //Assert
        Assert.Equal(expected, nums);
    }
}