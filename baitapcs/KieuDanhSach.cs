using System;
using System.ComponentModel.Design;

namespace C_.baitapcs;

public class KieuDanhSach
{
    public static void showlist(List<int> a)
    {
        System.Console.WriteLine($"danh sach List la: ");
        foreach (int i in a)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
    }

    static void Main(string[] args)
    {
        List<int> dsInt = new List<int>();//ds kieu so nguyen
        List<int> dsInt1 = new List<int>() { 1, 2, 3, 4, 1, 5, 6, 7, 8, 9 };
        //List<string> dsstring = new List<string>(){"a","b","c"};//ds kieu chuoi
        //List<float> dsfloat = new List<float>();//ds kieu float

        //int n=int.Parse(Console.ReadLine());
        dsInt.Add(5);//them phan tu vao cuoi list
        dsInt.Add(2);
        dsInt.Add(3);
        showlist(dsInt);


        System.Console.WriteLine($"so phan tu co trong danh sach: {dsInt.Count}");

        showlist(dsInt1);
        dsInt1.Remove(1);//neu tim thay 1 thi coa 1 dau tien tim duoc
        System.Console.WriteLine($"danh sach khi xoa so 1 dau tien la:");
        showlist(dsInt1);
        dsInt.Clear();//xoa toan bo phan tu
        System.Console.WriteLine("ds sau khi xoa toan bo phan tu la: ");
        showlist(dsInt);

        dsInt.AddRange(dsInt1);//them dsInt1 vao dsInt
        System.Console.WriteLine("dsInt sau khi them dsInt1 vao la:");
        showlist(dsInt);

        bool kt = dsInt.Contains(1);//ktr 1 co trong list khong
        List<int> ds = dsInt.GetRange(1, 2);//GetRange(index,count)  :lay tu phan tu thu index va so phan tu(count) cua list nguon(dsInt)
        System.Console.WriteLine(kt);
        dsInt1.IndexOf(4);// tra ve vi tri thu index , neu khong tim thay tra ve -1
        dsInt1.Insert(10,11);//them value vao  vi tri index

        dsInt.InsertRange(2,dsInt1);//chen 1 ds vao vi tri thu index
        dsInt.RemoveAt(2);//xoa phan tu tai vi tri index
        dsInt.RemoveRange(0,3);//xoa tu phan tu thu index den count :vd:coune =3 thi xoa 3 phan tu tu ci tri 0
        dsInt.Reverse();//dao nguoc ds
        dsInt.Sort();//sap xep tang dan
        dsInt.Max();//tim max
        dsInt.Min();//tim Min
    }
}
