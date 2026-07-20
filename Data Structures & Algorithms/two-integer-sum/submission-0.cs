public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     Dictionary<int,int> check = new Dictionary<int,int>();
     for(int i = 0; i < nums.Length; i++){
        int difference = target - nums[i];
        if(check.ContainsKey(difference)){
            return new int[]{check[difference],i};
        } else{
            check[nums[i]] = i;
        }
     }
     return null;
    }
}
