namespace LeetCode.Solutions;

/// <summary>
/// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
/// https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
/// </summary>
public class LetterCombinationsOfAPhoneNumber
{
    private Dictionary<char, List<string>> map = new Dictionary<char, List<string>>();

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>();
        }

        map['2'] = new List<string>() { "a", "b", "c" };
        map['3'] = new List<string>() { "d", "e", "f" };
        map['4'] = new List<string>() { "g", "h", "i" };
        map['5'] = new List<string>() { "j", "k", "l" };
        map['6'] = new List<string>() { "m", "n", "o" };
        map['7'] = new List<string>() { "p", "q", "r", "s" };
        map['8'] = new List<string>() { "t", "u", "v" };
        map['9'] = new List<string>() { "w", "x", "y", "z" };

        IList<string> result = new List<string>();

        this.Generate(digits, 0, string.Empty, result);

        return result;
    }
    private void Generate(string input, int index, string word, IList<string> result)
    {
        if (index == input.Length)
        {
            result.Add(word);
            return;
        }

        for (int i = 0; i < map[input[index]].Count; i++)
        {
            this.Generate(input, index + 1, word + map[input[index]][i], result);
        }
    }
}