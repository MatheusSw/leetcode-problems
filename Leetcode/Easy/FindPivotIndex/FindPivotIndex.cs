namespace Leetcode.Easy.FindPivotIndex;

public static class FindPivotIndex
{
    public static int PivotIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            if (i != 0)
            {
                leftSum += nums[i - 1];
            }

            rightSum -= nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}