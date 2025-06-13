namespace LeetCode.Solutions;

/// <summary>
/// Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.
/// https://leetcode.com/problems/find-common-characters/description/
/// </summary>
public class FindCommonCharacters
{
    public IList<string> Solve(string[] words)
    {
        // If the length of words equal one, return each letter of words[0].
        // Count each letter of each word, then find the minimun of counts to print letter
        List<string> ans = new();
        if (words.Length == 1)
        {
            foreach (char c in words[0])
            {
                ans.Add(c.ToString());
            }
            return ans;
        }

        int[][] counts = new int[words.Length][];
        for (int i = 0; i < words.Length; i++)
        {
            int[] letters = new int[26];
            foreach (char word in words[i])
            {
                letters[word - 'a']++;
            }
            counts[i] = letters;
        }

        for (int i = 0; i < 26; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < counts.Length; j++)
            {
                min = Math.Min(min, counts[j][i]);
            }
            for (int k = 1; k <= min; k++)
            {
                ans.Add(((char)('a' + i)).ToString());
            }
        }
        return ans;
    }
}