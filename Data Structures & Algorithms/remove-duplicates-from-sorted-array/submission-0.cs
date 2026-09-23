public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int left = 1, right = 1;
       while (right < nums.Length){
            if(nums[right] == nums[left - 1]){
                  right++;
            } else{
                nums[left] = nums[right];
                left++;
                right++;
            }
        }
        return left;
    }
}