using System;

namespace C_.baitapcs;

public class Chuoikitu
{
        // static void Main(string[] args)
        // {
                // string s = "day la chuoi ki tu";
                // string ss="@hello \n toi ten vinh \t nam nay toi 20 tuoi \\ hoc tai dai hoc sai gon \' \" ";
                // System.Console.WriteLine(s);
                // System.Console.WriteLine(ss);

                // //tach chuoi thanh ki tu le
                // string s1="hello world";
                // System.Console.WriteLine(s1.Length);// do dai chuoi
                // char[] lst=s1.ToCharArray();
                // System.Console.WriteLine(lst);

                //bai tap
                // System.Console.WriteLine("nhap vao chuoi ki tu: ");
                // string s = Console.ReadLine();
                // char[] lst = s.ToCharArray();//chuyen doi thanh mang ki tu
                // int ChuThuong = 0;
                // int chuHoa = 0;
                // int so = 0;
                // int space = 0;
                // foreach (char c in lst)
                // {
                //     if (char.IsLower(c) == true)
                //     {
                //         ChuThuong++;
                //     }

                //     if (char.IsUpper(c) == true)
                //     {
                //         chuHoa++;
                //     }
                //     if (char.IsDigit(c) == true)
                //     {
                //         so++;
                //     }
                //     if (char.IsWhiteSpace(c) == true)
                //     {
                //         space++;
                //     }
                // }
                // System.Console.WriteLine($"Co {ChuThuong} chu thuong");
                // System.Console.WriteLine($"Co {chuHoa} chu hoa");
                // System.Console.WriteLine($"Co {so} so");
                // System.Console.WriteLine($"Co {space} space");

                //so sanh 2 chuoi
                // string chuoi1 = "hello";
                // string chuoi2 = "helloo";
                // string chuoi3 = "hello";

                // if (chuoi1.CompareTo(chuoi3)==0)
                // {
                //     System.Console.WriteLine("chuoi 1 = chuoi 3");
                // }
                // if (chuoi1.CompareTo(chuoi2) != 0)
                // {
                //     System.Console.WriteLine("chuoi 1 va chuoi 2 khac nhau");
                // }

                // string s = "    hello world    ";
                // System.Console.WriteLine(s.Length);//do dai chuoi
                // System.Console.WriteLine(s.IndexOf("e"));//tim gio tri trong chuoi tra ve vi tri index
                // System.Console.WriteLine($"{string.Join(" ,", s)}");
                // bool kt = s.StartsWith("h");
                // System.Console.WriteLine(kt);// kiem tra chuoi co bat daua bang tu ben trong hay khong

                // string s1 = s.Substring(3, 2);//trich tu chuoi ban dau tu vi tri thu index va lay count ki tu
                // System.Console.WriteLine(s1);
                // System.Console.WriteLine(s.ToUpper());//tra ve kieu in hoa
                // System.Console.WriteLine(s.ToLower());///tra chuoi ve chu thuong
                // System.Console.WriteLine(s.Trim());//xoa khoang trang dau va cuoi:trimStart()xoa khoang trang dau chuoi trimEnd() xoa khoang trang cuoi chuoi
                // string[] tachchuoi = s.Split(' '); //trong (_) las dk tach
                // foreach (string i in tachchuoi)
                // {
                //         System.Console.WriteLine(i);
                // }
                // System.Console.WriteLine($"{string.Join("-", tachchuoi)}");//gop chuoi 
                //baitap1 tinh tong cua cac mon hoc
                // string str1 = "English= 78 Scinece= 83 Math= 68 History= 65";
                // string[] str2 = str1.Split(' ');
                // string str3 = "";
                // foreach (string i in str2)
                // {
                //         foreach (char c in i)
                //         {
                //                 if (char.IsDigit(c))
                //                 {
                //                         str3 += " " + i;
                //                         break;
                //                 }
                //         }
                // }
                // //System.Console.WriteLine(str3);
                // string[] str4 = str3.Trim().Split(" ");
                // int sum = 0;
                // double tbc = 0.0;
                // foreach (string i in str4)
                // {
                //         sum += int.Parse(i);
                //         tbc = sum*1.0 / str4.Length;
                // }
                // System.Console.Write($"{string.Join("+", str4)}");
                // System.Console.WriteLine($"={sum}");
                // System.Console.WriteLine($"trung binh cong :  {tbc}");
   //     }
}
