public class Solution {
    public int[] SortArray(int[] nums) {
      int[] temp = new int[nums.Length];
      MergeSort(nums,temp,0,nums.Length - 1);
      return nums;
    }
    public static void MergeSort(int[] nums, int[] temp, int left, int right){
        if(left<right){
            int mid =  left + (right - left) / 2;
            MergeSort(nums,temp,left,mid);
            MergeSort(nums,temp,mid + 1, right);
            Merge(nums,temp,left,mid,right);
        }
    }
    public static void Merge(int[] nums, int[] temp, int left, int mid, int right){
         int i = left, k = left ,j = mid + 1;
         for(int x = left; x <= right; x++){
            temp[x] = nums[x];
         }
         while(i <= mid && j <= right){
            if(temp[i]<temp[j]){
              nums[k] = temp[i];
              i++;
            } else{
                nums[k] = temp[j];
                j++;
            }
            k++;
         }
         while(i<=mid){
            nums[k] = temp[i];
            i++;
            k++;
         }
    }
}