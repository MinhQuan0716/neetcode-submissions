public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < n - 2; i++)
{
    if (i > 0 && nums[i] == nums[i - 1]) continue;
    int left = i + 1, right = n - 1;
    while (left < right)
    {
        int sum = nums[i] + nums[left] + nums[right];
       if(sum == 0){
        result.Add(new List<int> { nums[i], nums[left], nums[right] });
        left++;
        right--;
         while (left < right && nums[left] == nums[left - 1]) left++;
         while (left < right && nums[right] == nums[right + 1]) right--;
       } else if(sum <0){
         left++;
       } else{
        right--;
       }
    }
}
    return result;
    }
}
