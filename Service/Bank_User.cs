using C_.User;

namespace C_.Service
{


    public class Bank_User
    {
        Customer u;
        public Bank_User(Customer customer)
        {
            u=customer;
        }

        
        public int Nap
        {
            get;
            set;
        }
        private int rut;
        public int Rut
        {
            get{return rut;}
            set
            {
                rut=value;
            }
        }

        public void NapTien()
        {
            System.Console.WriteLine("Nhap sotien nap vao");
            Nap = int.Parse(Console.ReadLine());
            u.soDu += Nap;
            System.Console.WriteLine($"Ban da nap thanh cong{Nap}, so du hienn tai la :{u.soDu}");
        }
        public void RutTien()
        {
            System.Console.WriteLine("nhap so tien bn muon rut");
            Rut = int.Parse(Console.ReadLine());
            if (u.soDu <= 0 || u.soDu < Rut)
            {
                System.Console.WriteLine("tai khoan quy khach khong du de rut!!");
            }
            else
            {
                u.soDu -= Rut;
                System.Console.WriteLine($"Quy khach da rut thanh cong {Rut}");
                System.Console.WriteLine($"So du trong tai khoancon lai la: {u.soDu}");
            }
        }
    }
}