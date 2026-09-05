public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> deque = new LinkedList<int>();
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        int resultIndex = 0;
        for(int i = 0; i<n;i++){
            if (deque.Count > 0 && deque.First.Value <= i - k) {
                 deque.RemoveFirst();
            }
            while (deque.Count > 0 && nums[i] >= nums[deque.Last.Value]) {
                deque.RemoveLast();
             }
            deque.AddLast(i);
            if(i>= k - 1){
                result[resultIndex++] = nums[deque.First.Value];
            }
        }
        return result;
    }
}
