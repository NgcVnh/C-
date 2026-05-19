using System;
using System.Reflection.Metadata.Ecma335;

namespace C_.User;

public class Customer
{
    public string NameCustomer { get; set; }
    public int Tuoi { get; set; }
    public int soDu
    {
        get;
        set;
    }

    public Customer(){}
    public Customer(string a, int b, int c)
    {
        NameCustomer = a;
        Tuoi = b;
        soDu = c;
    }
    public void ShowInforCus()
    {
        System.Console.WriteLine($"Ten khach hang: {NameCustomer}");
        System.Console.WriteLine($"Tuoi: {Tuoi}");
        System.Console.WriteLine($"So du:{soDu}");
    }
}
