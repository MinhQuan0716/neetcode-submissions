public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new StringBuilder();
        for(int i = 0; i<strs.Count(); i++){
            int strLength = strs[i].Length;
            encoded.Append(strLength.ToString()).Append("#").Append(strs[i]);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
     List<string> results = new List<string>();
     int i = 0;
     while(i<s.Length){
        int j = s.IndexOf("#",i);
        int length = 0;
        if(j>i){
          length = int.Parse(s.Substring(i, j-i));
        }
        results.Add(s.Substring(j+1,length));
        i = j + 1 + length;
     }
     return results;
   }
}
