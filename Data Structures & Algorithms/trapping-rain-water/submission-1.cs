public class Solution {
   public int Trap(int[] heights) {
    int left = 0, right = heights.Length - 1;
    int leftMax = 0, rightMax = 0;
    int totalWater = 0;
    while(left<right){
      if(heights[left]<heights[right]){
        leftMax = Math.Max(leftMax,heights[left]);
        int curr = leftMax - heights[left];
        totalWater += curr;
        left++;
      } else{
        rightMax = Math.Max(rightMax,heights[right]);
        int curr = rightMax - heights[right];
        totalWater += curr;
        right--;
      }
    }
    return totalWater;
 }
}
