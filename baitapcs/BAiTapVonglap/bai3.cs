using System;

namespace C_.baitapcs.BAiTapVonglap;

public class bai3
{
    static void BAI3()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("nhap vao boi so can tim");
        int b = int.Parse(Console.ReadLine());
        int sum=0;
        System.Console.WriteLine($"tong boi cua {b} la");
        for (int i = 0; i <= n; i++)
        {
            if (i % b == 0)
            {
                sum+=i;
            }
        }
        System.Console.WriteLine($"tong boi so cua {b} la:  {sum}");
    }
    // static void Main(string[] args)
    // {
    //     BAI3();
    // }
}
