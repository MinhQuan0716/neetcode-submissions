public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int left = 0;
        int currSum = 0, result = 0;
        for(int right = 0; right<arr.Length;right++){
            currSum+=arr[right];
           if(right-left+1>=k){
            if(currSum>=threshold*k){
                result++;
             }
             currSum-=arr[left];
             left++;
           }
        }
        return result;
    }
}