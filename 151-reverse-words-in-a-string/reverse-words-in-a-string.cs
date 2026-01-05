public class Solution {
    public string ReverseWords(string s) {
        s.Trim();
        string[] word = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var result = new System.Text.StringBuilder();

        for(int i = word.Length-1; i >= 0; i--){
            
            result.Append(word[i]);

            if(i != 0){
                result.Append(" ");
            }
        }

        return result.ToString();
    }
}