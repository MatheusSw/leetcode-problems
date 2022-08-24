namespace Leetcode.Easy.RunningSum1dArray;

public static class RunningSum1dArray
{
    public static int[] RunningSum(int[] nums)
    {
        var accumulated = nums;
        for (var numsIndex = 0; numsIndex < nums.Length; numsIndex++)
        {
            if (numsIndex == 0)
            {
                continue;
            }

            accumulated[numsIndex] = accumulated[numsIndex - 1] + nums[numsIndex];
        }

        return accumulated;
    }
}