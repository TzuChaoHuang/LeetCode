// See https://aka.ms/new-console-template for more information
using LeetCode.Solutions;

Console.WriteLine("LeetCode 解題測試程式");

try
{
    var solution = new SwapNodesInPairs();
    solution.Solve(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4,new ListNode(5))))));
}
catch (Exception ex)
{
    Console.WriteLine($"執行錯誤: {ex.Message}");
}

Console.WriteLine("\n按任意鍵結束...");
Console.ReadKey();

