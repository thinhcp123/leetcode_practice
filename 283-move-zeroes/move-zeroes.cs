public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        int n = nums.Length;
        if(n < 2) return;
        int right = 1;
        while(right < n){
            if(nums[left] != 0){
                left++;
                right++;
            }else if(nums[right] == 0){
                right++;
            }else{
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
            }
        }
    }
}