public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int left = 0, currSum = 0,maxBonus = 0, baseCustomer = 0;
        for(int i = 0; i<customers.Length; i++){
            if(grumpy[i] == 0){
                baseCustomer+=customers[i];
            }
        }
        for(int right = 0; right<customers.Length;right++){
            if(grumpy[right] == 1){
                currSum+=customers[right];
            }
            if(right - left + 1 >=minutes){
                maxBonus = Math.Max(maxBonus,currSum);
                if(grumpy[left] == 1){
                    currSum -= customers[left];
                }
                left++;
            }
        }
        return maxBonus+baseCustomer;
    }
}