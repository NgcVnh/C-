using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace C_.baitapcs
{
    public class KTPassWord
    {
        public static string thietlappw()
        {
            System.Console.WriteLine("Moi ban nhap mat khau cua ban(mat khau phai co chu, co so vaf tu 6 ki tu tro len)");
            string s = Console.ReadLine();
            System.Console.WriteLine("Ban da thiet lap mat khau thanh cong");
            return s;
        }
        public static void ktChuSo(string a, string s)
        {
            int so = 0;
            int chu = 0;
            int dem = 0;
            bool check = true;
            while (check)
            {
                foreach (char x in a)
                {
                    if (char.IsLetter(x))
                    {
                        chu++;
                    }
                    else if (char.IsDigit(x))
                    {
                        so++;
                    }

                }
                if (chu * so != 0 && a.Length >= 6 && a.Equals(s))
                {
                    System.Console.WriteLine("Dang nhap thanh cong");
                    break;
                }
                else
                {
                    System.Console.WriteLine($"Ban da nhap sai mat khau {dem}/5 lan! ");
                    System.Console.WriteLine("============================");
                    System.Console.WriteLine("nhap lai mat khau");
                    a = Console.ReadLine();
                    dem++;
                }

                if (dem == 5)
                {
                    System.Console.WriteLine($"ban da nhap mat khau sai qua {dem} lan");
                    check = false;
                }
            }
        }

        static void Main(string[] args)
        {
            string s = thietlappw();
            System.Console.WriteLine("======================================");
            System.Console.WriteLine("================Login=================");
            System.Console.WriteLine("Nhap mat khau dang nhap:");
            string ip = Console.ReadLine();
            ktChuSo(ip, s);
        }

    }
}