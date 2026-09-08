public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double result = 0.0;
        if(nums2.Length<nums1.Length){
            return FindMedianSortedArrays(nums2, nums1);
        }
        int halfLength = (nums1.Length + nums2.Length + 1)/2;
        int left = 0, right = nums1.Length;
        while(left<=right){
            int partitionA = left + (right - left)/2;
            int partitionB = halfLength - partitionA;
            int aLeft = (partitionA > 0) ? nums1[partitionA - 1] : int.MinValue;
            int aRight = (partitionA < nums1.Length) ? nums1[partitionA] : int.MaxValue;
            int bLeft = (partitionB > 0) ? nums2[partitionB - 1] : int.MinValue;
            int bRight = (partitionB < nums2.Length) ? nums2[partitionB] : int.MaxValue;
            if(aLeft<=bRight && bLeft<=aRight){
                 int lengthSum = nums1.Length + nums2.Length;
                 if(lengthSum % 2 !=0){
                    result = (double) Math.Max(aLeft,bLeft);
                    return result;
                 } else{
                    result = (double)(Math.Max(aLeft,bLeft)+Math.Min(aRight,bRight)) /2;
                    return result;
                 }
            } else if(aLeft > bRight){
                right = partitionA - 1;
            } else{
               left = partitionA + 1;
            }
        }
        return result;
    }
}
