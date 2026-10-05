public class Solution {
    public int MaxProfit(int[] prices) {
    int totalProfit = 0;
        for(int i = 0; i<prices.Length - 1; i++){
          int dailyProfit = prices[i+1] - prices[i];
          if(dailyProfit > 0){
            totalProfit += dailyProfit;
          }
        }
        return totalProfit;
    }
}