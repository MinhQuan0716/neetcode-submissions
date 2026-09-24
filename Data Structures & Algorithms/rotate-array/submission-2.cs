public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;   
        k %= n;
          ReverseArray(nums,0,n - 1);
          ReverseArray(nums,0,k - 1);
          ReverseArray(nums,k, n - 1);
        }
    }
    public static void ReverseArray(int[]nums, int left, int right){
        while(left<right){
            (nums[left],nums[right]) = (nums[right],nums[left]);
            left++;
            right--;
        }
    }
