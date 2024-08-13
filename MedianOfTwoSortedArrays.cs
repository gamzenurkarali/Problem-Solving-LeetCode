public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m = nums2.Length;
        int[] result = new int[n + m];
         
        for (int i = 0; i < n; i++) {
            result[i] = nums1[i];
        }
        for (int i = 0; i < m; i++) {
            result[n + i] = nums2[i];
        }
         
        Array.Sort(result);
         
        if (result.Length % 2 == 1) {
            return result[result.Length / 2];
        } else {
            return (result[result.Length / 2 - 1] + result[result.Length / 2]) / 2.0;
        }
    }
}
