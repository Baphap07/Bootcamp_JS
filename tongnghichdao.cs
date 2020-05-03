using System;
namespace bai1
{
    public class tongnghichdao
    {
        public static void Main(string[] args)
        {
            float i, n, sum = 0;
            Console.WriteLine("Tinh tong so nghich dao.");
            Console.Write("Nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum = sum + 1 / i;
            }
            Console.WriteLine("Tong cac so nghich dao cua {0} la: {1} ", n, sum);
        }
    }
}
