public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0){
            return "";
        }
        string prefix = strs[0];
       for(int i = 1; i<strs.Length;i++){
        while(!strs[i].StartsWith(prefix)){
            if(prefix == ""){
                return "";
            }
           prefix = prefix.Substring(0, prefix.Length - 1);
        }
       }
       return prefix;
    }
}