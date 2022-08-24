namespace Leetcode.Easy.Search_Insert_Position;

public static class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        var possibleIndex = 0;

        while (low <= high)
        {
            var middleIndex = low + (high - low) / 2;
            if (nums[middleIndex] == target)
            {
                return middleIndex;
            }

            if (nums[middleIndex] < target)
            {
                low = middleIndex + 1;
                possibleIndex = low;
            }

            if (nums[middleIndex] > target)
            {
                high = middleIndex - 1;
                possibleIndex = middleIndex;
            }
        }

        return possibleIndex;
    }
}