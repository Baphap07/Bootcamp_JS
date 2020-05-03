using System;
namespace bai1
{
    public class tongsole
    {
         public static void Main(string[] args)
        {
            int sum = 0,n;
            Console.WriteLine("Tong cac so le: ");
            Console.WriteLine("nhap n: ");
                n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hien thi cac so le: ");
            for(int i = 1; i <= n; i += 2)
            {
                Console.WriteLine("{0} ",i);
                sum += i;  

            }
            Console.WriteLine("{0} so le ban dau la: {1} ", n, sum);

        }
    }
}
