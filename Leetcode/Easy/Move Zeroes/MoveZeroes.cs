namespace Leetcode.Easy.Move_Zeroes;

public static class MoveZeroes
{
    /// <summary>
    /// Two pointers :)
    /// </summary>
    public static void _MoveZeroes(int[] nums)
    {
        var j = 0;
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[j] == 0 && nums[i] != 0)
            {
                (nums[j], nums[i]) = (nums[i], nums[j]);
            }

            if (nums[j] != 0)
            {
                j++;
            }
        }
    }
}