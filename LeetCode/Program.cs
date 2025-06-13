// See https://aka.ms/new-console-template for more information
using LeetCode.Solutions;

Console.WriteLine("LeetCode 解題測試程式");

try
{
    var solution = new LinkedListCycle();
    solution.Solve(new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1,new ListNode(1))))));
}
catch (Exception ex)
{
    Console.WriteLine($"執行錯誤: {ex.Message}");
}

Console.WriteLine("\n按任意鍵結束...");
Console.ReadKey();

