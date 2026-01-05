public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0, j = 0;

        while(j < t.Length && i < s.Length)
        {
            if (t[j] == s[i])
            {
                i++;
                j++;
            }
            else
            {
                j++;
            }

        }

        if(i != s.Length)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}