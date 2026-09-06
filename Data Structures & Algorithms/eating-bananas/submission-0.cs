public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max(), minSpeed = 0;
         while(left<=right){
            int totalHour = 0;
            int mid = left + (right-left + 1) /2;
            for(int i = 0; i<piles.Length;i++){
                totalHour += (int) Math.Ceiling((double)piles[i]/mid);
            }
            if(totalHour<=h){
                right = mid - 1;
                minSpeed = mid;
                }
               if(totalHour>h){
               left = mid + 1;
              }
         }
     return minSpeed;
    }
}
