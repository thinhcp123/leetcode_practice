public class Solution {
    public bool IsPalindrome(string s) {
        if(s == " ") return true;
        int left = 0;
        int right = s.Length - 1;
        while(left < right){
            char currFirst = s[left];
            char currLast = s[right];
            if(!Char.IsLetterOrDigit(currFirst)){
                left++;
            }else if(!Char.IsLetterOrDigit(currLast)){
                right--;
            }else{
                if (Char.ToLower(currFirst) != Char.ToLower(currLast)){ 
                    return false;
                }
                left++;
                right--;
            }
        }
    return true;

    }
}