using System;
using System.Dynamic;

class BMI
{
    // field
    private double chieuCao;
    private double canNang;

    // property
    public double ChieuCao
    {
        get { return chieuCao; }
        set { chieuCao = value; }
    }

    public double CanNang
    {
        get { return canNang; }
        set { canNang = value; }
    }

    // constructor rỗng
    public BMI()
    {
    }

    // constructor có tham số
    public BMI(double a, double b)
    {
        ChieuCao = a;
        CanNang = b;
    }

    // hàm tính BMI
    public void TinhBMI()
    {
        Console.Write("Nhap chieu cao (m): ");
        ChieuCao = double.Parse(Console.ReadLine());

        Console.Write("Nhap can nang (kg): ");
        CanNang = double.Parse(Console.ReadLine());

        double bmi = CanNang / (Math.Pow(ChieuCao, 2));

        Console.WriteLine("BMI = " + bmi);

        if (bmi < 18.5)
            Console.WriteLine("Gay");
        else if (bmi < 25)
            Console.WriteLine("Binh thuong");
        else
            Console.WriteLine("Thua can");
    }

    // hàm main
    // static void Main(string[] args)
    // {
    //     BMI b = new BMI();
    //     b.TinhBMI();
    // }
}