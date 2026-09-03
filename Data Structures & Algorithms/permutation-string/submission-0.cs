public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int left = 0, n = s1.Length;
        Dictionary<char,int> dict1 = new Dictionary<char,int>();
        Dictionary<char,int> dict2 = new Dictionary<char,int>();
        for(int j = 0;j<s1.Length;j++){
             if(!dict1.ContainsKey(s1[j])){
               dict1[s1[j]] = 0;
            }
            dict1[s1[j]]++;
        }
        for(int i = 0;i<s2.Length;i++){
            if(!dict2.ContainsKey(s2[i])){
               dict2[s2[i]] = 0;
            }
             dict2[s2[i]]++;
            while(i-left + 1>n){
              if(dict2.ContainsKey(s2[left])){
                  dict2[s2[left]] --;
                  if (dict2[s2[left]] == 0) {
                   dict2.Remove(s2[left]);
                 }
                  left++;
              }
            }
            if(i-left+1 == n){
                if(DictionariesAreEqual(dict1,dict2)){
                    return true;
                }
            }
        }
        return false;
    }

private bool DictionariesAreEqual(Dictionary<char, int> d1, Dictionary<char, int> d2) {
    if (d1.Count != d2.Count) return false;
    foreach (var kvp in d1) {
        if (!d2.ContainsKey(kvp.Key) || d2[kvp.Key] != kvp.Value) {
            return false;
        }
    }
    return true;
 }
}
