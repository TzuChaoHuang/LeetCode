using System.Diagnostics;
using System.Globalization;

namespace LeetCode.Solutions;

public class SpiralMatrix2
{
    /// <summary>
    /// Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.
    /// https://leetcode.com/problems/spiral-matrix-ii/description/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[][] Solve(int n)
    {
        // Move in the order: right → down → left → up
        // If the current number is smaller than n multiplied by n, keep looping
        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ans[i] = new int[n];
        }
        int current = 1;
        int top = 0, left = 0, right = n - 1, bottom = n - 1;
        while (current <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                ans[top][i] = current++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                ans[i][right] = current++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                ans[bottom][i] = current++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                ans[i][left] = current++;
            }
            left++;
        }
        return ans;
    }
}