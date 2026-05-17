using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace C_.baitapcs
{
    public class KTPassWord
    {
        public static void ktChuSo(string a)
        {
            string mk = "Pnv12345";
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
                if (chu * so != 0 && a.Length >= 6 || a.Equals(mk))
                {
                    System.Console.WriteLine("mat khau hop le");
                    break;
                }
                else
                {
                    System.Console.WriteLine("sai mat khau");
                    dem++;
                }
                System.Console.WriteLine($"moi ban nhap lai lan thu {dem} :");
                a = Console.ReadLine();
                if (dem == 5)
                {
                    check = false;
                }
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("nhap mat khau");
            string? ip = Console.ReadLine();
            ktChuSo(ip);
        }

    }
}