public class Solution {
    public int[] SortedSquares(int[] nums) {
        int l = 0;
        int n = nums.Length;
        int r = n - 1;
        int[] res = new int [n];
        int index = n - 1;
        while(0 <= index){
            int leftNums = nums[l] * nums[l];
            int rightNums = nums[r] * nums[r];
            if(rightNums > leftNums){
                res[index--] =rightNums; 
                r--;
            }else{
                l++;
                res[index--] = leftNums;
            }
        }
        return res;
    }

}