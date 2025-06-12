// See https://aka.ms/new-console-template for more information
using LeetCode.Solutions;

Console.WriteLine("LeetCode 解題測試程式");

try
{
    DesignLinkedList obj = new DesignLinkedList();
    var get = obj.Get(0);
    obj.AddAtHead(1);
    obj.DeleteAtIndex(0);
    obj.AddAtTail(3);
    obj.AddAtIndex(1, 2);
    var get1 = obj.Get(1);
    var get2 = obj.Get(3);
    obj.DeleteAtIndex(1);
    var get3 = obj.Get(1);

    
}
catch (Exception ex)
{
    Console.WriteLine($"執行錯誤: {ex.Message}");
}

Console.WriteLine("\n按任意鍵結束...");
Console.ReadKey();

