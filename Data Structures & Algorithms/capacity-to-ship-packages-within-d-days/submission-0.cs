public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int left = weights.Max();
        int right = weights.Sum();
        int res = right;
          bool CanShip(int cap) {
            int ships = 1;
            int currCap = cap;

            foreach (int w in weights) {
                if (currCap - w < 0) {
                    ships++;
                    if (ships > days) return false;
                    currCap = cap;
                }
                currCap -= w;
            }

            return true;
        }
        while(left<=right){
             int cap = (left + right) / 2;
            if (CanShip(cap)) {
                res = Math.Min(res, cap);
                right = cap - 1;
            } else {
                left = cap + 1;
            }
        }
     return res;
    }
}