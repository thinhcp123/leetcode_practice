public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var res = new List<int>();
        var l = 0;
        var r = 0;
        Array.Sort(nums1);
        Array.Sort(nums2);

        while(l < nums1.Length && r < nums2.Length){
            if(nums1[l] == nums2[r]){
                res.Add(nums1[l]);
                l++;
                r++;
            }else if(nums1[l] < nums2[r]){
                l++;
            }else{
                r++;
            }
        }
        return res.ToArray();
    }
}