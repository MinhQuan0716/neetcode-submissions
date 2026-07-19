public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        bool result = false;
       for(int i = 0; i< n; i++){
        for(int j = i+1; j<n; j++){
            if(nums[i]==nums[j]){
                result = true;
            }
        }
       }
       return result;
    }
}