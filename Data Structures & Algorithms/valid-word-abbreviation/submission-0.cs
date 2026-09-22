public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int left = 0, right = 0;
        while(left< word.Length && right< abbr.Length){
            if (char.IsLetter(abbr[right])){
               if(word[left]==abbr[right]){
                left++;
                right++;
            } else{
                return false;
            }
             
            } else{
                 if(abbr[right] == '0'){
                return false;
              }
                  int steps = 0;
            while(right < abbr.Length && char.IsDigit(abbr[right])){
                steps = steps * 10 + (abbr[right] - '0');
                right++;
            }
            left += steps;
            }
           
        }
       return left == word.Length && right == abbr.Length;
    }
}