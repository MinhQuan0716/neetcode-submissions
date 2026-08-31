public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
    var cars = new (int pos, int speed)[n];
    for (int i = 0; i < n; i++) {
        cars[i] = (position[i], speed[i]);
    }
    Array.Sort(cars);
    var stack = new Stack<double>();
    for(int i = n-1; i>=0; i--){
       double time = (double)(target - cars[i].pos) / cars[i].speed;
       if(stack.Count == 0 ||time>stack.Peek()){
          stack.Push(time);
       }
    }
    return stack.Count;
  }
}
