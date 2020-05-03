using System;
namespace bai1
{
    public class minmax
    {
        public static void Main(string[] args)
        {
            int n, i, min=0, max=0;
            Console.WriteLine("tim so lon nhat va nho nhat.");
            Console.Write("nhap vao so nguyen n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
                min = 0;
                max = n;
            }
            Console.WriteLine("so lon nhat la {0} so nho nhat la {1}", max, min);
        }
    }
}
