using System;

namespace C_.baitapcs.BAiTapVonglap;

public class bai21
{
    public static void hinh1(int n)
    {
        for (int i = 0; i < n; i++)
        {
            {
                for (int t = 0; t < n; t++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();

            }
        }
    }


    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        hinh1(n);
    }
}
