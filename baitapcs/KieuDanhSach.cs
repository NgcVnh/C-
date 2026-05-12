using System;
using System.ComponentModel.Design;

namespace C_.baitapcs;

public class KieuDanhSach
{
    //cach khoi tao

    static void Main(string[] args)
    {
        List<int> dsInt = new List<int>();//ds kieu so nguyen
        //List<string> dsstring = new List<string>();//ds kieu chuoi
        //List<float> dsfloat = new List<float>();//ds kieu float

        //int n=int.Parse(Console.ReadLine());
        dsInt.Add(5);//them phan tu vao cuoi list
        dsInt.Add(2);
        dsInt.Add(3);
        foreach(int i in dsInt){
            System.Console.Write(i+" ");
        }
            System.Console.WriteLine(dsInt.Count);

    }
}
