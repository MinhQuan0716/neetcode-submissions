public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0, maxLength = 0, maxFreq = 0;
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i = 0; i<s.Length;i++){
             if(!dict.ContainsKey(s[i])){
             dict[s[i]] = 0;
            }
            dict[s[i]]++;
            maxFreq = Math.Max(maxFreq, dict[s[i]]);
            if ((i - left + 1) - maxFreq > k){
               dict[s[left]]--;
               left++;
            }
            maxLength = Math.Max(maxLength, i - left + 1);
        }
         return maxLength;
    }
   
}
