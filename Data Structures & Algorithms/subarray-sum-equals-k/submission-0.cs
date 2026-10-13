public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> seen = new Dictionary<int,int>();
        int prefix = 0, count = 0;
         seen[0] = 1;
        for(int i = 0;i<nums.Length;i++){
          prefix+=nums[i];
          int remove = prefix - k;
          if(seen.ContainsKey(remove)){
            count+=seen[remove];
          } if(!seen.ContainsKey(prefix)){
            seen[prefix] = 0;
          }
          seen[prefix]++;
        }
        return count;
    }
}