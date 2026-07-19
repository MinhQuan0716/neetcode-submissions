public class Solution {
    public bool IsAnagram(string s, string t) {
       Dictionary<char,int> check = new Dictionary<char,int>();
       bool isCorrect = false;
       if(s.Length != t.Length){
        return isCorrect;
       }
       for(int i = 0; i<s.Length;i++){
          if(check.ContainsKey(s[i])){
            check[s[i]]++;
          } else{
            check[s[i]] = 1;
          }
       }
      for(int j = 0; j<t.Length;j++){
         if(check.ContainsKey(t[j])){
            check[t[j]]--;
         } else{
            return false;
         }
      }
      foreach(var count in check.Values) {
          if(count != 0) return false;
      }
      return true;
    }
}