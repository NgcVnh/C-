using System;
using System.Threading.Channels;

namespace C_.baitapcs;

public class Kieukitu
{
    static void Main(string[] args)
    {
        // cach khai bao
        char c = 'p';//char khai bao 1 ki tu
        char c2 = (char)64;//<ma ASCII>

        //ep kieu char
        char c3 = char.Parse("1");
        System.Console.WriteLine(c3);
        System.Console.WriteLine(c3.GetType().ToString());

        // chyen doi du lieu
        char c4=Convert.ToChar('3');
        Console.WriteLine(c4.GetType().ToString());
    }

}
