public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, currSum = 0, minLength = int.MaxValue;
        for(int right = 0; right<nums.Length; right++){
            currSum+=nums[right];
            while(currSum>=target){
                minLength = Math.Min(right - left + 1, minLength);
                currSum-=nums[left];
                left++;
            }
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
}