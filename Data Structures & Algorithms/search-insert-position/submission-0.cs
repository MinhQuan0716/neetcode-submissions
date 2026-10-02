public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low = 0, res = nums.Length, high = nums.Length - 1;
        while(low <= high){
             int mid = (low + high) /2;
            if(nums[mid] == target){
              return mid;
            } else if(nums[mid] > target){
                res = mid;
                high = mid - 1;
            } else{
                low = mid + 1;
            }
        }
        return res;
    }
}