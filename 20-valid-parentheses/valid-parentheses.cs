public class Solution {
    public bool IsValid(string s) {
        var stackValid = new Stack<char>();

        foreach(char c in s){
            if(c == '('){
                stackValid.Push(')');
            }else if(c == '{'){
                stackValid.Push('}');
            }else if(c == '['){
                stackValid.Push(']');
            }else if(stackValid.Count == 0 || c != stackValid.Pop()){
                return false;
            }
        }
        return stackValid.Count == 0;
    }
}