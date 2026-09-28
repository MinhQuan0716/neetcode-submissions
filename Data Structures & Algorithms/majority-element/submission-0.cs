public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> check = new Dictionary<int,int>();
        int result = 0;
        for(int i = 0;i<nums.Length;i++){
            if(check.ContainsKey(nums[i])){
                check[nums[i]]++;
            } else{
                check[nums[i]] = 1;
            }
        }
        int threshold = nums.Length / 2;
        foreach(var key in check.Keys){
           if (check[key] > threshold)
            {
              result = key;
            }
        }
        return result;
    }
}