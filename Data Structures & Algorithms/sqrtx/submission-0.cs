public class Solution {
    public int MySqrt(int x) {
        if(x < 2 ) return x;
        int left = 1, right = x;
        while(left < right){
           int mid = left + (right - left + 1)/2;
            if((long)mid*mid <= x){
                left = mid;
            }else{
                right = mid - 1;
            }
        }
        return left;
    }
}