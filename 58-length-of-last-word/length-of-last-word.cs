public class Solution {
    public int LengthOfLastWord(string s) {
        int lengthStr = 0;
        int n = s.Length;
        for(int i = n - 1; i >= 0; i--){
            if(s[i] != ' '){
                lengthStr++;
            }else{
                if(lengthStr > 0) return lengthStr;
            }
        }
        return lengthStr;
    }
}