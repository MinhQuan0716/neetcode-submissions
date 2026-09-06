public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
     int m = matrix.Length, n = matrix[0].Length;
     int left = 0, right = m* n- 1;
     while(left<=right){
        int mid = (left+right)/2;
        int val = matrix[mid/n][mid%n];
        if(val == target){
            return true;
        }
        if(val<target){
            left = mid + 1;
        }
        if(val>target){
            right = mid - 1;
        }
     }
     return false;   
    }
}
