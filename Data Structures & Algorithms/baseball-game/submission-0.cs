public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i<operations.Length;i++){
            if(operations[i] == "+"){
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            } else if(operations[i] == "D"){
                stack.Push(2 * stack.Peek());
            } else if(operations[i] == "C"){
                stack.Pop();
            } else{
                stack.Push(int.Parse(operations[i]));
            }
        }
        int total = 0;
        foreach(var val in stack){
            total+= val;
        }
        return total;
    }
}