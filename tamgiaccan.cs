using System;
namespace bai1
{
    public class tamgiaccan
    {
        public static void Main(string[] args)
        {
            int i,j, n;
            Console.WriteLine("ve tam giac can.");
            Console.WriteLine("nhap vao so hang can ve: ");
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2*i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
