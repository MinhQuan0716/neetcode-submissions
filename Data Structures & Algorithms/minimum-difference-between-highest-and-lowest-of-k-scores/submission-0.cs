public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int min = int.MaxValue;
        int left = 0;
        int right = k - 1;
        while(right<nums.Length){
            int diff = nums[right] - nums[left];
            min = Math.Min(diff,min);
            right++;
            left++;
        }
        return min;
    }
}