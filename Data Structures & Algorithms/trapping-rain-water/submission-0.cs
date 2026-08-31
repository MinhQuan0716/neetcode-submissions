public class Solution {
   public int Trap(int[] heights) {
    if (heights == null || heights.Length == 0) return 0;
    
    int n = heights.Length;
    int[] leftMax = new int[n];
    int[] rightMax = new int[n];
    int totalWater = 0;

    // Step 1: Fill the leftMax array
    leftMax[0] = heights[0];
    for (int i = 1; i < n; i++) {
        if(heights[i]<=leftMax[i-1]){
           leftMax[i] = leftMax[i-1];
        } else{
            leftMax[i] = heights[i];
        }
        
    }

    // Step 2: Fill the rightMax array
    rightMax[n - 1] = heights[n - 1];
    for (int i = n - 2; i >= 0; i--) {
         if(heights[i]<=rightMax[i+1]){
            rightMax[i] = rightMax[i+1];
         } else{
            rightMax[i] = heights[i];
         }
       
    }

    // Step 3: Calculate the total water
    for (int i = 0; i < n; i++) {       
        int waterAtCurrentBlock = Math.Min(leftMax[i],rightMax[i]) - heights[i] ;
        // Add the current to the result running total
        totalWater += waterAtCurrentBlock;
    }

    return totalWater;
}
}
