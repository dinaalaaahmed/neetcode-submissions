public class Solution {  
    public List<string> sol = new List<string>();
    public string parentheses = "()";
    public List<string> GenerateParenthesis(int n) {
        GenerateParenthesisBackTrack(n, "", 0);
        return sol;
    }

    public void GenerateParenthesisBackTrack(int n, string curr, int index) {
        if(curr.Length == n*2){
            if(!IsValidParentheses(curr)) return;
            sol.Add(curr);
            return;
        }
        for(int i = 0; i<parentheses.Length; i++){
            curr+=parentheses[i];
            GenerateParenthesisBackTrack(n, curr, index+1);
            curr = curr.Remove(curr.Length-1);
        }
    }

    public bool IsValidParentheses(string s){
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(') {
                stack.Push(c);
            }
            else {
                if (stack.Count == 0) return false;

                char open = stack.Pop();
                
                if (c == ')' && open != '(') return false;
            }
        }

        return stack.Count == 0;
    }

}
