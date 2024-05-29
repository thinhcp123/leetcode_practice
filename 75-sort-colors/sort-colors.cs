public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        while(mid <= right){
            int arr = nums[mid];
            if(arr == 2){
                swap(nums,mid,right);
                right--;
            }else if(arr == 0){
                swap(nums,mid,left);
                left++;
                mid++;
            }else{
                mid++;
            }
        }
    }
    private void swap(int[] arr,int a,int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}