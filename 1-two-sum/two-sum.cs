public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     var pairs = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
            if(pairs.ContainsKey(target - nums[i]))
                return new int[] { pairs[target - nums[i]], i };
            else
                pairs.TryAdd(nums[i], i);
        
        return default;
        }
}