public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> res = new HashSet<int>();

        for(int i = 0; i < nums1.Length; i++){
            for(int j = 0; j < nums2.Length; j++){
                if(nums1[i] == nums2[j]){
                    res.Add(nums1[i]);
                    break;
                }
            }
        }

        return res.ToArray();
        

    }
}