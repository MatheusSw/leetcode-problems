namespace Leetcode.Easy.Binary_Search;

public static class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        while (low <= high)
        {
            var middle = low + (high - low) / 2;
            if (target == nums[middle])
            {
                return middle;
            }

            if (nums[middle] < target)
            {
                low = middle + 1;
            }

            if (nums[middle] > target)
            {
                high = middle - 1;
            }
        }

        return -1;
    }
}