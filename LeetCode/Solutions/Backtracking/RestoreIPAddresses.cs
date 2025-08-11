namespace LeetCode.Solutions;

public class RestoreIPAddresses
{
     public IList<string> res = new List<string>();
    public IList<string> RestoreIpAddresses(string s)
    {
        if (s.Length < 4 || s.Length > 12) return res;
        BackTracking(s, 0, 0);
        return res;
    }
    public void BackTracking(string s, int start, int pointSum)
    {
        if (pointSum == 3)
        {
            if (IsValid(s, start, s.Length - 1))
            {
                res.Add(s);
            }
            return;
        }
        for (int i = start; i < s.Length; i++)
        {
            if (IsValid(s, start, i))
            {
                s = s.Insert(i + 1, ".");
                BackTracking(s, i + 2, pointSum + 1);
                s = s.Remove(i + 1, 1);
            }
            else break;
        }
    }
    public bool IsValid(string s, int start, int end)
    {
        if (start > end) return false;
        if (s[start] == '0' && start != end) return false;
        int num = 0;
        for (int i = start; i <= end; i++)
        {
            if (s[i] > '9' || s[i] < '0') return false;
            num = num * 10 + s[i] - '0';
            if (num > 255) return false;
        }
        return true;
    }
}