public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == "") return 0;
        int result = 0;

        HashSet<char> hs = new HashSet<char>();
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s.ElementAt(i);
            if (!hs.Add(c))
            {
                if (hs.Count > result)
                    result = hs.Count;

                hs.Clear();
                index = s.IndexOf(c, index) + 1;                    
                int len = s.IndexOf(c, index) - index + 1;
                hs = new HashSet<char>(s.Substring(index, len));
            }
        }
        if (hs.Count > result)
            result = hs.Count;
        return result;
    }
}
