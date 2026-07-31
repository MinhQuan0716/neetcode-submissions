public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> checkSet = new HashSet<int>();
        int streak = 1;
        int longestStreak = 0;
        for(int j = 0; j<nums.Length;j++){
             checkSet.Add(nums[j]);
        }
        for(int i = 0; i<nums.Length; i++){
            if(!checkSet.Contains(nums[i] - 1)){
                streak = 1;
            while(checkSet.Contains(nums[i]+streak)){  
                streak++;
            } 
            longestStreak = Math.Max(longestStreak, streak);
        } 
    }
    return longestStreak;
 }
}
