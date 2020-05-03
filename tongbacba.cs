using System;
namespace bai1
{
    public class tongbacba
    {
        public static void Main(string[] args)
        {
            int i, n,sum=0;
            Console.WriteLine("tinh tong bac ba.");
            Console.Write("nhap vao so n: ");
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
                sum = sum+i * i * i;
            }
            Console.WriteLine("tinh tong bac ba cua n la: {0}",sum);

        }
    }
}
