public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freqCount = new Dictionary<int,int>();
        List<int>[] buckets = new List<int>[nums.Length + 1];
        int[] results = new int[k];
        for(int i = 0;i<nums.Length; i++){
            if(freqCount.ContainsKey(nums[i])){
                freqCount[nums[i]]++;
            } else{
                freqCount[nums[i]] = 1;
            }
        }
        foreach(var kvp in freqCount){
            if(buckets[kvp.Value] == null){
                buckets[kvp.Value] = new List<int>();
                buckets[kvp.Value].Add(kvp.Key);
            } else{
                buckets[kvp.Value].Add(kvp.Key);
            }
        }
        int index = 0;
        for(int j = buckets.Length - 1; j>0; j--){
            if (buckets[j] != null){
             foreach(var value in buckets[j]){
               results[index] = value;
               index++;
               if(index==k){
                return results;
               }
           }
         }
        }
        return results;
    }
}
