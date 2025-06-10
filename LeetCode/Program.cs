// See https://aka.ms/new-console-template for more information
using LeetCode.Solutions;

Console.WriteLine("LeetCode 解題測試程式");

try
{
    var solution = new TwoSum();
    var result = solution.Solve(new[] { 2, 7, 11, 15 }, 9);
    
    Console.WriteLine("測試 Two Sum:");
    Console.WriteLine($"輸入: nums = [2,7,11,15], target = 9");
    Console.WriteLine($"輸出: [{string.Join(",", result)}]");
}
catch (Exception ex)
{
    Console.WriteLine($"執行錯誤: {ex.Message}");
}

Console.WriteLine("\n按任意鍵結束...");
Console.ReadKey();

