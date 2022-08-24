using Xunit;

namespace Leetcode.Medium.Rotate_Array;

public class RotateArrayTests
{
    [Fact]
    public void TestNotOptimal()
    {
        var nums = new[] {1, 2, 3, 4, 5, 6, 7};
        const int k = 3;

        var expected = new[] {5, 6, 7, 1, 2, 3, 4};

        RotateArray.RotateNotOptimal(nums, k);

        Assert.Equal(expected, nums);
    }

    [Fact]
    public void TestNotOptimal2()
    {
        var nums = new[] {-1, -100, 3, 99};
        const int k = 2;

        var expected = new[] {3, 99, -1, -100};

        RotateArray.RotateNotOptimal(nums, k);

        Assert.Equal(expected, nums);
    }
    
    [Fact]
    public void TestOptimal()
    {
        var nums = new[] {1, 2, 3, 4, 5, 6, 7};
        const int k = 3;

        var expected = new[] {5, 6, 7, 1, 2, 3, 4};

        RotateArray.RotateOptimal(nums, k);

        Assert.Equal(expected, nums);
    }

    [Fact]
    public void TestOptimal2()
    {
        var nums = new[] {-1, -100, 3, 99};
        const int k = 2;

        var expected = new[] {3, 99, -1, -100};

        RotateArray.RotateOptimal(nums, k);

        Assert.Equal(expected, nums);
    }
    
    [Fact]
    public void TestOptimal3()
    {
        var nums = new[] {-1};
        const int k = 2;

        var expected = new[] {-1};

        RotateArray.RotateOptimal(nums, k);

        Assert.Equal(expected, nums);
    }
}