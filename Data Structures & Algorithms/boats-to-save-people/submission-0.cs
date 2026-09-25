public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int left = 0, count = 0, right = people.Length - 1;
      while(left<=right){
        if(people[left]+people[right]>limit){
            right--;
        } else{
            left++;
            right--;
          
        }
          count++;
      }
      return count;
    }
}