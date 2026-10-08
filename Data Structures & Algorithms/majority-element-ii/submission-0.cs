public class Solution {
    public List<int> MajorityElement(int[] nums) {
         int n = nums.Length;
        int num1 = -1, num2 = -1;
        int cnt1 = 0, cnt2 = 0;

        foreach (int num in nums) {
            if (num == num1) {
                cnt1++;
            } else if (num == num2) {
                cnt2++;
            } else if (cnt1 == 0) {
                num1 = num;
                cnt1 = 1;
            } else if (cnt2 == 0) {
                num2 = num;
                cnt2 = 1;
            } else {
                cnt1--;
                cnt2--;
            }
        }

        cnt1 = cnt2 = 0;
        foreach (int num in nums) {
            if (num == num1) cnt1++;
            else if (num == num2) cnt2++;
        }

        List<int> res = new List<int>();
        if (cnt1 > n / 3) res.Add(num1);
        if (cnt2 > n / 3) res.Add(num2);

        return res;
    }
}