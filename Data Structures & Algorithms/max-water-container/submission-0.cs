public class Solution {
    public int MaxArea(int[] heights) {
      int left = 0;
      int right = heights.Length - 1;
      int result = 0;
      while(left<=right){
        int biggest = (right-left)*Math.Min(heights[right],heights[left]);
        if(result<biggest){
            result = biggest;
        }
        if(heights[left]<heights[right]){
            left++;
        }else{
            right--;
        }
      }
      return result;
    }
}
