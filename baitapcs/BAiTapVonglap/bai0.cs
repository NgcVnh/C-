using System;
using System.Globalization;
using System.Numerics;

namespace C_.baitapcs.BAiTapVonglap;

public class bai0
{
    public static void BAI0(int n)
    {
        //dong 1
        System.Console.WriteLine($"so tu 1 den {n}:");
        for (int i = 1; i <= n; i++)
        {
            System.Console.Write(i);
        }
        //dong2
        System.Console.WriteLine($"so tu {n} ve 0:");
        for (int i = n; i >= 0; i--)
        {
            System.Console.Write(i);
        }
        //dong 3
        System.Console.WriteLine($"so chan nho hon {n}:");
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.Write(i);
            }
        }
        //dong4
        System.Console.WriteLine($"so le nho hon {n}: ");
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                System.Console.Write(i);
            }
        }
        //dong 5
        System.Console.WriteLine($"Boii so cua 4 nho hon{n}:");
        for (int i = 0; i <= n; i++)
        {
            if (i % 4 == 0)
            {
                System.Console.Write(i);
            }
        }
        //dong6
        System.Console.WriteLine($"{n} chu thuong  dau tien:");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write((char)('a'+i));
        }
        //dong 7
        System.Console.WriteLine($"{n} chu thuong chuoi cung:");
        for (int i = n-1;i>=0 ;i-- )
        {
            System.Console.Write((char)('z'-i));
        }
    }
    // static void Main(string[] args)
    // {
    //     int n = int.Parse(Console.ReadLine());
    //     BAI0(n);
    // }
}
