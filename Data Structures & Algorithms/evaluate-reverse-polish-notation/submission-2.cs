public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i<tokens.Length;i++){
            if (int.TryParse(tokens[i], out int number)) {
            stack.Push(number);
        }
        else {
            int right = stack.Pop();
            int left = stack.Pop();
            int result = tokens[i] switch {
                "+" => left + right,
                "-" => left - right,
                "*" => left * right,
                "/" => left / right,
            };
            
            stack.Push(result);
        }
     }
     return stack.Pop();
    }
}
