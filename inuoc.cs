using System;
namespace bai1
{
    public class inuoc
    {
        public static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("In uoc cua mot so nguyen.");
            Console.Write("nhap vao mot so nguyen n: ");
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    Console.Write("{0},", i);
            }
            Console.Write("la uoc cua {0}", n);
        }
    }
}
