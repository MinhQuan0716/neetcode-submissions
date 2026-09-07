public class TimeMap {
     Dictionary<string,List<Tuple<string,int>>> storage = null;
    public TimeMap() {
        storage = new Dictionary<string,List<Tuple<string,int>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!storage.ContainsKey(key)){
           storage[key] = new List<Tuple<string,int>>();
        }
        storage[key].Add(Tuple.Create(value,timestamp));
    }
    
    public string Get(string key, int timestamp) {
       string res = "";
       if(storage.TryGetValue(key,out List<Tuple<string,int>> values)){        
       int low = 0, high = values.Count - 1;
       while(low<=high){
         int mid = low + (high - low) / 2;
         if(values[mid].Item2<=timestamp){
            res = values[mid].Item1;
            low = mid + 1;
         } else{
            high = mid - 1;
         }
       }
       } else{
        return res;
       }
       return res;
    }
}
