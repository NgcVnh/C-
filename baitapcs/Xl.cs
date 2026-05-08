using System;

class Xl
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("nhap diem trung binh cua ban vao day:");
        double dtb = double.Parse(Console.ReadLine());
        while (dtb <0 || dtb > 10)
        {
            Console.WriteLine("Vui long nhap dung diem so:");
            dtb = double.Parse(Console.ReadLine());
        }

        string xeploai = (dtb >= 8) ? "loai gioi" : (dtb < 8 && dtb > 6.5) ? "loai kha" : "yeu";
        Console.WriteLine(xeploai);
        Console.ReadKey();
    }
}