public class Solution {
    public bool ValidPalindrome(string s) {
        if (IsPalindrome(s)) return true;

        for (int i = 0; i < s.Length; i++) {
            string newS = s.Substring(0, i) + s.Substring(i + 1);
            if (IsPalindrome(newS)) return true;
        }

        return false;
    }

    private bool IsPalindrome(string str) {
        int left = 0, right = str.Length - 1;
        while (left < right) {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}