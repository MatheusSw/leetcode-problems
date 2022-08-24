namespace Leetcode.Medium.Rotate_Array;

public static class RotateArray
{
    /// <summary>
    /// This is the <code>O(n^2)</code> solution, as we need to iterate the array <code>k * nums.length</code> times
    /// and in the worst case <code>nums.length</code> may equal <code>k</code>
    /// </summary>
    public static void RotateNotOptimal(int[] nums, int k)
    {
        while (k-- > 0)
        {
            var first = nums[0];
            nums[0] = nums[^1];

            var last = 0;
            for (var i = 1; i <= nums.Length - 1; i++)
            {
                if (i == 1)
                {
                    last = nums[i];
                    nums[i] = first;
                    continue;
                }

                (nums[i], last) = (last, nums[i]);
            }
        }
    }
    
    //[WIP] Not my solution
    public static void RotateOptimal(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    
    private static void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}