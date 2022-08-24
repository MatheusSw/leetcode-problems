namespace Leetcode.Easy.Squares_of_a_Sorted_Array;

public static class SquaresOfASortedArray
{
    public static int[] SortedSquares(int[] nums) {
        var i = 0;
        var j = nums.Length - 1;
        var result = new int[nums.Length];

        for (var k = nums.Length - 1; k >= 0; k--)
        {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                result[k] = nums[i] * nums[i];
                i++;
            }
            else
            {
                result[k] = nums[j] * nums[j];
                j--;
            }
        }
        return result;
    }
}