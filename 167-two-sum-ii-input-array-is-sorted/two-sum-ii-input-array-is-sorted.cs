public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int n = numbers.Length;
        int right = n - 1;
        while(left < right){
            if(numbers[right] + numbers[left] > target){
                right--;
            }else if(numbers[right] + numbers[left] < target){
                left++;
            }else{
                break;
            }
        }
        return new int[] { left + 1, right + 1 };
    }
}