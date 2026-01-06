public class Solution {
    public bool CloseStrings(string word1, string word2) {
        Dictionary<char,int> word1chars = new Dictionary<char,int>();
        Dictionary<char,int> word2chars = new Dictionary<char,int>();

        for(int i = 0; i < word1.Length; i++){
            if(word1chars.ContainsKey(word1[i])){
                word1chars[word1[i]]++;
            }else{
                word1chars[word1[i]] = 1;
            }
        }

        for(int i = 0; i < word2.Length; i++){
            if(word2chars.ContainsKey(word2[i])){
                word2chars[word2[i]]++;
            }else{
                word2chars[word2[i]] = 1;
            }
        }

        var keys1 = new HashSet<char>(word1chars.Keys);
        var keys2 = new HashSet<char>(word2chars.Keys);
        if (!keys1.SetEquals(keys2)) return false;

        var values1 = word1chars.Values.ToList();
        var values2 = word2chars.Values.ToList();
        values1.Sort();
        values2.Sort();

        return values1.SequenceEqual(values2);
    }
}