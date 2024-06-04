public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if(n < 2) return n;
        int l = 0;
        int r = 1;
        while(r < n){
            if(nums[l] != nums[r]){
                l++;
                nums[l] = nums[r];
            }
            r++;
        }
        return l+1;
    }


}