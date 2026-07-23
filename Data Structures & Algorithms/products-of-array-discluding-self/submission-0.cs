public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] leftProducts = new int[nums.Length];
        int[] rightProducts = new int[nums.Length];
        int[] result = new int[nums.Length];
        for(int i = 0; i<nums.Length;i++){
            if(i == 0){
                leftProducts[i] = 1;
            } else{
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }
        }
         rightProducts[nums.Length - 1] = 1;
            for(int i = nums.Length - 2; i>=0;i--){
                rightProducts[i] = rightProducts[i+1] * nums[i+1];
               }
        for(int k = 0; k<nums.Length;k++){
            result[k] = leftProducts[k]*rightProducts[k];
        }
        return result;
    }
}
