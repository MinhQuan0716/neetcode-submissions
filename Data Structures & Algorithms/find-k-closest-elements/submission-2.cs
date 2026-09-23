public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0, right = arr.Length - 1;
        List<int> result = new List<int>();
        while(right - left + 1>k){
            if(Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x)){
                left++;
            } else{
                right--;
            }
        }
        for(int i = left; i<=right;i++){
            result.Add(arr[i]);
        }
        return result;
    }
}