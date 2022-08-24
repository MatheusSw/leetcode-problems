using Xunit;

namespace Leetcode.Easy.RunningSum1dArray;

public class RunningSum1dArrayTests
{
    [Fact]
    public void Test()
    {
        //Arrange
        var nums = new[] {1, 2, 3, 4};
        var expected = new[] {1, 3, 6, 10};

        //Act
        var result = RunningSum1dArray.RunningSum(nums);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        var nums = new[] {1, 1, 1, 1, 1};
        var expected = new[] {1, 2, 3, 4, 5};

        //Act
        var result = RunningSum1dArray.RunningSum(nums);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        //Arrange
        var nums = new[] {3, 1, 2, 10, 1};
        var expected = new[] {3, 4, 6, 16, 17};

        //Act
        var result = RunningSum1dArray.RunningSum(nums);

        //Assert
        Assert.Equal(expected, result);
    }
}