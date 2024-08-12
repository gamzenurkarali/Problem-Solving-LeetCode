public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> resultArray = new List<char>();  
        int maxLength = 0;  

        for (int i = 0; i < s.Length; i++) {
            if (resultArray.Contains(s[i])) {  
                resultArray.RemoveRange(0, resultArray.IndexOf(s[i]) + 1);  
            }
            resultArray.Add(s[i]);  
            maxLength = Math.Max(maxLength, resultArray.Count);  
        }

        return maxLength;  
    }
}
