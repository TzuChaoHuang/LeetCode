using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace LeetCode.Solutions;

public class SpiralMatrix
{
    /// <summary>
    /// Given an m x n matrix, return all elements of the matrix in spiral order.
    /// https://leetcode.com/problems/spiral-matrix/description/
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public IList<int> Solve(int[][] matrix)
    {
        // moving right -> down -> left -> Up
        var ans = new List<int>();
        int top = 0, right = matrix[0].Length - 1, bottom = matrix.Length - 1, left = 0;
        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                ans.Add(matrix[top][i]);
            }
            top++;
            for (int i = top; i <= bottom; i++)
            {
                ans.Add(matrix[i][right]);
            }
            right--;
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    ans.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            if (right >= left)
            {
                for (int i = bottom; i >= top; i--)
                {
                    ans.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return ans;
    }
}