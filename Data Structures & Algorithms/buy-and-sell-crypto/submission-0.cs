public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int maxProfit = 0;
        while(r<prices.Length){
            if(prices[r]>prices[l]){
                int profit = prices[r]-prices[l];
                maxProfit = Math.Max(maxProfit,profit);
            } else{
                l = r;
            }
            r++;
        }
        return maxProfit;
    }
}
