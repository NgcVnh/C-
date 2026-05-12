using System;

namespace C_.baitapcs;

public class Chuoikitu
{
    static void Main(string[] args)
    {
        // string s = "day la chuoi ki tu";
        // string ss="@hello \n toi ten vinh \t nam nay toi 20 tuoi \\ hoc tai dai hoc sai gon \' \" ";
        // System.Console.WriteLine(s);
        // System.Console.WriteLine(ss);

        // //tach chuoi thanh ki tu le
        // string s1="hello works";
        // System.Console.WriteLine(s1.Length);// do dai chuoi
        // char[] lst=s1.ToCharArray();
        // System.Console.WriteLine(lst);

        //bai tap
        System.Console.WriteLine("nhap vao chuoi ki tu: ");
        string s = Console.ReadLine();
        char[] lst = s.ToCharArray();//chuyen doi thanh mang ki tu
        int ChuThuong = 0;
        int chuHoa = 0;
        int so = 0;
        int space = 0;
        foreach (char c in lst)
        {
            if (char.IsLower(c) == true)
            {
                ChuThuong++;
            }

            if (char.IsUpper(c) == true)
            {
                chuHoa++;
            }
            if (char.IsDigit(c) == true)
            {
                so++;
            }
            if (char.IsWhiteSpace(c) == true)
            {
                space++;
            }
        }
        System.Console.WriteLine($"Co {ChuThuong} chu thuong");
        System.Console.WriteLine($"Co {chuHoa} chu hoa");
        System.Console.WriteLine($"Co {so} so");
        System.Console.WriteLine($"Co {space} space");
    }
}
