public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // string[] init = new string[26]{"a","b","c","d","e","f","g","h","i","j","k","l"
        // ,"m","n","o","p","q","r","s","t","u","v","w","x","y","z"}
        // Dictionary<string,int> check = new Dictionary<string,int>();
        List<List<string>> results = new List<List<string>>();
        Dictionary<string,List<string>> checkList = new Dictionary<string,List<string>>();
        for(int i = 0; i< strs.Length;i++){
            char[] charArr = strs[i].ToCharArray();
            Array.Sort(charArr);
            string sorted = new string(charArr);
            if(checkList.ContainsKey(sorted)){
                checkList[sorted].Add(strs[i]);
            } else{
                checkList[sorted] = new List<string>();
                checkList[sorted].Add(strs[i]);
            }
        }
        foreach(var values in checkList.Values){
            results.Add(values);
        }
        return results;
    }
}
