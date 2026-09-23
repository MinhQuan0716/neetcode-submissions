public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1, j = n - 1, k = nums1.Length - 1;
        while(k>=0){
           if(i<0){
            nums1[k] = nums2[j];
            j--;
           } else if(j<0){
            nums1[k] = nums1[i];
            i--;
           } else if(nums2[j]<nums1[i]){
            nums1[k] = nums1[i];
            i--;
           } else{
            nums1[k] = nums2[j];
            j--;
           }
           k--;
        }
    }
}