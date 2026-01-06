public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> nums1dif = new HashSet<int>();
        HashSet<int> nums2dif = new HashSet<int>();
        List<List<int>> ans = new List<List<int>>();
        for(int i = 0; i < nums1.Length; i++){
            if(!nums2.Contains(nums1[i])){
                nums1dif.Add(nums1[i]);
            }
        }

        for(int i = 0; i < nums2.Length; i++){
            if(!nums1.Contains(nums2[i])){
                nums2dif.Add(nums2[i]);
            }
        }

        ans.Add(nums1dif.ToList());
        ans.Add(nums2dif.ToList());

        return ans.Cast<IList<int>>().ToList();;

    }
}