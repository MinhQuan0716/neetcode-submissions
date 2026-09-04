public class Solution {
    public string MinWindow(string s, string t) {
        int left = 0, matched = 0, minLength = int.MaxValue, startIndex = 0;
        Dictionary<char,int> track1 = new Dictionary<char,int>();
        Dictionary<char,int> track2 = new Dictionary<char,int>();
        for(int j = 0;j<t.Length;j++){
            if(!track1.ContainsKey(t[j])){
                track1[t[j]] = 1;
            } else{
                track1[t[j]]++;
            }
        }
      for(int i = 0;i<s.Length;i++){
          if(track1.ContainsKey(s[i])){
            if(!track2.ContainsKey(s[i])){
                track2[s[i]] = 1;
            } else{
                track2[s[i]]++;
            }
             if(track1[s[i]]==track2[s[i]]){
            matched ++;
          }
        }
          while(matched == track1.Count){
             if (i - left + 1 < minLength) {
               minLength = i - left + 1;
               startIndex = left;
         }
            if(track1.ContainsKey(s[left])){
                 if(track2.ContainsKey(s[left])){
                track2[s[left]]--;
            }
                 if(track2[s[left]]<track1[s[left]]){
                matched--;
            }
        }   
          left++;
        }
      }
       if(minLength == int.MaxValue){
            return "";
        }
      return s.Substring(startIndex,minLength);
    }
}
