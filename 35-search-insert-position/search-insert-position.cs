public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int hight = nums.Length - 1;
        int low = 0;
        while(low <= hight){
            int mid = low + (hight - low)/2;
            
            if(nums[mid] == target){
                return mid;
            }

            if(nums[mid] > target){
                hight = mid - 1;
            }else{
                low = mid + 1;
            }
        }
        return low;
    }
}