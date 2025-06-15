namespace LeetCode.Solutions;

/// <summary>
/// Write an algorithm to determine if a number n is happy.
/// https://leetcode.com/problems/happy-number/description/
/// </summary>
public class HappyNumber
{
    public bool Solve(int n)
    {
        // Use a HashSet to keep track of numbers that have already been seen.
        HashSet<int> numbers = new HashSet<int>() { n };
        while (n != 0)
        {
            int newSum = 0;
            while (n> 0)
            {
                var val = n % 10;
                n /= 10;
                newSum += val * val;
            }
            if (newSum == 1)
            {
                return true;
            }

            if (numbers.Contains(newSum))
            {
                return false;
            }
            else
            {
                numbers.Add(newSum);
                n = newSum;
            }
        }
        return false;
    }
}